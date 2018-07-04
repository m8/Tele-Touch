using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace projedenemeleri1
{
    public partial class sensors : Form
    {
        Excel.Application ExcelApp;

        public bool button_check = false;
        public bool page_closing = false;
        int packet_n = 0;
        int data_per_msecond = 1000;

        public sensors()
        {
            page_closing = false;
            InitializeComponent();
            reading();
            chart1.Series["Sıcaklık"].Color = Color.Blue;
            chart2.Series["Basınç"].Color = Color.Blue;
            chart3.Series["Nem"].Color = Color.Blue;
            chart4.Series["Işık Şiddeti"].Color = Color.Blue;
            CheckForIllegalCrossThreadCalls = false;
        }

      

        public void reading(){

            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
                while (true && button_stop.Text == "Stop" && page_closing == false ){

                    toolStripStatusLabel_paket_g.Text = packet_n++.ToString()+"         ";
                    chart1.Series["Sıcaklık"].Points.AddY(data.sensor_temp);     
                    chart2.Series["Basınç"].Points.AddY(data.sensor_pressure);                                      
                    chart3.Series["Nem"].Points.AddY(data.sensor_humidty);
                    chart4.Series["Işık Şiddeti"].Points.AddY(data.sensor_light_i);

                    System.Threading.Thread.Sleep(data_per_msecond);


                    if (button_check == true && button_stop.Text == "Stop")
                    {
                        button_stop.Text = "Start";

                        break;
                    }
                }
            });


        }

   

        private void button_stop_Click(object sender, EventArgs e)
        {
            if(button_stop.Text == "Stop")
            {
                button_check = true;
                button_stop.Text = "Start";
            }
            else
            {
                button_stop.Text = "Stop";
                reading();
                button_check = false;
            }
        }


        private void sensors_FormClosing(object sender, FormClosingEventArgs e)
        {
            page_closing = true;
        }

        private void write_excel()
        {
            ExcelApp = new Excel.Application();
            Workbook excelBook = ExcelApp.Workbooks.Add();
            ExcelApp.Worksheets[1].Activate();
          

            ExcelApp.Cells[1, 1].Value = "Temperature";
            ExcelApp.Cells[1, 2].Value = "Humidty";
            ExcelApp.Cells[1, 3].Value = "Pressure";
            ExcelApp.Cells[1, 4].Value = "Light In.";

            int point_count = chart1.Series["Sıcaklık"].Points.Count;
  

            for (int i = 0; i < point_count-1; i++)
            {
                ExcelApp.Cells[i + 2, 1] = chart1.Series["Sıcaklık"].Points[i].YValues[0];
                ExcelApp.Cells[i + 2, 2] = chart3.Series["Nem"].Points[i].YValues[0];
                ExcelApp.Cells[i + 2, 3] = chart2.Series["Basınç"].Points[i].YValues[0];
                ExcelApp.Cells[i + 2, 4] = chart4.Series["Işık Şiddeti"].Points[i].YValues[0];
                toolStripProgressBar1.Value = (100 * i) / point_count;
            }

            ExcelApp.Visible = true;

            //excelBook.Close(0);
            //ExcelApp.Quit();
    
            toolStripProgressBar1.Value = 0;

        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            write_excel();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button_datapms_Click(object sender, EventArgs e)
        {
            data_per_msecond = Convert.ToInt32(textBox1.Text);
        }

        private void button_clean_charts_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart4.Series)
            {
                series.Points.Clear();
            }

            toolStripStatusLabel_paket_g.Text = "0";
            packet_n = 0;
        }
    }


}
