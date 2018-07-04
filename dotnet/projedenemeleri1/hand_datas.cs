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
    public partial class hand_datas : Form
    {
        public hand_datas()
        {
            InitializeComponent();
        }

        private void hand_datas_Load(object sender, EventArgs e)
        {

            Task.Run(()=>{

                while (true)
                {
                    critise_fill_color();
                }

            });

           


        }

        public void critise_fill_color()
        {

            if(data.leap_finger_index > 85)
            {
                textBox_index.BackColor = Color.Green;
            }
            else
            {
                textBox_index.BackColor = Color.White;
            }

            if (data.leap_finger_thumb > 85)
            {
                textBox_thumb.BackColor = Color.Green;
            }
            else
            {
                textBox_thumb.BackColor = Color.White;
            }

            if (data.leap_finger_middle > 85)
            {
                textBox_middle.BackColor = Color.Green;
            }
            else
            {
                textBox_middle.BackColor = Color.White;
            }

        
            if (data.leap_finger_pinky > 85)
            {
                textBox_pinky.BackColor = Color.Green;
            }
            else
            {
                textBox_pinky.BackColor = Color.White;
            }

            if (data.leap_finger_ring > 85)
            {
                textBox_ring.BackColor = Color.Green;
            }
            else
            {
                textBox_ring.BackColor = Color.White;
            }




        }

  
    }
}
