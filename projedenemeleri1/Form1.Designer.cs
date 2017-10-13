namespace projedenemeleri1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cameraView = new Emgu.CV.UI.ImageBox();
            this.label_sicaklik = new System.Windows.Forms.Label();
            this.label_basinc = new System.Windows.Forms.Label();
            this.label_isik = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.groupBox_sensor_values = new System.Windows.Forms.GroupBox();
            this.label_hand_x = new System.Windows.Forms.Label();
            this.label_hand_y = new System.Windows.Forms.Label();
            this.label_hand_grab = new System.Windows.Forms.Label();
            this.label_hand_z = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.fingerr = new System.Windows.Forms.Label();
            this.fingerm = new System.Windows.Forms.Label();
            this.fingeri = new System.Windows.Forms.Label();
            this.fingert = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_ipAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_tcpsettings = new System.Windows.Forms.GroupBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.fingerp = new System.Windows.Forms.Label();
            this.label_hand_fingertype = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sICAKLIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sENSÖRDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fEEDBACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTARAYUZUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_configuration = new System.Windows.Forms.Button();
            this.progressBar_thumb = new System.Windows.Forms.ProgressBar();
            this.progressBar_index = new System.Windows.Forms.ProgressBar();
            this.progressBar_ring = new System.Windows.Forms.ProgressBar();
            this.progressBar_middle = new System.Windows.Forms.ProgressBar();
            this.progressBar_pinky = new System.Windows.Forms.ProgressBar();
            this.groupBox_finger_pressure = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_get_coordinate = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label_trackbar6 = new System.Windows.Forms.Label();
            this.label_trackbar5 = new System.Windows.Forms.Label();
            this.radioButton_cam_follow = new System.Windows.Forms.RadioButton();
            this.radioButton_cam_rgb = new System.Windows.Forms.RadioButton();
            this.label_trackbar4 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label_trackbar3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label_trackbar2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton_cam_thres = new System.Windows.Forms.RadioButton();
            this.label_trackbar1 = new System.Windows.Forms.Label();
            this.radioButton_cam_hsv = new System.Windows.Forms.RadioButton();
            this.radioButton_cam_now = new System.Windows.Forms.RadioButton();
            this.label_baglanti_l = new System.Windows.Forms.Label();
            this.label_baglanti_d = new System.Windows.Forms.Label();
            this.button_save_img = new System.Windows.Forms.Button();
            this.button_clear_thres = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_comp_settings = new System.Windows.Forms.Button();
            this.listBox_logger = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chart_sensor_graphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).BeginInit();
            this.groupBox_sensor_values.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_tcpsettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox_finger_pressure.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sensor_graphics)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraView
            // 
            this.cameraView.Location = new System.Drawing.Point(6, 19);
            this.cameraView.Name = "cameraView";
            this.cameraView.Size = new System.Drawing.Size(452, 281);
            this.cameraView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraView.TabIndex = 2;
            this.cameraView.TabStop = false;
            // 
            // label_sicaklik
            // 
            this.label_sicaklik.AutoSize = true;
            this.label_sicaklik.Location = new System.Drawing.Point(6, 22);
            this.label_sicaklik.Name = "label_sicaklik";
            this.label_sicaklik.Size = new System.Drawing.Size(73, 13);
            this.label_sicaklik.TabIndex = 5;
            this.label_sicaklik.Text = "Temperature: ";
            // 
            // label_basinc
            // 
            this.label_basinc.AutoSize = true;
            this.label_basinc.Location = new System.Drawing.Point(6, 44);
            this.label_basinc.Name = "label_basinc";
            this.label_basinc.Size = new System.Drawing.Size(54, 13);
            this.label_basinc.TabIndex = 6;
            this.label_basinc.Text = "Pressure: ";
            // 
            // label_isik
            // 
            this.label_isik.AutoSize = true;
            this.label_isik.Location = new System.Drawing.Point(6, 88);
            this.label_isik.Name = "label_isik";
            this.label_isik.Size = new System.Drawing.Size(45, 13);
            this.label_isik.TabIndex = 8;
            this.label_isik.Text = "Light In:";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Location = new System.Drawing.Point(6, 66);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(53, 13);
            this.label_nem.TabIndex = 7;
            this.label_nem.Text = "Humidity :";
            // 
            // groupBox_sensor_values
            // 
            this.groupBox_sensor_values.Controls.Add(this.label_nem);
            this.groupBox_sensor_values.Controls.Add(this.label_isik);
            this.groupBox_sensor_values.Controls.Add(this.label_sicaklik);
            this.groupBox_sensor_values.Controls.Add(this.label_basinc);
            this.groupBox_sensor_values.Location = new System.Drawing.Point(488, 172);
            this.groupBox_sensor_values.Name = "groupBox_sensor_values";
            this.groupBox_sensor_values.Size = new System.Drawing.Size(163, 115);
            this.groupBox_sensor_values.TabIndex = 9;
            this.groupBox_sensor_values.TabStop = false;
            this.groupBox_sensor_values.Text = "Sensor Values";
            // 
            // label_hand_x
            // 
            this.label_hand_x.AutoSize = true;
            this.label_hand_x.Location = new System.Drawing.Point(12, 18);
            this.label_hand_x.Name = "label_hand_x";
            this.label_hand_x.Size = new System.Drawing.Size(20, 13);
            this.label_hand_x.TabIndex = 10;
            this.label_hand_x.Text = "X :";
            // 
            // label_hand_y
            // 
            this.label_hand_y.AutoSize = true;
            this.label_hand_y.Location = new System.Drawing.Point(12, 40);
            this.label_hand_y.Name = "label_hand_y";
            this.label_hand_y.Size = new System.Drawing.Size(17, 13);
            this.label_hand_y.TabIndex = 14;
            this.label_hand_y.Text = "Y:";
            // 
            // label_hand_grab
            // 
            this.label_hand_grab.AutoSize = true;
            this.label_hand_grab.Location = new System.Drawing.Point(12, 84);
            this.label_hand_grab.Name = "label_hand_grab";
            this.label_hand_grab.Size = new System.Drawing.Size(55, 13);
            this.label_hand_grab.TabIndex = 16;
            this.label_hand_grab.Text = "Kavrama: ";
            // 
            // label_hand_z
            // 
            this.label_hand_z.AutoSize = true;
            this.label_hand_z.Location = new System.Drawing.Point(12, 62);
            this.label_hand_z.Name = "label_hand_z";
            this.label_hand_z.Size = new System.Drawing.Size(17, 13);
            this.label_hand_z.TabIndex = 15;
            this.label_hand_z.Text = "Z:";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(11, 71);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(61, 23);
            this.button_connect.TabIndex = 21;
            this.button_connect.Text = "Start";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // fingerr
            // 
            this.fingerr.AutoSize = true;
            this.fingerr.Location = new System.Drawing.Point(12, 82);
            this.fingerr.Name = "fingerr";
            this.fingerr.Size = new System.Drawing.Size(32, 13);
            this.fingerr.TabIndex = 25;
            this.fingerr.Text = "Ring:";
            // 
            // fingerm
            // 
            this.fingerm.AutoSize = true;
            this.fingerm.Location = new System.Drawing.Point(12, 62);
            this.fingerm.Name = "fingerm";
            this.fingerm.Size = new System.Drawing.Size(41, 13);
            this.fingerm.TabIndex = 24;
            this.fingerm.Text = "Middle:";
            // 
            // fingeri
            // 
            this.fingeri.AutoSize = true;
            this.fingeri.Location = new System.Drawing.Point(12, 42);
            this.fingeri.Name = "fingeri";
            this.fingeri.Size = new System.Drawing.Size(36, 13);
            this.fingeri.TabIndex = 23;
            this.fingeri.Text = "Index:";
            // 
            // fingert
            // 
            this.fingert.AutoSize = true;
            this.fingert.Location = new System.Drawing.Point(12, 22);
            this.fingert.Name = "fingert";
            this.fingert.Size = new System.Drawing.Size(43, 13);
            this.fingert.TabIndex = 22;
            this.fingert.Text = "Thumb:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cameraBox);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cameraView);
            this.groupBox2.Location = new System.Drawing.Point(9, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 325);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAMERA";
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(6, 18);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(452, 288);
            this.cameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 282);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_ipAdress
            // 
            this.textBox_ipAdress.Location = new System.Drawing.Point(11, 44);
            this.textBox_ipAdress.Name = "textBox_ipAdress";
            this.textBox_ipAdress.Size = new System.Drawing.Size(138, 20);
            this.textBox_ipAdress.TabIndex = 27;
            this.textBox_ipAdress.Text = "192.168.1.10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "IP ADRESS";
            // 
            // groupBox_tcpsettings
            // 
            this.groupBox_tcpsettings.Controls.Add(this.button_disconnect);
            this.groupBox_tcpsettings.Controls.Add(this.label5);
            this.groupBox_tcpsettings.Controls.Add(this.button_connect);
            this.groupBox_tcpsettings.Controls.Add(this.textBox_ipAdress);
            this.groupBox_tcpsettings.Location = new System.Drawing.Point(488, 37);
            this.groupBox_tcpsettings.Name = "groupBox_tcpsettings";
            this.groupBox_tcpsettings.Size = new System.Drawing.Size(163, 100);
            this.groupBox_tcpsettings.TabIndex = 29;
            this.groupBox_tcpsettings.TabStop = false;
            this.groupBox_tcpsettings.Text = "TCP Settings";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(88, 71);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(61, 23);
            this.button_disconnect.TabIndex = 29;
            this.button_disconnect.Text = "Stop";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // fingerp
            // 
            this.fingerp.AutoSize = true;
            this.fingerp.Location = new System.Drawing.Point(12, 102);
            this.fingerp.Name = "fingerp";
            this.fingerp.Size = new System.Drawing.Size(39, 13);
            this.fingerp.TabIndex = 35;
            this.fingerp.Text = "Pinky: ";
            // 
            // label_hand_fingertype
            // 
            this.label_hand_fingertype.AutoSize = true;
            this.label_hand_fingertype.Location = new System.Drawing.Point(12, 106);
            this.label_hand_fingertype.Name = "label_hand_fingertype";
            this.label_hand_fingertype.Size = new System.Drawing.Size(49, 13);
            this.label_hand_fingertype.TabIndex = 36;
            this.label_hand_fingertype.Text = "Parmak: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_hand_x);
            this.groupBox4.Controls.Add(this.label_hand_fingertype);
            this.groupBox4.Controls.Add(this.label_hand_y);
            this.groupBox4.Controls.Add(this.label_hand_z);
            this.groupBox4.Controls.Add(this.label_hand_grab);
            this.groupBox4.Location = new System.Drawing.Point(663, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 127);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "El Değerleri";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.fingert);
            this.groupBox5.Controls.Add(this.fingeri);
            this.groupBox5.Controls.Add(this.fingerp);
            this.groupBox5.Controls.Add(this.fingerm);
            this.groupBox5.Controls.Add(this.fingerr);
            this.groupBox5.Location = new System.Drawing.Point(663, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 132);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parmak Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Index:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sICAKLIKToolStripMenuItem,
            this.sENSÖRDATAToolStripMenuItem,
            this.fEEDBACKToolStripMenuItem,
            this.tESTARAYUZUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sICAKLIKToolStripMenuItem
            // 
            this.sICAKLIKToolStripMenuItem.Name = "sICAKLIKToolStripMenuItem";
            this.sICAKLIKToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.sICAKLIKToolStripMenuItem.Text = "SENSÖR GRAFİK";
            this.sICAKLIKToolStripMenuItem.Click += new System.EventHandler(this.sICAKLIKToolStripMenuItem_Click);
            // 
            // sENSÖRDATAToolStripMenuItem
            // 
            this.sENSÖRDATAToolStripMenuItem.Name = "sENSÖRDATAToolStripMenuItem";
            this.sENSÖRDATAToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.sENSÖRDATAToolStripMenuItem.Text = "SENSÖR DATA";
            // 
            // fEEDBACKToolStripMenuItem
            // 
            this.fEEDBACKToolStripMenuItem.Name = "fEEDBACKToolStripMenuItem";
            this.fEEDBACKToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fEEDBACKToolStripMenuItem.Text = "EL BİLGİLERİ";
            // 
            // tESTARAYUZUToolStripMenuItem
            // 
            this.tESTARAYUZUToolStripMenuItem.Name = "tESTARAYUZUToolStripMenuItem";
            this.tESTARAYUZUToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.tESTARAYUZUToolStripMenuItem.Text = "TEST ARAYUZU";
            this.tESTARAYUZUToolStripMenuItem.Click += new System.EventHandler(this.tESTARAYUZUToolStripMenuItem_Click);
            // 
            // button_configuration
            // 
            this.button_configuration.Location = new System.Drawing.Point(488, 143);
            this.button_configuration.Name = "button_configuration";
            this.button_configuration.Size = new System.Drawing.Size(163, 23);
            this.button_configuration.TabIndex = 42;
            this.button_configuration.Text = "Configuration";
            this.button_configuration.UseVisualStyleBackColor = true;
            this.button_configuration.Click += new System.EventHandler(this.button_configuration_Click);
            // 
            // progressBar_thumb
            // 
            this.progressBar_thumb.Location = new System.Drawing.Point(56, 22);
            this.progressBar_thumb.Name = "progressBar_thumb";
            this.progressBar_thumb.Size = new System.Drawing.Size(129, 23);
            this.progressBar_thumb.TabIndex = 43;
            // 
            // progressBar_index
            // 
            this.progressBar_index.Location = new System.Drawing.Point(56, 51);
            this.progressBar_index.Name = "progressBar_index";
            this.progressBar_index.Size = new System.Drawing.Size(129, 23);
            this.progressBar_index.TabIndex = 44;
            // 
            // progressBar_ring
            // 
            this.progressBar_ring.Location = new System.Drawing.Point(56, 109);
            this.progressBar_ring.Name = "progressBar_ring";
            this.progressBar_ring.Size = new System.Drawing.Size(129, 23);
            this.progressBar_ring.TabIndex = 46;
            // 
            // progressBar_middle
            // 
            this.progressBar_middle.Location = new System.Drawing.Point(56, 80);
            this.progressBar_middle.Name = "progressBar_middle";
            this.progressBar_middle.Size = new System.Drawing.Size(129, 23);
            this.progressBar_middle.TabIndex = 45;
            // 
            // progressBar_pinky
            // 
            this.progressBar_pinky.Location = new System.Drawing.Point(56, 138);
            this.progressBar_pinky.Name = "progressBar_pinky";
            this.progressBar_pinky.Size = new System.Drawing.Size(129, 23);
            this.progressBar_pinky.TabIndex = 47;
            // 
            // groupBox_finger_pressure
            // 
            this.groupBox_finger_pressure.Controls.Add(this.label6);
            this.groupBox_finger_pressure.Controls.Add(this.label7);
            this.groupBox_finger_pressure.Controls.Add(this.progressBar_middle);
            this.groupBox_finger_pressure.Controls.Add(this.label8);
            this.groupBox_finger_pressure.Controls.Add(this.progressBar_pinky);
            this.groupBox_finger_pressure.Controls.Add(this.label9);
            this.groupBox_finger_pressure.Controls.Add(this.progressBar_thumb);
            this.groupBox_finger_pressure.Controls.Add(this.label10);
            this.groupBox_finger_pressure.Controls.Add(this.progressBar_ring);
            this.groupBox_finger_pressure.Controls.Add(this.progressBar_index);
            this.groupBox_finger_pressure.Location = new System.Drawing.Point(663, 308);
            this.groupBox_finger_pressure.Name = "groupBox_finger_pressure";
            this.groupBox_finger_pressure.Size = new System.Drawing.Size(200, 179);
            this.groupBox_finger_pressure.TabIndex = 48;
            this.groupBox_finger_pressure.TabStop = false;
            this.groupBox_finger_pressure.Text = "Parmak Basınçları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thumb:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Index:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Pinky: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Middle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Ring:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.button_get_coordinate);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.trackBar6);
            this.groupBox7.Controls.Add(this.trackBar5);
            this.groupBox7.Controls.Add(this.trackBar4);
            this.groupBox7.Controls.Add(this.label_trackbar6);
            this.groupBox7.Controls.Add(this.label_trackbar5);
            this.groupBox7.Controls.Add(this.radioButton_cam_follow);
            this.groupBox7.Controls.Add(this.radioButton_cam_rgb);
            this.groupBox7.Controls.Add(this.label_trackbar4);
            this.groupBox7.Controls.Add(this.trackBar3);
            this.groupBox7.Controls.Add(this.label_trackbar3);
            this.groupBox7.Controls.Add(this.trackBar2);
            this.groupBox7.Controls.Add(this.label_trackbar2);
            this.groupBox7.Controls.Add(this.trackBar1);
            this.groupBox7.Controls.Add(this.radioButton_cam_thres);
            this.groupBox7.Controls.Add(this.label_trackbar1);
            this.groupBox7.Controls.Add(this.radioButton_cam_hsv);
            this.groupBox7.Controls.Add(this.radioButton_cam_now);
            this.groupBox7.Location = new System.Drawing.Point(12, 368);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(470, 207);
            this.groupBox7.TabIndex = 49;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kamera";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "5";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_get_coordinate
            // 
            this.button_get_coordinate.Location = new System.Drawing.Point(17, 178);
            this.button_get_coordinate.Name = "button_get_coordinate";
            this.button_get_coordinate.Size = new System.Drawing.Size(96, 23);
            this.button_get_coordinate.TabIndex = 19;
            this.button_get_coordinate.Text = "Koordinat";
            this.button_get_coordinate.UseVisualStyleBackColor = true;
            this.button_get_coordinate.Click += new System.EventHandler(this.button_get_coordinates_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(17, 149);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Takip";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(17, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Sabitle";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(150, 147);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(279, 45);
            this.trackBar6.TabIndex = 14;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(150, 120);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(279, 45);
            this.trackBar5.TabIndex = 13;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(150, 94);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(279, 45);
            this.trackBar4.TabIndex = 5;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label_trackbar6
            // 
            this.label_trackbar6.AutoSize = true;
            this.label_trackbar6.Location = new System.Drawing.Point(432, 150);
            this.label_trackbar6.Name = "label_trackbar6";
            this.label_trackbar6.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar6.TabIndex = 16;
            this.label_trackbar6.Text = "0";
            // 
            // label_trackbar5
            // 
            this.label_trackbar5.AutoSize = true;
            this.label_trackbar5.Location = new System.Drawing.Point(432, 122);
            this.label_trackbar5.Name = "label_trackbar5";
            this.label_trackbar5.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar5.TabIndex = 15;
            this.label_trackbar5.Text = "0";
            // 
            // radioButton_cam_follow
            // 
            this.radioButton_cam_follow.AutoSize = true;
            this.radioButton_cam_follow.Location = new System.Drawing.Point(20, 98);
            this.radioButton_cam_follow.Name = "radioButton_cam_follow";
            this.radioButton_cam_follow.Size = new System.Drawing.Size(52, 17);
            this.radioButton_cam_follow.TabIndex = 12;
            this.radioButton_cam_follow.TabStop = true;
            this.radioButton_cam_follow.Text = "Takip";
            this.radioButton_cam_follow.UseVisualStyleBackColor = true;
            // 
            // radioButton_cam_rgb
            // 
            this.radioButton_cam_rgb.AutoSize = true;
            this.radioButton_cam_rgb.Location = new System.Drawing.Point(20, 79);
            this.radioButton_cam_rgb.Name = "radioButton_cam_rgb";
            this.radioButton_cam_rgb.Size = new System.Drawing.Size(48, 17);
            this.radioButton_cam_rgb.TabIndex = 11;
            this.radioButton_cam_rgb.TabStop = true;
            this.radioButton_cam_rgb.Text = "RGB";
            this.radioButton_cam_rgb.UseVisualStyleBackColor = true;
            // 
            // label_trackbar4
            // 
            this.label_trackbar4.AutoSize = true;
            this.label_trackbar4.Location = new System.Drawing.Point(432, 97);
            this.label_trackbar4.Name = "label_trackbar4";
            this.label_trackbar4.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar4.TabIndex = 10;
            this.label_trackbar4.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(150, 70);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(279, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label_trackbar3
            // 
            this.label_trackbar3.AutoSize = true;
            this.label_trackbar3.Location = new System.Drawing.Point(432, 72);
            this.label_trackbar3.Name = "label_trackbar3";
            this.label_trackbar3.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar3.TabIndex = 9;
            this.label_trackbar3.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(150, 43);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(279, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label_trackbar2
            // 
            this.label_trackbar2.AutoSize = true;
            this.label_trackbar2.Location = new System.Drawing.Point(432, 47);
            this.label_trackbar2.Name = "label_trackbar2";
            this.label_trackbar2.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar2.TabIndex = 8;
            this.label_trackbar2.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(150, 15);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(279, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButton_cam_thres
            // 
            this.radioButton_cam_thres.AutoSize = true;
            this.radioButton_cam_thres.Location = new System.Drawing.Point(20, 61);
            this.radioButton_cam_thres.Name = "radioButton_cam_thres";
            this.radioButton_cam_thres.Size = new System.Drawing.Size(72, 17);
            this.radioButton_cam_thres.TabIndex = 2;
            this.radioButton_cam_thres.TabStop = true;
            this.radioButton_cam_thres.Text = "Threshold";
            this.radioButton_cam_thres.UseVisualStyleBackColor = true;
            // 
            // label_trackbar1
            // 
            this.label_trackbar1.AutoSize = true;
            this.label_trackbar1.Location = new System.Drawing.Point(432, 19);
            this.label_trackbar1.Name = "label_trackbar1";
            this.label_trackbar1.Size = new System.Drawing.Size(13, 13);
            this.label_trackbar1.TabIndex = 7;
            this.label_trackbar1.Text = "0";
            // 
            // radioButton_cam_hsv
            // 
            this.radioButton_cam_hsv.AutoSize = true;
            this.radioButton_cam_hsv.Location = new System.Drawing.Point(20, 43);
            this.radioButton_cam_hsv.Name = "radioButton_cam_hsv";
            this.radioButton_cam_hsv.Size = new System.Drawing.Size(47, 17);
            this.radioButton_cam_hsv.TabIndex = 1;
            this.radioButton_cam_hsv.TabStop = true;
            this.radioButton_cam_hsv.Text = "HSV";
            this.radioButton_cam_hsv.UseVisualStyleBackColor = true;
            // 
            // radioButton_cam_now
            // 
            this.radioButton_cam_now.AutoSize = true;
            this.radioButton_cam_now.Checked = true;
            this.radioButton_cam_now.Location = new System.Drawing.Point(20, 25);
            this.radioButton_cam_now.Name = "radioButton_cam_now";
            this.radioButton_cam_now.Size = new System.Drawing.Size(48, 17);
            this.radioButton_cam_now.TabIndex = 0;
            this.radioButton_cam_now.TabStop = true;
            this.radioButton_cam_now.Text = "Anlık";
            this.radioButton_cam_now.UseVisualStyleBackColor = true;
            // 
            // label_baglanti_l
            // 
            this.label_baglanti_l.AutoSize = true;
            this.label_baglanti_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baglanti_l.Location = new System.Drawing.Point(21, 17);
            this.label_baglanti_l.Name = "label_baglanti_l";
            this.label_baglanti_l.Size = new System.Drawing.Size(125, 16);
            this.label_baglanti_l.TabIndex = 50;
            this.label_baglanti_l.Text = "Bağlantı Durumu:";
            // 
            // label_baglanti_d
            // 
            this.label_baglanti_d.AutoSize = true;
            this.label_baglanti_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baglanti_d.ForeColor = System.Drawing.Color.Red;
            this.label_baglanti_d.Location = new System.Drawing.Point(49, 39);
            this.label_baglanti_d.Name = "label_baglanti_d";
            this.label_baglanti_d.Size = new System.Drawing.Size(66, 20);
            this.label_baglanti_d.TabIndex = 51;
            this.label_baglanti_d.Text = "Meşgul";
            // 
            // button_save_img
            // 
            this.button_save_img.Location = new System.Drawing.Point(488, 376);
            this.button_save_img.Name = "button_save_img";
            this.button_save_img.Size = new System.Drawing.Size(163, 23);
            this.button_save_img.TabIndex = 52;
            this.button_save_img.Text = "Resim Kaydet";
            this.button_save_img.UseVisualStyleBackColor = true;
            this.button_save_img.Click += new System.EventHandler(this.buttonbutton_save_img_Click);
            // 
            // button_clear_thres
            // 
            this.button_clear_thres.Location = new System.Drawing.Point(488, 434);
            this.button_clear_thres.Name = "button_clear_thres";
            this.button_clear_thres.Size = new System.Drawing.Size(163, 23);
            this.button_clear_thres.TabIndex = 54;
            this.button_clear_thres.Text = "Ayarları Sıfırla";
            this.button_clear_thres.UseVisualStyleBackColor = true;
            this.button_clear_thres.Click += new System.EventHandler(this.button_clear_thres_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Video Kayıt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button_comp_settings
            // 
            this.button_comp_settings.Location = new System.Drawing.Point(488, 463);
            this.button_comp_settings.Name = "button_comp_settings";
            this.button_comp_settings.Size = new System.Drawing.Size(163, 23);
            this.button_comp_settings.TabIndex = 55;
            this.button_comp_settings.Text = "Gelişmiş Ayarlar";
            this.button_comp_settings.UseVisualStyleBackColor = true;
            this.button_comp_settings.Click += new System.EventHandler(this.button_comp_settings_Click);
            // 
            // listBox_logger
            // 
            this.listBox_logger.AllowDrop = true;
            this.listBox_logger.FormattingEnabled = true;
            this.listBox_logger.Location = new System.Drawing.Point(488, 492);
            this.listBox_logger.Name = "listBox_logger";
            this.listBox_logger.Size = new System.Drawing.Size(375, 82);
            this.listBox_logger.TabIndex = 56;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label_baglanti_l);
            this.groupBox8.Controls.Add(this.label_baglanti_d);
            this.groupBox8.Location = new System.Drawing.Point(488, 293);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 77);
            this.groupBox8.TabIndex = 57;
            this.groupBox8.TabStop = false;
            // 
            // chart_sensor_graphics
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_sensor_graphics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_sensor_graphics.Legends.Add(legend1);
            this.chart_sensor_graphics.Location = new System.Drawing.Point(12, 581);
            this.chart_sensor_graphics.Name = "chart_sensor_graphics";
            this.chart_sensor_graphics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.MarkerImageTransparentColor = System.Drawing.Color.White;
            series1.Name = "Sıcaklık";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Nem";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Basınç";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Işık";
            this.chart_sensor_graphics.Series.Add(series1);
            this.chart_sensor_graphics.Series.Add(series2);
            this.chart_sensor_graphics.Series.Add(series3);
            this.chart_sensor_graphics.Series.Add(series4);
            this.chart_sensor_graphics.Size = new System.Drawing.Size(851, 101);
            this.chart_sensor_graphics.TabIndex = 58;
            this.chart_sensor_graphics.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 696);
            this.Controls.Add(this.chart_sensor_graphics);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.listBox_logger);
            this.Controls.Add(this.button_comp_settings);
            this.Controls.Add(this.button_clear_thres);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_save_img);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox_finger_pressure);
            this.Controls.Add(this.button_configuration);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox_tcpsettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_sensor_values);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Teletouch  GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraView)).EndInit();
            this.groupBox_sensor_values.ResumeLayout(false);
            this.groupBox_sensor_values.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_tcpsettings.ResumeLayout(false);
            this.groupBox_tcpsettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_finger_pressure.ResumeLayout(false);
            this.groupBox_finger_pressure.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sensor_graphics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraView;
        private System.Windows.Forms.Label label_sicaklik;
        private System.Windows.Forms.Label label_basinc;
        private System.Windows.Forms.Label label_isik;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.GroupBox groupBox_sensor_values;
        private System.Windows.Forms.Label label_hand_x;
        private System.Windows.Forms.Label label_hand_y;
        private System.Windows.Forms.Label label_hand_grab;
        private System.Windows.Forms.Label label_hand_z;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label fingerr;
        private System.Windows.Forms.Label fingerm;
        private System.Windows.Forms.Label fingeri;
        private System.Windows.Forms.Label fingert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ipAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_tcpsettings;
        private System.Windows.Forms.Label fingerp;
        private System.Windows.Forms.Label label_hand_fingertype;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sICAKLIKToolStripMenuItem;
        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button button_configuration;
        private System.Windows.Forms.ProgressBar progressBar_thumb;
        private System.Windows.Forms.ProgressBar progressBar_index;
        private System.Windows.Forms.ProgressBar progressBar_ring;
        private System.Windows.Forms.ProgressBar progressBar_middle;
        private System.Windows.Forms.ProgressBar progressBar_pinky;
        private System.Windows.Forms.GroupBox groupBox_finger_pressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radioButton_cam_thres;
        private System.Windows.Forms.RadioButton radioButton_cam_hsv;
        private System.Windows.Forms.RadioButton radioButton_cam_now;
        private System.Windows.Forms.Label label_baglanti_l;
        private System.Windows.Forms.Label label_baglanti_d;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Button button_save_img;
        private System.Windows.Forms.Button button_clear_thres;
        private System.Windows.Forms.Label label_trackbar4;
        private System.Windows.Forms.Label label_trackbar3;
        private System.Windows.Forms.Label label_trackbar2;
        private System.Windows.Forms.Label label_trackbar1;
        private System.Windows.Forms.ToolStripMenuItem sENSÖRDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fEEDBACKToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_cam_follow;
        private System.Windows.Forms.RadioButton radioButton_cam_rgb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label_trackbar6;
        private System.Windows.Forms.Label label_trackbar5;
        private System.Windows.Forms.Button button_comp_settings;
        private System.Windows.Forms.ListBox listBox_logger;
        private System.Windows.Forms.Button button_get_coordinate;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sensor_graphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem tESTARAYUZUToolStripMenuItem;
    }
}

