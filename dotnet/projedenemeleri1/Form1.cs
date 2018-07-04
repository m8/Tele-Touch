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
using Emgu.CV.Structure;
using System.Net.Sockets;
using Leap;
using System.Drawing.Imaging;

/// </TELETOUCH MAIN APP >
/// 
/// Version: 1.0.5
/// 
/// 
 

namespace projedenemeleri1
{

    public partial class Form1 : Form
    {

        // ***************LEAP CONTROLLERS*************** 
        private Capture leap_capture;
        Controller leap_controller = new Controller();
        Frame leap_frame;

       // ***************FINGER VARIABLES****************    
        float handposy, handposz;
        int thumbangle, indexangle, middleangle, ringangle, pinkyangle, pick, handposx;
        double grab;

        //****************EmguCV Variables***************
        List<Triangle2DF> triangleList = new List<Triangle2DF>();
        List<MCvBox2D> boxList = new List<MCvBox2D>();
        Gray cannyThreshold = new Gray(180);
        Gray cannyThresholdLinking = new Gray(120);
        Gray circleAccumulatorThreshold = new Gray(120);
        Contour<System.Drawing.Point> currentContour;
        Ellipse ellipse;
        int graytresh1 = 39, graytresh2 = 10, contourarea = 250;
        double contourperimeter = 0.05;
        int HueLow, SatLow, ValLow, HueHigh, SatHigh, ValHigh = 0;
        private Image<Gray, Byte> m_imgThreshold;

        //****************Socket Variables***************
        NetworkStream networkStream;
        TcpClient clientSocket;
        byte[] netdata;
        System.Threading.Timer detectTimer;
        string[] splited;

        int diff = 3;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_configuration.Enabled = false;
            listBox_logger.Items.Add(DateTime.Now + " Teletouch GUI is started");

            if (!leap_controller.IsConnected)
            {
                MessageBox.Show("Leap controller couldn't found","Plug your LEAP Controller",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            prepareDetection();

            clientRead();
      
            textBox2_TextChanged(null, null);
        }

        private void prepareDetection()
        {

            Task.Run(() =>
            {
                detectTimer = new System.Threading.Timer(new System.Threading.TimerCallback(timer_tick), null, 0, 50); //Creating new timer for reading from Leap Motion
                
            });
                        
        }

        private void timer_tick(object state)
        {

                Controller controller = new Controller(); //Starting Controller
                leap_frame = controller.Frame(); //Frame okumasının yapılması
                detectfinger(leap_frame); //fonksiyonun cağrı

                write_to_label(label_trackbar1, trackBar1.Value.ToString());
                write_to_label(label_trackbar2, trackBar2.Value.ToString());
                write_to_label(label_trackbar3, trackBar3.Value.ToString());
                write_to_label(label_trackbar4, trackBar4.Value.ToString());
                write_to_label(label_trackbar5, trackBar5.Value.ToString());
                write_to_label(label_trackbar6, trackBar6.Value.ToString());
    

                if (clientSocket != null)
                {
                    //System.Threading.Thread.Sleep(50);
                    string deger = "|" + thumbangle.ToString() + "/" + indexangle.ToString() + "/" +
                    middleangle.ToString() + "/" + ringangle.ToString() + "/" + pinkyangle.ToString()
                    + "/" + grab.ToString() + "+";

                    write_to_label(label_baglanti_d, "Connected");
                    label_baglanti_d.Invoke((MethodInvoker)(() => label_baglanti_d.ForeColor = Color.Green));
                    
                    

                    var bytes = GetBytes(deger);

                    networkStream.Write(bytes, 0, bytes.GetLength(0));

                    handposy = 0;
                    handposz = 0;
                }


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




        #region TCP Functions

        private void clientRead() //Get camera and sensor values from Raspberry
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
                        byte[] tmp_data;
                  
                        tmp_data = networkStreamtoByte(networkStream, 4);
                        int pictureSize = BitConverter.ToInt32(tmp_data, 0);
                        netdata = networkStreamtoByte(networkStream, pictureSize);

                        radioCheckedImageChange();

                        tmp_data = networkStreamtoByte(networkStream, 4);
                        int sensorSize = BitConverter.ToInt32(tmp_data, 0);
                        tmp_data = networkStreamtoByte(networkStream, sensorSize);

                        string message = System.Text.Encoding.UTF8.GetString(tmp_data, 0, sensorSize);


                        splited = message.Split('/');


                        if (splited.Length > 1 && splited[0] != null && splited[1] != null &&
                            splited[2] != null && splited[3] != null && splited[4] != null)
                        {

                            data.sensor_temp = Convert.ToInt32(splited[0]);
                            data.sensor_pressure = Convert.ToInt32(splited[1]);
                            data.sensor_humidty = Convert.ToInt32(splited[2]);
                            data.sensor_light_i = Convert.ToInt32(splited[3]);
                            data.sensor_force_index = Convert.ToInt32(splited[4]);


                            chart_sensor_graphics.Series["Sıcaklık"].Points.AddY(data.sensor_temp);
                            chart_sensor_graphics.Series["Nem"].Points.AddY(data.sensor_humidty);
                            chart_sensor_graphics.Series["Basınç"].Points.AddY(data.sensor_pressure);
                            chart_sensor_graphics.Series["Işık"].Points.AddY(data.sensor_light_i);


                            write_to_label(label_sicaklik, "Temperature: " + data.sensor_temp.ToString());
                            write_to_label(label_basinc, "Pressure: " + data.sensor_pressure.ToString());
                            write_to_label(label_nem, "Humidity: " + data.sensor_humidty.ToString());
                            write_to_label(label_isik, "Light In: " + data.sensor_light_i.ToString());

                            progressBar_index.Value = data.sensor_force_index;

                        }
                    }
                }
            });

        }

        


        private byte[] networkStreamtoByte(NetworkStream stream, int size) //Read from stream
        {
            byte[] result = new byte[size];

            int readByte = 0;
            while (readByte != size)
            {
                byte[] tmp = new byte[size];
                int oldReadByte = readByte;
                int newRead = stream.Read(tmp, 0, size - readByte);
                readByte += newRead;
                byte[] last_val = tmp.Take(newRead).ToArray();
                last_val.CopyTo(result, oldReadByte);
                last_val = null;
                tmp = null;
            }
            return result;
        }

        #endregion


        #region M_Functions

        public void write_to_label(Label label, string text) //Change label's text function
        {
            label.Invoke((MethodInvoker)(() => label.Text = text));
        }

        private void addListbox(string message) // Adding Element to Logger
        {
            listBox_logger.Items.Add(DateTime.Now + " " + message);
        }

        byte[] GetBytes(string str) //Getting bytes from string
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        #endregion


        #region LEAP Functions

        public void detectfinger(Leap.Frame frame) // Detect hand and calculate finger bending values
        {

            if (frame.Hands.Count > 0 && frame.Hands[0].Confidence == 1)
            {

                var hand = frame.Hands[0];

                //**************Values From Hand**********************
                handposx = Convert.ToInt32(hand.PalmPosition.x);
                handposy = hand.PalmPosition.y;
                handposz = hand.PalmPosition.z;
                grab = hand.GrabStrength;
                pick = Convert.ToInt32(hand.PinchStrength);
                //----------------------------------------------------

                write_to_label(label_hand_y, "Y: " + hand.PalmPosition.y);
                write_to_label(label_hand_x, "X: " + hand.PalmPosition.x);
                write_to_label(label_hand_z, "Z: " + hand.PalmPosition.z);
                write_to_label(label_hand_grab, "Grab: " + hand.GrabStrength);



                foreach (Finger finger in frame.Hands[0].Fingers)
                {

                    //***************Get Angle From Finger******************

                    Bone bone1 = finger.Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                    Bone bone2 = finger.Bone(Bone.BoneType.TYPE_PROXIMAL);

                    double angle = 180 - ((bone1.Direction.AngleTo(bone2.Direction) / Math.PI) * 180) * 2;

                    //-------------------------------------------------------

                    if (grab > 0.99)
                    {
                        angle = 5;
                    }

                    int calcAngle = (int)(180 - angle);

                    if (finger.Type == Finger.FingerType.TYPE_INDEX)
                    {
                        indexangle = getNewAngle(indexangle, calcAngle);
                        data.leap_finger_index = indexangle;
                        fingeri.Invoke((MethodInvoker)(() => fingeri.Text = "Index: " + indexangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_THUMB)
                    {


                        Bone bonex = finger.Bone(Bone.BoneType.TYPE_DISTAL);
                        Bone boney = finger.Bone(Bone.BoneType.TYPE_INTERMEDIATE);

                        double angle2 = 180 - ((bonex.Direction.AngleTo(boney.Direction) / Math.PI) * 180) * 2;

                        thumbangle = (int)(180 - angle2);

                        data.leap_finger_thumb = thumbangle;
                        if (!finger.IsExtended)
                        {
                            thumbangle = 165;
                            data.leap_finger_thumb = 165;
                        }

                        fingert.Invoke((MethodInvoker)(() => fingert.Text = "Thumb: " + thumbangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_MIDDLE)
                    {

                        middleangle = getNewAngle(middleangle, calcAngle);
                        data.leap_finger_middle = middleangle;

                        fingerm.Invoke((MethodInvoker)(() => fingerm.Text = "Middle: " + middleangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_RING)
                    {

                        ringangle = getNewAngle(ringangle, calcAngle);
                        data.leap_finger_ring = ringangle;
                        fingerr.Invoke((MethodInvoker)(() => fingerr.Text = "Ring: " + ringangle.ToString()));
                    }

                    else if (finger.Type == Finger.FingerType.TYPE_PINKY)
                    {
                        pinkyangle = getNewAngle(pinkyangle, calcAngle);
                        data.leap_finger_pinky = pinkyangle;
                        fingerp.Invoke((MethodInvoker)(() => fingerp.Text = "Pinky: " + pinkyangle.ToString()));
                    }

                    if (finger.IsExtended)
                    {
                        label_hand_fingertype.Invoke((MethodInvoker)(() => label_hand_fingertype.Text = "Finger: " + finger.Type.ToString()));


                    }
                }
            }


        }
        
        #endregion


        #region Check Button Status

        private void button_connect_Click(object sender, EventArgs e)    //Connect to IP adress
        {

            string ipadress = textBox_ipAdress.Text;
            clientSocket = new TcpClient(ipadress, 8001);
            networkStream = clientSocket.GetStream();
            listBox_logger.Items.Add(DateTime.Now + " " + textBox_ipAdress.Text + " adresine bağlanılıyor");

        }

        private void button_disconnect_Click(object sender, EventArgs e)    //Disconnect from IP adress
        {

            if(networkStream != null)
            {
                networkStream.Close();
                networkStream = null;
            }
            else
            {
                MessageBox.Show("Not connected");
            }
        }

        private void button_comp_settings_Click(object sender, EventArgs e)
        {
            com_setting com_page = new com_setting();
            com_page.Show();
        }

        private void tESTARAYUZUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tele_test test_interface = new tele_test();
            test_interface.Show();
        }

        private void fEEDBACKToolStripMenuItem_Click(object sender, EventArgs e) // Open hand status
        {
            hand_datas hand_page = new hand_datas();
            hand_page.Show();
        }

        private void button_get_coordinates_Click(object sender, EventArgs e) // Get coordinates of the square
        {
            listBox_logger.Items.Add(DateTime.Now + "Anlık Koordinatlar: ");
            for (int i = 0; i < 4; i++)
            {
                String sendmessage = "X: " + currentContour[i].X.ToString() + "," + "Y: " + currentContour[i].Y.ToString();
                listBox_logger.Items.Add(sendmessage);
                sendmessage = "";
            }
        }

        private void button_clear_thres_Click(object sender, EventArgs e) // Clear trackbar values
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;
        } 

        private void button_configuration_Click(object sender, EventArgs e) // Open config menu
        {
            if (leap_frame != null) //Config menüsü için
            {
                config page = new config();
                page.Show();
            }
        }

        private void buttonbutton_save_img_Click(object sender, EventArgs e) //Save Image
        {
            try
            {
                if(cameraBox.Image != null)
                {
                    Bitmap img = new Bitmap(cameraBox.Image.Bitmap);
                    img.Save(@"C:\Users\Musa\Documents\Visual Studio 2013\Projects\projedenemeleri1\projedenemeleri1\fotolar\asd.jpeg", ImageFormat.Jpeg);
                    addListbox("Resim Kaydedildi");

                }
                else
                {
                    MessageBox.Show("Görüntü Yok","Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());


            }
            
        }

        #endregion

  
        #region Image Processing

        public void findsquare(Image<Bgr, Byte> img) //Find squares from image
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
                                    ellipse = new Ellipse(new PointF(currentContour[0].X, currentContour[0].Y), new SizeF(10, 10), 1);

                                    Console.WriteLine(currentContour[1]);
                                }
                            }
                        }
                    }
                }



            Image<Bgr, Byte> triangleRectangleImage = img.Copy();
            foreach (Triangle2DF triangle in triangleList)
                triangleRectangleImage.Draw(triangle, new Bgr(Color.DarkBlue), 2);

            foreach (MCvBox2D box in boxList)
                triangleRectangleImage.Draw(box, new Bgr(Color.DarkOrange), 2);

            triangleRectangleImage.Draw(ellipse, new Bgr(Color.DarkBlue), 3);
            //MCvFont f= new MCvFont() 
            //triangleRectangleImage.Draw(currentContour[0].X.ToString()+ " " +currentContour[0].Y.ToString(),MCvFont)
            cameraBox.Image = triangleRectangleImage;
        }

        private void ProduceThresholdImage() //Get trackbars value
        {

            HueLow = trackBar1.Value;
            SatLow = trackBar2.Value;
            ValLow = trackBar3.Value;
            HueHigh = trackBar4.Value;
            SatHigh = trackBar5.Value;
            ValHigh = trackBar6.Value;

        }

        private void radioCheckedImageChange() //Changing image colors or thres
        {
            if (radioButton_cam_now.Checked)
            {
                Image<Bgr, byte> depthImage = new Image<Emgu.CV.Structure.Bgr, byte>(320, 240);
                depthImage.Bytes = netdata;
                cameraBox.Image = depthImage;

            }

            else if (radioButton_cam_hsv.Checked)
            {
                Image<Hsv, byte> depthImage = new Image<Emgu.CV.Structure.Hsv, byte>(320, 240);
                depthImage.Bytes = netdata;
                cameraBox.Image = depthImage;
            }

            else if (radioButton_cam_thres.Checked)
            {
                Image<Hsv, byte> depthImage = new Image<Emgu.CV.Structure.Hsv, byte>(320, 240);
                if (netdata != null)
                {
                    depthImage.Bytes = netdata;

                    m_imgThreshold = depthImage.InRange(new Hsv(HueLow, SatLow, ValLow), new Hsv(HueHigh, SatHigh, ValHigh));
                    cameraBox.Image = m_imgThreshold;
                }

            }

            else if (radioButton_cam_rgb.Checked)
            {
                Image<Rgb, byte> depthImage = new Image<Emgu.CV.Structure.Rgb, byte>(320, 240);
                depthImage.Bytes = netdata;
                cameraBox.Image = depthImage;
            }
            else if (radioButton_cam_follow.Checked)
            {
                Image<Bgr, byte> depthImage = new Image<Emgu.CV.Structure.Bgr, byte>(320, 240);
                depthImage.Bytes = netdata;

                findsquare(depthImage);
            }
        }

        #region TrackBar_Value_Changes


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

        #endregion

        #endregion


        #region Open_Forms

        private void sICAKLIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sensors sensoropen = new sensors(); //Sensör sayfasını açıyor
            sensoropen.Show();

        }
        
        #endregion

    }
}
