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
    public partial class NouveauLogin : Form
    {
        string nomUtilisateur = "Telethon2022";
        string motDePasse = "Don@2022";
        
        public NouveauLogin()
        {
            InitializeComponent();
        }

        private void NouveauLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nomUtilisateur.Equals(txtNom.Text) && motDePasse.Equals(txtMotDePasse.Text))
            {
                Accueil monAccueil = new();
                monAccueil.Show();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtMotDePasse.Text = String.Empty;
            txtNom.Text = String.Empty;
        }
    }
}//
