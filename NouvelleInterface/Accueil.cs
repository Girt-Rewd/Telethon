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
            double facteurConversion = 1010 / (double)panelAccueil.Width;
            if (txtMontant.Text == null) {
                txtMontant.Text = "0";
            }
            int montant = (int)double.Parse(txtMontant.Text)*100;
            int pourcentage = montant / 1000000;
            Point position;
            int wide;
            int tall;

            if (pourcentage >= 0 && pourcentage < 20)
            {


                picArbre01.Visible = true;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = (54 + (42  * (pourcentage + 1)) / 20);
                tall = (88 + (46  * (pourcentage + 1)) / 20);
                picArbre01.Width = wide;
                picArbre01.Height = tall;

                position = picArbre01.Location;
                position.X = 68 - ((23  * (pourcentage + 1))) / 20;
                position.Y = 291 - tall;
                position.X = (int)(position.X * facteurConversion);
                position.Y = (int)(position.Y * facteurConversion);
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

                wide = (96 + (21 * (pourcentage -19)) / 20);
                tall = (134 + (37 * (pourcentage -19)) / 20);
                picArbre02.Width = wide;
                picArbre02.Height = tall;

                position = picArbre02.Location;
                position.X = 63 - (10 * (pourcentage + 1) / 20);
                position.Y = 292 - tall;
                position.X = (int)(position.X * facteurConversion);
                position.Y = (int)(position.Y * facteurConversion);
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

                wide = (117 + (40 * (pourcentage - 39)) / 20);
                tall = (171 + (39 * (pourcentage - 39)) / 20);
                picArbre03.Width = wide;
                picArbre03.Height = tall;

                position = picArbre03.Location;
                position.X = 72 - (16 * (pourcentage + 1) / 20);
                position.Y = 290 - tall;
                position.X = (int)(position.X * facteurConversion);
                position.Y = (int)(position.Y * facteurConversion);
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

                wide = (157 + (35 * (pourcentage - 59)) / 20);
                tall = (210 + (37 * (pourcentage - 59)) / 20);
                picArbre04.Width = wide;
                picArbre04.Height = tall;

                position = picArbre04.Location;
                position.X = 105 - (22 * (pourcentage + 1) / 20);
                position.Y = 291 - tall;
                position.X = (int)(position.X * facteurConversion);
                position.Y = (int)(position.Y * facteurConversion);
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

                wide = (203 + (25 * (pourcentage - 79)) / 20);
                tall = (245 + (55 * (pourcentage - 79)) / 20);
                picArbre05.Width = wide;
                picArbre05.Height = tall;

                position = picArbre02.Location;
                position.X = 10 - (12 * (pourcentage - 79) / 20);
                position.Y = 51 - (47 * (pourcentage - 79 ) / 20);
                position.X = (int)(position.X * facteurConversion);
                position.Y = (int)(position.Y * facteurConversion);
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
            using (InterfacePrincipale monPrincipal = new())
            {

                monPrincipal.ShowDialog(this);
            }
        }

        public void GetTotalDon(string reponse) { 
            txtMontant.Text = reponse;  
        }
    }
}
