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

            if (pourcentage >= 0 && pourcentage < 20)
            {


                picArbre01.Visible = true;
                picArbre02.Visible = false;
                picArbre03.Visible = false;
                picArbre04.Visible = false;
                picArbre05.Visible = false;
                picArbre06.Visible = false;

                wide = (33 + (63  * (pourcentage + 1)) / 20);
                tall = (65 + (69  * (pourcentage + 1)) / 20);
                picArbre01.Width = wide;
                picArbre01.Height = tall;

                position = picArbre01.Location;
                position.X = 75 - (22  * (pourcentage + 1)/ 20);
                position.Y = 290 - tall;
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
                position.X = 53 - (10 * (pourcentage + 1) / 20);
                position.Y = 290 - tall;
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
                position.X = 43 - (9 * (pourcentage + 1) / 20);
                position.Y = 290 - tall;
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
                position.X = 34 - (24 * (pourcentage + 1) / 20);
                position.Y = 290 - tall;
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

                wide = (203 + (18 * (pourcentage - 79)) / 20);
                tall = (245 + (45 * (pourcentage - 79)) / 20);
                picArbre05.Width = wide;
                picArbre05.Height = tall;

                position = picArbre02.Location;
                position.X = 10 - (10 * (pourcentage - 79) / 20);
                position.Y = 45 - (45 * (pourcentage - 79 ) / 20);
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
