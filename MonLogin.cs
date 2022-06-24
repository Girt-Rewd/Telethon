using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STELib;

namespace Telethon
{
    public partial class MonLogin : Form
    {
        string nomUtilisateur = "Telethon2022";
        string motDePasse = "Don@2022";

        
        public MonLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nomUtilisateur.Equals(txtNom.Text) && motDePasse.Equals(txtMotDePasse.Text))
            {
                Interface_temp monInterface = new Interface_temp();
                monInterface.Show();
            }
            else {
               MessageBox.Show("Identifiant ou mot de passe invalide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// BtnAnnuler_Click vide les champs de l’interface login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtMotDePasse.Text = "";
        }
    }
}
