﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using STELib;

//TODO continuer infoCarte de credit... validation CVC et dateEXp nouveaux format mm/aa

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

        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            gestionnaireSTE.AjouterDon(txtBoxDateExpCarte.Text, txtIDDon.Text, double.Parse(txtMontant.Text), gestionnaireSTE.dons.Count);
        }

        private void btnAjoutreDonateur_Click(object sender, EventArgs e)
        {
            char typeCarte = 'O';
            if (!(radAmex.Checked || radMC.Checked || radVisa.Checked))
            {
                MessageBox.Show("Vous devez choisir un type de carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (mskTxtNumeroCarte.Text == "")
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


                gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, mskTxtBoxTel.Text, typeCarte, mskTxtNumeroCarte.Text, txtBoxDateExpCarte.Text, gestionnaireSTE.donateurs.Count());
                pnlDon.Visible = true;
                pnlPrix.Visible = true;
                pnlCarteCredit.Visible = false;
            }
        }



        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDonateurs();
        }

        private void btnAfficheDon_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDons();
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

        private void btnCacher_Click(object sender, EventArgs e)//TODO Essayer d'
        {
            Regex courrielRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)((\.([\w]+))+)$");
            Regex telephoneRegex = new Regex(@"^\(\d{3}\) \d{3}\-\d{4}$");
            lblMessageDonateur.Visible = true;


            if (txtPrenomDonateur.Text == "" || txtNomDonateur.Text == "" || mskTxtBoxTel.Text == "")
            {

                if (txtPrenomDonateur.Text == String.Empty)
                {
                    lblPrenomDonateur.ForeColor = Color.Maroon;
                    lblPrenomDonateur.Text += "*";
                }
                else
                {
                    lblPrenomDonateur.ForeColor = Color.Black;
                    lblPrenomDonateur.Text = "Prénom :";
                }
                if (txtNomDonateur.Text == String.Empty)
                {
                    lblNomDonateur.ForeColor = Color.Maroon;
                    lblNomDonateur.Text += "*";
                }
                else
                {
                    lblNomDonateur.ForeColor = Color.Black;
                    lblNomDonateur.Text = "Nom :";
                }
                if (mskTxtBoxTel.Text == String.Empty)
                {
                    lblTelephone.ForeColor = Color.Maroon;
                    lblTelephone.Text += "*";
                }
                else
                {
                    lblTelephone.ForeColor = Color.Black;
                    lblTelephone.Text = "Téléphone :";
                }
            }
            else if (!telephoneRegex.IsMatch(mskTxtBoxTel.Text))
            {
                MessageBox.Show("!! Il manque un ou des chiffres au #Téléphone !!");
                mskTxtBoxTel.Text = "";
                mskTxtBoxTel.Focus();
                lblTelephone.ForeColor = Color.Maroon;
                lblMessageDonateur.Visible = true;
            }
            else if (!courrielRegex.IsMatch(txtCourrielDonateur.Text) && txtCourrielDonateur.Text != String.Empty)
            {
                MessageBox.Show("Format de Courriel invalide\n\ressayer de nouveaux ou laisser le champ vide.");
                txtCourrielDonateur.Text = "";
                txtCourrielDonateur.Focus();
                lblMessageDonateur.Visible = true;
            }
            else if (pnlInfoDonateur.Visible)
            {
                pnlInfoDonateur.Visible = false;
                pnlCarteCredit.Visible = true;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskTxtBoxTel_Click(object sender, EventArgs e)
        {
            mskTxtBoxTel.Select(0, 0);
        }

        private void txtNumeroCarte_Click(object sender, EventArgs e)
        {
            mskTxtNumeroCarte.Select(0, 0);
        }

        private void btnCalculRecompense_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AttribuerPrix(double.Parse(txtMontant.Text));
        }
    }

}