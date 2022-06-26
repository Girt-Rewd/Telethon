using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NouvelleInterface
{
    public partial class Progression : Form
    {
        public Progression()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point position;
            int wide;
            int tall;
            
            if (numericUpDown1.Value >= 0 && numericUpDown1.Value < 20) {
                

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                wide = 72/20 * (int)(numericUpDown1.Value+1);
                tall = 116/20 *((int)(numericUpDown1.Value +1));
                pictureBox1.Width = wide;
                pictureBox1.Height = tall;

                position = pictureBox1.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox1.Location = position;

            } else if(numericUpDown1.Value < 40)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                Point p2 = pictureBox2.Location;
                p2

            }
            else if (numericUpDown1.Value < 60)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            }
            else if (numericUpDown1.Value < 80)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            }
            else if (numericUpDown1.Value < 100)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;

            }
            else 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
