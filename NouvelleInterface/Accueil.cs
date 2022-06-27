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
    public partial class Accueil : Form
    {
        public static string montantPasse = "0";
        public Accueil()
        {
            InitializeComponent();
            
            montantPasse = InterfacePrincipale.TotalDon; 
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btnInscription_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            int montant = (int)double.Parse(txtMontant.Text)*100;
            int pourcentage = montant / 1000000;
            Point position;
            int wide;
            int tall;

            if (pourcentage >= 0 && pourcentage < 19)
            {


                picArbre01.Visible = true;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = 36 + 36 / 20 * (int)(pourcentage + 1);
                tall = 58 + 58 / 20 * ((int)(pourcentage + 1));
                picArbre01.Width = wide;
                picArbre01.Height = tall;

                position = picArbre01.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                picArbre01.Location = position;

            }
            else if (pourcentage < 40)
            {
                picArbre01.Visible = false;
                picArbre02.Visible = true;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = 72 + (55 / 20 * (int)(pourcentage - 19));
                tall = 116 + (62 / 20 * ((int)(pourcentage - 19)));
                picArbre02.Width = wide;
                picArbre02.Height = tall;

                position = picArbre02.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                picArbre02.Location = position;

            }
            else if (pourcentage < 60)
            {
                picArbre01.Visible = false;
                picArbre02.Visible = false;
                picArbre03.Visible = true;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = 127 + 28 / 20 * (int)(pourcentage - 39);
                tall = 178 + 49 / 20 * ((int)(pourcentage - 39));
                picArbre03.Width = wide;
                picArbre03.Height = tall;

                position = picArbre03.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                picArbre03.Location = position;

            }
            else if (pourcentage < 80)
            {
                picArbre01.Visible = false;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = true;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = 155 + 54 / 20 * (int)(pourcentage - 59);
                tall = 227 + 52 / 20 * ((int)(pourcentage) - 59);
                picArbre04.Width = wide;
                picArbre04.Height = tall;

                position = picArbre04.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                picArbre04.Location = position;

            }
            else if (pourcentage < 100)
            {
                picArbre01.Visible = false;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = true;
                picArbre06.Visible = false;

                wide = 209 + 61 / 20 * (int)(pourcentage - 79);
                tall = 279 + 46 / 20 * ((int)(pourcentage - 79));
                picArbre05.Width = wide;
                picArbre05.Height = tall;

                position = picArbre02.Location;
                position.Y = 391 - tall;
                position.X = (324 - wide) / 2;
                picArbre05.Location = position;

            }
            else
            {
                picArbre01.Visible = false;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = true;

            }

        }

        private void btnInscription_Click_1(object sender, EventArgs e)
        {
            InterfacePrincipale monPrincipal = new();
            monPrincipal.Show();
        }

        public void GetTotalDon(string reponse) { 
            txtMontant.Text = reponse;  
        }
    }
}
