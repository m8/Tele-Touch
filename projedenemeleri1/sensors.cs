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
        }

        public void reading(){

            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
                while (true){
                    //label1.Invoke((MethodInvoker)(() => label1.Text = data.temp.ToString()));
                    chart1.Invoke((MethodInvoker)(() => chart1.Series["Sıcaklık"].Points.AddY(data.temp)));
                    

                    chart2.Invoke((MethodInvoker)(() => chart2.Series["Basınç"].Points.AddY(data.pres)));
                    
                    
                    chart3.Invoke((MethodInvoker)(() => chart3.Series["Nem"].Points.AddY(data.humidty)));
                    chart4.Invoke((MethodInvoker)(() => chart4.Series["Işık Şiddeti"].Points.AddY(data.lighti)));

                    

                    System.Threading.Thread.Sleep(1000);
                   
                }
            });


        }


        public void criticise()
        {

            Task.Run(() =>
            {
                while (true)
                {

                }

            
            
            }
            );


        }


        private void SetLabel(string newText)
        {
            
        }

        private void sensors_Load(object sender, EventArgs e)
        {

        }

       

        

    }
}
