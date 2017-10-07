using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using DirectShowLib;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using Leap;
using System.Windows;
using System.Drawing.Imaging;
using System.Diagnostics;



namespace projedenemeleri1
{

    public partial class Form1 : Form
    {
        private Capture capture;
        private bool captureStatus;
        int CameraDevice = 0;
        Video_Device[] WebCams;
        Controller controller = new Controller();
        NetworkStream networkStream;
        TcpClient clientSocket;
        Frame frame;
        int handposx;
        float handposy;
        float handposz;
        int pick;
        int thumbangle;
        int indexangle;
        int middleangle;
        int ringangle;
        int pinkyangle;
        double grab;
        int diff = 3;


        static Queue<double> anglesindex = new Queue<double>(new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        static Queue<double> anglesthumb = new Queue<double>(new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        static Queue<double> anglespinky = new Queue<double>(new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        static Queue<double> anglesmiddle = new Queue<double>(new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        static Queue<double> anglesring = new Queue<double>(new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

        private Image<Gray, Byte> m_imgThreshold;
        int HueLow = 0;
        int SatLow = 0;
        int ValLow = 0;
        int HueHigh = 0;
        int SatHigh = 0;
        int ValHigh = 0;

        System.Threading.Timer detectTimer;

        byte[] netdata;



        //-------
        List<Triangle2DF> triangleList = new List<Triangle2DF>();
        List<MCvBox2D> boxList = new List<MCvBox2D>();
        Gray cannyThreshold = new Gray(180);
        Gray cannyThresholdLinking = new Gray(120);
        Gray circleAccumulatorThreshold = new Gray(120);
        Image<Gray, Byte> gray;
        Image<Gray, Byte> cannyEdges;
        Contour<System.Drawing.Point> currentContour;
        Ellipse asd;

        int graytresh1 = 39, graytresh2 = 10;

        int contourarea = 250;
        double contourperimeter = 0.05;


        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            prepareDetection();
            clientRead();
            button1.Enabled = false;
            listBox1.Items.Add(DateTime.Now + " Teletouch GUI başlatıldı");
            textBox2_TextChanged(null, null);
        }

        private void prepareDetection()
        {


            Task.Run(() =>
            {
                detectTimer = new System.Threading.Timer(new System.Threading.TimerCallback(detect_tick), null, 0, 50);
                //timer.InitializeLifetimeService();
                
            });
               
          
        }

        private void detect_tick(object state)
        {

                Controller controller = new Controller(); //Controllerin başlatılması
                frame = controller.Frame(); //Frame okumasının yapılması
                detectfinger(frame); //fonksiyonun cağrı

                label13.Invoke((MethodInvoker)(() => label13.Text = trackBar1.Value.ToString()));
                label14.Invoke((MethodInvoker)(() => label14.Text = trackBar2.Value.ToString()));
                label15.Invoke((MethodInvoker)(() => label15.Text = trackBar3.Value.ToString()));
                label16.Invoke((MethodInvoker)(() => label16.Text = trackBar4.Value.ToString()));
                label17.Invoke((MethodInvoker)(() => label17.Text = trackBar5.Value.ToString()));
                label18.Invoke((MethodInvoker)(() => label18.Text = trackBar6.Value.ToString()));

                if (clientSocket != null)
                {
                    System.Threading.Thread.Sleep(50);
                    string deger = "|" + thumbangle.ToString() + "/" + indexangle.ToString() + "/" +
                    middleangle.ToString() + "/" + ringangle.ToString() + "/" + pinkyangle.ToString()
                    + "/" + grab.ToString() + "+";

                    label_baglanti_d.Invoke((MethodInvoker)(() => label_baglanti_d.Text = "Bağlandı"));
                    label_baglanti_d.Invoke((MethodInvoker)(() => label_baglanti_d.ForeColor = Color.Green));


                    var bytes = GetBytes(deger);
                    networkStream.Write(bytes, 0, bytes.GetLength(0));
                    handposy = 0;
                    handposz = 0;
                }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }


            if (capture != null)
            {
                if (captureStatus)
                {

                    Application.Idle -= ProcessFrame;
                }
                else
                {

                    Application.Idle += ProcessFrame;
                }

                captureStatus = !captureStatus;
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> ImageFrame = capture.QueryFrame();  //line 1
            cameraView.Image = ImageFrame;        //line 2
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            string ipadress = textBox1.Text;
            clientSocket = new TcpClient(ipadress, 8001);
            networkStream = clientSocket.GetStream();
            listBox1.Items.Add(DateTime.Now + " " + textBox1.Text + " adresine bağlanılıyor");

        }

        byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }



        public void detectfinger(Leap.Frame frame)
        {

            // Console.WriteLine("Hand count " + frame.Hands.Count);
            if (frame.Hands.Count > 0 && frame.Hands[0].Confidence == 1)
            {

                var hand = frame.Hands[0];

                handposx = Convert.ToInt32(hand.PalmPosition.x);
                handposy = hand.PalmPosition.y;
                handposz = hand.PalmPosition.z;
                grab = hand.GrabStrength;
                pick = Convert.ToInt32(hand.PinchStrength);
                //Console.WriteLine("Pos: x:" + hand.PalmPosition.x + ", y:" + hand.PalmPosition.y + ", z:" + hand.PalmPosition.z);
                //x_label.Invoke((MethodInvoker)(() => x_label.Text = "X: " + hand.PalmPosition.x));
                y_label.Invoke((MethodInvoker)(() => y_label.Text = "Y: " + hand.PalmPosition.y));
                z_label.Invoke((MethodInvoker)(() => z_label.Text = "Z: " + hand.PalmPosition.z));
                kavrama_label.Invoke((MethodInvoker)(() => kavrama_label.Text = "Kavrama: " + hand.GrabStrength));

                label1.Invoke((MethodInvoker)(() => label1.Text = "Conf: " + frame.Hands[0].Confidence.ToString()));

                foreach (Finger finger in frame.Hands[0].Fingers)
                {

                    Bone bone1 = finger.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                    Bone bone2 = finger.Bone(Bone.BoneType.TYPE_PROXIMAL);
                    
                    double angle = 180 - ((bone1.Direction.AngleTo(bone2.Direction) / Math.PI) * 180) * 2;

                    
                    /*
                    Leap.Vector bone0Dir = frame.Fingers[1].Bone(Bone.BoneType.TYPE_METACARPAL).Direction;
                    Leap.Vector bone1Dir = frame.Fingers[1].Bone(Bone.BoneType.TYPE_PROXIMAL).Direction;

                    double angle2 = ((bone0Dir.AngleTo(bone1Dir) / Math.PI) * 180) * 2;
    */
                    //kavrama_label.Invoke((MethodInvoker)(() => kavrama_label.Text = angle2.ToString()));
                    if (grab > 0.99)
                    {
                        angle = 5;
                    }

                    int calcAngle = (int)(180 - angle);

                    if (finger.Type == Finger.FingerType.TYPE_INDEX)
                    {
                        indexangle =  getNewAngle(indexangle,calcAngle);
                        fingeri.Invoke((MethodInvoker)(() => fingeri.Text = "Index: " + indexangle.ToString()));
                        ///fingeri.Invoke((MethodInvoker)(() => fingeri.Text = "Index: " + Math.Floor(findAngle(frame, true)).ToString()));
                        //label1.Invoke((MethodInvoker)(() => label1.Text = "Index: " +  Math.Floor(findAngle(frame, false)).ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_THUMB)
                    {


                        Bone bonex = finger.Bone(Bone.BoneType.TYPE_DISTAL);
                        Bone boney = finger.Bone(Bone.BoneType.TYPE_INTERMEDIATE);

                        double angle2 = 180 - ((bonex.Direction.AngleTo(boney.Direction) / Math.PI) * 180) * 2;

                        thumbangle = (int)(180 - angle2);

                        if (!finger.IsExtended)
                        {
                            thumbangle = 165;
                        }

                        fingert.Invoke((MethodInvoker)(() => fingert.Text = "Thumb: " + thumbangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_MIDDLE)
                    {
                        //anglesmiddle.Enqueue(angle);
                        //anglesmiddle.Dequeue();
                        middleangle = getNewAngle(middleangle, calcAngle);
                        fingerm.Invoke((MethodInvoker)(() => fingerm.Text = "Middle: " + middleangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_RING)
                    {

                        ringangle = getNewAngle(ringangle, calcAngle);
                        fingerr.Invoke((MethodInvoker)(() => fingerr.Text = "Ring: " + ringangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_PINKY)
                    {
                        pinkyangle = getNewAngle(pinkyangle, calcAngle);
                        fingerp.Invoke((MethodInvoker)(() => fingerp.Text = "Pinky: " + pinkyangle.ToString()));
                    }

                    if (finger.IsExtended)
                    {
                        fingertype.Invoke((MethodInvoker)(() => fingertype.Text = "Parmak: " + finger.Type.ToString()));


                    }
                }
            }


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            networkStream.Close(); // Network kapatma
            networkStream = null;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void clientRead()
        {
            Task.Run(() =>
            {
                bool slept = false;
                while (true)
                {
                    if (clientSocket != null)
                    {
                        if (!slept)
                        {
                            slept = true;
                        }
                        var networkStream = clientSocket.GetStream();
                        byte[] tmp;
                        //byte[] netdata;
                        tmp = ReadData(networkStream, 4);
                        int pictureSize = BitConverter.ToInt32(tmp, 0);
                        netdata = ReadData(networkStream, pictureSize);

                        if (radioButton1.Checked)
                        {
                            Image<Bgr, byte> depthImage = new Image<Emgu.CV.Structure.Bgr, byte>(320, 240);
                            depthImage.Bytes = netdata;
                            cameraBox.Image = depthImage;

                        }

                        else if (radioButton2.Checked)
                        {
                            Image<Hsv, byte> depthImage = new Image<Emgu.CV.Structure.Hsv, byte>(320, 240);
                            depthImage.Bytes = netdata;
                            cameraBox.Image = depthImage;
                        }

                        else if (radioButton3.Checked)
                        {
                            Image<Hsv, byte> depthImage = new Image<Emgu.CV.Structure.Hsv, byte>(320, 240);
                            if (netdata != null)
                            {
                                depthImage.Bytes = netdata;

                                m_imgThreshold = depthImage.InRange(new Hsv(HueLow, SatLow, ValLow), new Hsv(HueHigh, SatHigh, ValHigh));
                                cameraBox.Image = m_imgThreshold;
                            }

                        }

                        else if (radioButton4.Checked)
                        {
                            Image<Rgb, byte> depthImage = new Image<Emgu.CV.Structure.Rgb, byte>(320, 240);
                            depthImage.Bytes = netdata;
                            cameraBox.Image = depthImage;
                        }
                        else if (radioButton5.Checked)
                        {
                            Image<Bgr, byte> depthImage = new Image<Emgu.CV.Structure.Bgr, byte>(320, 240);
                            depthImage.Bytes = netdata;

                            findsquare(depthImage);
                        }


                        tmp = ReadData(networkStream, 4);
                        int sensorSize = BitConverter.ToInt32(tmp, 0);
                        tmp = ReadData(networkStream, sensorSize);
                        string message = System.Text.Encoding.UTF8.GetString(tmp, 0, sensorSize);
                        Console.WriteLine(message);

                        //string message = "";
                        //for (int i = 0; i < k; i++)
                        //{
                        //    message += Convert.ToChar(b[i]);

                        //}
                        //string []sa = message.Split(new char[] {'\r','\n'});

                        //message = sa[0];


                        //string[] sa = message.Split(new char[] { '\r', '\n' });

                        //message = sa[0];
                        string[] splited = message.Split('/');
                        if (splited.Length > 1 && splited[0] != null && splited[1] != null &&
                            splited[2] != null && splited[3] != null && splited[4] != null)
                        {
                            data.temp = Convert.ToInt32(splited[0]);
                            data.pres = Convert.ToInt32(splited[1]);
                            data.humidty = Convert.ToInt32(splited[2]);
                            data.lighti = Convert.ToInt32(splited[3]);
                            data.findex = Convert.ToInt32(splited[4]);


                            chart1.Invoke((MethodInvoker)(() => chart1.Series["Sıcaklık"].Points.AddY(data.temp)));
                            chart1.Invoke((MethodInvoker)(() => chart1.Series["Nem"].Points.AddY(data.humidty)));
                            chart1.Invoke((MethodInvoker)(() => chart1.Series["Basınç"].Points.AddY(data.pres)));
                            chart1.Invoke((MethodInvoker)(() => chart1.Series["Işık"].Points.AddY(data.lighti)));

                            label_sicaklik.Invoke((MethodInvoker)(() => label_sicaklik.Text = "Sıcaklık: " + data.temp.ToString()));
                            label_basinc.Invoke((MethodInvoker)(() => label_basinc.Text = "Basınç: " + data.pres.ToString()));
                            label_nem.Invoke((MethodInvoker)(() => label_nem.Text = "Nem: " + data.humidty.ToString()));
                            label_isik.Invoke((MethodInvoker)(() => label_isik.Text = "Işık: " + data.lighti.ToString()));
                            Console.WriteLine(splited[4]);
                            progressBar2.Invoke((MethodInvoker)(() => progressBar2.Value = data.findex));

                        }
                    }
                }
            });

        }

        private byte[] ReadData(NetworkStream stream, int size) //Streamden gelen kadar okuma
        {
            byte[] result = new byte[size];

            int readByte = 0;
            while (readByte != size)
            {
                byte[] tmp = new byte[size];
                int oldReadByte = readByte;
                int newRead = stream.Read(tmp, 0, size - readByte);
                readByte += newRead;
                byte[] qq = tmp.Take(newRead).ToArray();
                qq.CopyTo(result, oldReadByte);
                qq = null;
                tmp = null;
            }
            return result;
        }

        private void sICAKLIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sensors sensoropen = new sensors(); //Sensör sayfasını açıyor
            sensoropen.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (frame != null) //Config menüsü için
            {
                config page = new config();
                page.Show();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Sıfırlama butonu
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;

        }

        private void button3_Click_1(object sender, EventArgs e) //Resim kaydedilmesi
        {
            Bitmap img = new Bitmap(cameraBox.Image.Bitmap);
            img.Save(@"C:\Users\Musa\Documents\Visual Studio 2013\Projects\projedenemeleri1\projedenemeleri1\fotolar\asd.jpeg", ImageFormat.Jpeg);
            addListbox("Resim Kaydedildi");
        }


        private void sENSÖRDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProduceThresholdImage()
        {

            trackBar1.Invoke((MethodInvoker)(() => HueLow = trackBar1.Value)); //Trackbar value okuma
            trackBar2.Invoke((MethodInvoker)(() => SatLow = trackBar2.Value));
            trackBar3.Invoke((MethodInvoker)(() => ValLow = trackBar3.Value));
            trackBar4.Invoke((MethodInvoker)(() => HueHigh = trackBar4.Value));
            trackBar5.Invoke((MethodInvoker)(() => SatHigh = trackBar5.Value));
            trackBar6.Invoke((MethodInvoker)(() => ValHigh = trackBar6.Value));

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();

        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ProduceThresholdImage();
        }

        private void addListbox(string message) // Listbox ekleme
        {
            listBox1.Items.Add(DateTime.Now + " " + message);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void findsquare(Image<Bgr, Byte> img)
        {
            Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

            Gray cannyThreshold = new Gray(graytresh1);
            Gray cannyThresholdLinking = new Gray(graytresh2);


            Image<Gray, Byte> cannyEdges = gray.Canny(cannyThreshold, cannyThresholdLinking);
            LineSegment2D[] lines = cannyEdges.HoughLinesBinary(1, Math.PI / 45.0, 1, 3, 80)[0];

            List<MCvBox2D> boxList = new List<MCvBox2D>();

            using (MemStorage storage = new MemStorage())
                for (Contour<System.Drawing.Point> contours = cannyEdges.FindContours(); contours != null; contours = contours.HNext)
                {
                    currentContour = contours.ApproxPoly(contours.Perimeter * contourperimeter, storage);

                    if (contours.Area > contourarea)
                    {
                        if (currentContour.Total == 4)
                        {
                            bool isRectangle = true;
                            System.Drawing.Point[] pts = currentContour.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);
                            //using edges i found coordinates.
                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(
                                   edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRectangle = false;
                                    break;
                                }
                                if (isRectangle)
                                {
                                    boxList.Add(currentContour.GetMinAreaRect());
                                    asd = new Ellipse(new PointF(currentContour[0].X, currentContour[0].Y), new SizeF(10, 10), 1);

                                    Console.WriteLine(currentContour[1]);
                                }
                            }
                        }
                    }
                }

            // cameraBox.Image = cannyEdges;

            Image<Bgr, Byte> triangleRectangleImage = img.Copy();
            foreach (Triangle2DF triangle in triangleList)
                triangleRectangleImage.Draw(triangle, new Bgr(Color.DarkBlue), 2);

            foreach (MCvBox2D box in boxList)
                triangleRectangleImage.Draw(box, new Bgr(Color.DarkOrange), 2);

            triangleRectangleImage.Draw(asd, new Bgr(Color.DarkBlue), 3);
            //MCvFont f= new MCvFont() 
            //triangleRectangleImage.Draw(currentContour[0].X.ToString()+ " " +currentContour[0].Y.ToString(),MCvFont)
            cameraBox.Image = triangleRectangleImage;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now + "Anlık Koordinatlar: ");
            for (int i = 0; i < 4; i++)
            {
                String sendmessage = "X: " + currentContour[i].X.ToString() + "," + "Y: " + currentContour[i].Y.ToString();
                listBox1.Items.Add(sendmessage);
                sendmessage = "";
            }
        }

        private double findAngle(Frame frame,bool stable)
        {
            var v1 = frame.Hands[0].PalmNormal;

            Leap.Vector v2;
            if (stable)
            {
              v2 =   frame.Hands[0].Fingers[1].StabilizedTipPosition;
            }
            else
            {
              v2 = frame.Hands[0].Fingers[1].Direction; ;
            }




                var vectorProduct = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            var v1Norm = Math.Sqrt(v1.x * v1.x + v1.y * v1.y + v1.z * v1.z);
            var v2Norm = Math.Sqrt(v2.x * v2.x + v2.y * v2.y + v2.z * v2.z);
            var cos = Math.Acos(vectorProduct / (v1Norm * v2Norm));
            return cos * 180 / Math.PI;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int newVal;
             if(Int32.TryParse(textBox2.Text, out newVal))
            {
                diff = newVal;
            }

        }

        int getNewAngle(int oldAngle, int newAngle)
        {
            return Math.Abs(newAngle - oldAngle) > diff ? newAngle : oldAngle; 
        }
    }
}
