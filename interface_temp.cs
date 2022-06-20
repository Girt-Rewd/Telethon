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
    public partial class interface_temp : Form
    {
        GestionnaireSTE gestionnaireSTE = new GestionnaireSTE();
        public interface_temp()
        {
            InitializeComponent();
            
        }

        private void btnAjouterComm_Click(object sender, EventArgs e)
        {
            Commanditaire leCommanditaire1 = new Commanditaire(txtPrenomCommanditaire.Text, txtNomCommanditaire.Text, txtEntreprise.Text);
            textBoxOutput.Text = leCommanditaire1.ToString();
        }

        private void btnAjoutreDonateur_Click(object sender, EventArgs e)
        {
            char typeCarte = 'O';
            if (radAmex.Checked || radMC.Checked || radVisa.Checked)
            {
                if (radAmex.Checked)
                {
                    typeCarte = 'A';
                }
                else if (radMC.Checked)
                {
                    typeCarte = 'M';
                }
                else if (radVisa.Checked)
                {
                    typeCarte = 'V';
                }

            }
            else
            {
                MessageBox.Show("Vous devez choisir un type de carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, txtTelephoneDonateur.Text, typeCarte, txtNumeroCarte.Text, dtpExpiration.Value.ToShortDateString());
            

            
        }

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDonateur();
        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            Prix television = new Prix("Television à écran plat", 10, 10, "Burt1000");
            textBoxOutput.Text = television.ToString();

        }
    }
    
}
