﻿namespace projedenemeleri1
{
    partial class sensors
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sensors));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_paket_y = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_paket_g = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button_datapms = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_clean_charts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Title = "Örnekleme Adedi";
            chartArea1.AxisY.Title = "Sıcaklık";
            chartArea1.Name = "Alan";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend1.Name = "Gosterge";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Alan";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Gosterge";
            series1.Name = "Sıcaklık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(372, 215);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 249);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıcaklık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fahrenheit ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celcius";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 249);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basınç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pa";
            // 
            // chart2
            // 
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisX.Title = "Örnekleme Adedi";
            chartArea2.AxisY.Title = "Basınç";
            chartArea2.Name = "Alan";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend2.Name = "Gosterge";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(17, 19);
            this.chart2.Name = "chart2";
            series2.ChartArea = "Alan";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Gosterge";
            series2.Name = "Basınç";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(372, 215);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chart3);
            this.groupBox3.Location = new System.Drawing.Point(520, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 249);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gram/m3";
            // 
            // chart3
            // 
            chartArea3.AxisX.MaximumAutoSize = 100F;
            chartArea3.AxisX.Title = "Örnekleme Adedi";
            chartArea3.AxisY.Title = "Nem";
            chartArea3.Name = "Alan";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend3.Name = "Gosterge";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(17, 19);
            this.chart3.Name = "chart3";
            series3.ChartArea = "Alan";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Gosterge";
            series3.Name = "Nem";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(372, 215);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.chart4);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(520, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 249);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Işık Şiddeti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            // 
            // chart4
            // 
            chartArea4.AxisX.MaximumAutoSize = 100F;
            chartArea4.AxisX.Title = "Örnekleme Adedi";
            chartArea4.AxisY.Title = "Işık Şiddeti";
            chartArea4.Name = "Alan";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend4.Name = "Gosterge";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(17, 19);
            this.chart4.Name = "chart4";
            series4.ChartArea = "Alan";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Gosterge";
            series4.Name = "Işık Şiddeti";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(372, 215);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Şiddet(10)";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(12, 515);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(172, 23);
            this.button_stop.TabIndex = 10;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(12, 544);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(172, 23);
            this.button_excel.TabIndex = 11;
            this.button_excel.Text = "Export Excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_paket_y,
            this.toolStripStatusLabel_paket_g,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_paket_y
            // 
            this.toolStripStatusLabel_paket_y.Name = "toolStripStatusLabel_paket_y";
            this.toolStripStatusLabel_paket_y.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel_paket_y.Text = "Packet Received: ";
            // 
            // toolStripStatusLabel_paket_g
            // 
            this.toolStripStatusLabel_paket_g.AutoSize = false;
            this.toolStripStatusLabel_paket_g.Name = "toolStripStatusLabel_paket_g";
            this.toolStripStatusLabel_paket_g.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel_paket_g.Text = "0                              ";
            this.toolStripStatusLabel_paket_g.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // button_datapms
            // 
            this.button_datapms.Location = new System.Drawing.Point(232, 515);
            this.button_datapms.Name = "button_datapms";
            this.button_datapms.Size = new System.Drawing.Size(172, 23);
            this.button_datapms.TabIndex = 13;
            this.button_datapms.Text = "Set As Per/MSecond";
            this.button_datapms.UseVisualStyleBackColor = true;
            this.button_datapms.Click += new System.EventHandler(this.button_datapms_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "1000";
            // 
            // button_clean_charts
            // 
            this.button_clean_charts.Location = new System.Drawing.Point(232, 544);
            this.button_clean_charts.Name = "button_clean_charts";
            this.button_clean_charts.Size = new System.Drawing.Size(172, 23);
            this.button_clean_charts.TabIndex = 15;
            this.button_clean_charts.Text = "Clean Charts";
            this.button_clean_charts.UseVisualStyleBackColor = true;
            this.button_clean_charts.Click += new System.EventHandler(this.button_clean_charts_Click);
            // 
            // sensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 603);
            this.Controls.Add(this.button_clean_charts);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_datapms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sensors";
            this.Text = "Sensors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sensors_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_paket_y;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_paket_g;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button button_datapms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_clean_charts;
    }
}