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
            double facteurConversion =  (double)panelAccueil.Width / 1010;
            if (txtMontant.Text == null) {
                txtMontant.Text = "0";
            }
            int montant = (int)double.Parse(txtMontant.Text)*100;
            int pourcentage = montant / 1000000;
            Point position;
            int largeur;
            int hauteur;

            if (pourcentage >= 0 && pourcentage < 20)
            {


                picArbre01.Visible = true;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                largeur = (picArbre01.Width + ((picArbre02.Width - picArbre01.Width)  * (pourcentage + 1)) / 20);
                hauteur = (picArbre01.Height + ((picArbre02.Height - picArbre01.Height)  * (pourcentage + 1)) / 20);
                picArbre01.Width = largeur;
                picArbre01.Height = hauteur;

                position = picArbre01.Location;
                position.X = 68 - ((23  * (pourcentage + 1))) / 20;
                position.Y = 291 - hauteur;
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

                largeur = (picArbre02.Width + ((picArbre03.Width - picArbre02.Width) * (pourcentage - 19)) / 20);
                hauteur = (picArbre02.Height + ((picArbre03.Height - picArbre02.Height) * (pourcentage - 19)) / 20);
                picArbre02.Width = largeur;
                picArbre02.Height = hauteur;

                position = picArbre02.Location;
                position.X = 63 - (10 * (pourcentage + 1) / 20);
                position.Y = 292 - hauteur;
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

                largeur = (picArbre03.Width + ((picArbre04.Width - picArbre03.Width) * (pourcentage - 39)) / 20);
                hauteur = (picArbre03.Height + ((picArbre04.Height - picArbre03.Height) * (pourcentage - 39)) / 20);
                picArbre03.Width = largeur;
                picArbre03.Height = hauteur;

                position = picArbre03.Location;
                position.X = 72 - (16 * (pourcentage + 1) / 20);
                position.Y = 290 - hauteur;
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

                largeur = (picArbre04.Width + ((picArbre05.Width - picArbre04.Width) * (pourcentage - 59)) / 20);
                hauteur = (picArbre04.Height + ((picArbre05.Height - picArbre04.Height) * (pourcentage - 59)) / 20);
                picArbre04.Width = largeur;
                picArbre04.Height = hauteur;

                position = picArbre04.Location;
                position.X = 105 - (22 * (pourcentage + 1) / 20);
                position.Y = 291 - hauteur;
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

                largeur = (picArbre05.Width + ((picArbre06.Width - picArbre05.Width) * (pourcentage - 79)) / 20);
                hauteur = (picArbre05.Height + ((picArbre06.Height - picArbre05.Height) * (pourcentage -79)) / 20);
                picArbre05.Width = largeur;
                picArbre05.Height = hauteur;

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
