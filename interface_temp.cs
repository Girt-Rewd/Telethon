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
            gestionnaireSTE.AjouterCommanditaire(txtPrenomCommanditaire.Text, txtNomCommanditaire.Text, gestionnaireSTE.commanditaires.Count);

        }

        private void btnAjoutreDonateur_Click(object sender, EventArgs e)
        {
            char typeCarte = 'O';
            if (!(radAmex.Checked || radMC.Checked || radVisa.Checked))
            {
                MessageBox.Show("Vous devez choisir un type de carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtNumeroCarte.Text == "")
            {
                lblNoCredit.ForeColor = Color.Maroon;
                lblNoCredit.Text = lblNoCredit.Text + "*";
                lblMessageCredit.Visible = true;
            }
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
                gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, txtTelephoneDonateur.Text, typeCarte, txtNumeroCarte.Text, dtpExpiration.Value.ToShortDateString(), gestionnaireSTE.donateurs.Count());
            }
        }




        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDonateurs();
        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherCommanditaires();
        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            Prix television = new Prix(txtDescription.Text, double.Parse(txtValeurPrix.Text), int.Parse(txtQuatitePrix.Text), "CMDT098", gestionnaireSTE.prix.Count());
            textBoxOutput.Text = television.ToString();
        }

        private void btnCacher_Click(object sender, EventArgs e)
        {
            if (txtPrenomDonateur.Text == "" || txtNomDonateur.Text == "" || txtTelephoneDonateur.Text == "")
            {
                lblPrenomDonateur.ForeColor = Color.Maroon;
                lblPrenomDonateur.Text += "*";
                lblNomDonateur.ForeColor = Color.Maroon;
                lblNomDonateur.Text += "*";
                lblTelephone.ForeColor = Color.Maroon;
                lblTelephone.Text += "*";
                lblMessageDonateur.Visible = true;
            }
            else if (pnlInfoDonateur.Visible)
            {
                pnlInfoDonateur.Visible = false;
                grCarteCredit.Visible = true;

            }

        }

        private void txtTelephoneDonateur_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
