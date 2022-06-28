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
            int [,] dimensions= new int[2,6];
            
             
            double facteurConversion =  (double)panelAccueil.Width / 1010;
            if (txtMontant.Text == null) {
                txtMontant.Text = "0";
            }
            int montant = (int)double.Parse(txtMontant.Text)*100;
            int pourcentage = montant / 1000000;
            Point position;
            int largeur;
            int hauteur;
           
            dimensions[0, 0] = picArbre01.Width;
            dimensions[1, 0] = picArbre01.Height;

            dimensions[0, 1] = picArbre02.Width;
            dimensions[1, 1] = picArbre02.Height;

            dimensions[0, 2] = picArbre03.Width;
            dimensions[1, 2] = picArbre03.Height;

            dimensions[0, 3] = picArbre04.Width;
            dimensions[1, 3] = picArbre04.Height;

            dimensions[0, 4] = picArbre05.Width;
            dimensions[1, 4] = picArbre05.Height;

            dimensions[0, 5] = picArbre05.Width;
            dimensions[1, 5] = picArbre05.Height;




            if (pourcentage >= 0 && pourcentage < 20)
            {


                picArbre01.Visible = true;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                largeur = (dimensions[0,0] + ((dimensions[0, 1] - dimensions[0, 0])  * (pourcentage + 1)) / 20);
                hauteur = (dimensions[1,0] + ((dimensions[1, 1] - dimensions[1, 0])  * (pourcentage + 1)) / 20);
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

                largeur = (dimensions[0, 1] + ((dimensions[0, 2] - dimensions[0, 1]) * (pourcentage - 19)) / 20);
                hauteur = (dimensions[1, 1] + ((dimensions[1, 2] - dimensions[1, 1]) * (pourcentage - 19)) / 20);
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

                largeur = (dimensions[0, 2] + ((dimensions[0, 3] - dimensions[0, 2]) * (pourcentage - 39)) / 20);
                hauteur = (dimensions[1, 2] + ((dimensions[1, 3] - dimensions[1, 2]) * (pourcentage - 39)) / 20);
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

                largeur = (dimensions[0, 3] + ((dimensions[0, 4] - dimensions[0, 3]) * (pourcentage - 59)) / 20);
                hauteur = (dimensions[1, 3] + ((dimensions[1, 4] - dimensions[1, 3]) * (pourcentage - 59)) / 20);
                picArbre04.Width = largeur;
                picArbre04.Height = hauteur;

                position = picArbre04.Location;
                position.X = 105 - (22 * (pourcentage + 1) / 20);
                position.Y = (int)((double)291 *facteurConversion) - hauteur;
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

                largeur = (dimensions[0, 4] + ((dimensions[0, 5] - dimensions[0, 4]) *( pourcentage -  79)) / 20);
                hauteur = (dimensions[1, 4] + ((dimensions[1, 5] - dimensions[1, 4]) *  (pourcentage - 79)) / 20);
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
