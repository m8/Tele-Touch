using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projedenemeleri1
{
    public partial class sensors : Form
    {


        public sensors()
        {
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
                while (true){
                   
                    
                    chart1.Series["Sıcaklık"].Points.AddY(data.sensor_temp);     
                    chart2.Series["Basınç"].Points.AddY(data.sensor_pressure);                                      
                    chart3.Series["Nem"].Points.AddY(data.sensor_humidty);
                    chart4.Series["Işık Şiddeti"].Points.AddY(data.sensor_light_i);

                    System.Threading.Thread.Sleep(1000);
                   
                }
            });


        }

        private void sensors_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
