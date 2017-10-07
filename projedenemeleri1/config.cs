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
    public partial class config : Form
    {
        static Queue<double> thumb = new Queue<double>(new List<double>() { 0, 0, 0});
        static Queue<double> index = new Queue<double>(new List<double>() { 0, 0, 0 });
        static Queue<double> middle = new Queue<double>(new List<double>() { 0, 0, 0 });
        static Queue<double> ring = new Queue<double>(new List<double>() { 0, 0, 0 });
        static Queue<double> pinky = new Queue<double>(new List<double>() { 0, 0, 0 });


        

        public config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void conlsit()
        {
            label1.Text = "Baş Parmağınızı Açın ";


            label1.Text = "İşaret Parmağınızı Açın ";

            label1.Text = "Orta Parmağınızı Açın ";

            label1.Text = "Yüzük Parmağınızı Açın ";

            label1.Text = "Serçe Parmağınızı Açın ";

        }

    }
}
