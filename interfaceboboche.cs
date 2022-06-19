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
    public partial class Interfaceboboche : Form
    {
        public Interfaceboboche()
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

            Donateur ledonateur = new Donateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, txtTelephoneDonateur.Text, typeCarte, txtNumeroCarte.Text, dtpExpiration.Value.ToShortDateString());

            textBoxOutput.Text = ledonateur.ToString();
        }
    }
    
}
