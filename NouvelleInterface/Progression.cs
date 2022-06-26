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

                wide = 36 + 36/20 * (int)(numericUpDown1.Value + 1);
                tall = 58 + 58/20 * ((int)(numericUpDown1.Value + 1));
                pictureBox1.Width = wide;
                pictureBox1.Height = tall;

                position = pictureBox1.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox1.Location = position;

            } 
            else if(numericUpDown1.Value < 40)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                wide = 72 + (55 / 20 * (int)(numericUpDown1.Value-19 ));
                tall = 116 + (62 / 20 * ((int)(numericUpDown1.Value-19 )));
                pictureBox2.Width = wide;
                pictureBox2.Height = tall;

                position = pictureBox2.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox2.Location = position;

            }
            else if (numericUpDown1.Value < 60)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                wide = 127 + 28/ 20 * (int)(numericUpDown1.Value-39);
                tall = 178 + 49 / 20 * ((int)(numericUpDown1.Value-39));
                pictureBox3.Width = wide;
                pictureBox3.Height = tall;

                position = pictureBox3.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox3.Location = position;

            }
            else if (numericUpDown1.Value < 80)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                wide = 155 + 54 / 20 * (int)(numericUpDown1.Value-59);
                tall = 227 + 52 / 20 * ((int)(numericUpDown1.Value)-59);
                pictureBox4.Width = wide;
                pictureBox4.Height = tall;

                position = pictureBox4.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox4.Location = position;

            }
            else if (numericUpDown1.Value < 100)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;

                wide = 209 + 61 / 20 * (int)(numericUpDown1.Value - 79);
                tall = 279 + 46 / 20 * ((int)(numericUpDown1.Value - 79 ));
                pictureBox5.Width = wide;
                pictureBox5.Height = tall;

                position = pictureBox2.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                pictureBox5.Location = position;

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

        private void Progression_Load(object sender, EventArgs e)
        {
            int wide;
            int tall;
            Point position;

            wide = 36 + 36 / 20 * (int)(numericUpDown1.Value + 1);
            tall = 58 + 58 / 20 * ((int)(numericUpDown1.Value + 1));
            pictureBox1.Width = wide;
            pictureBox1.Height = tall;

            position = pictureBox1.Location;
            position.Y = 391 - tall;
            position.X = (324 - wide) / 2;
            pictureBox1.Location = position;
        }
    }
}
