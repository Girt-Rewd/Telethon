using System;
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
    public partial class Interface_temp : Form
    {
        /// <summary>
        /// Bloc de déclaration des variables globales
        /// </summary>
        GestionnaireSTE gestionnaireSTE = new();
        string  dateExpiration ="";
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public Interface_temp()
        {
            InitializeComponent();
        }

        private void BtnAjouterComm_Click(object sender, EventArgs e)
        {
            gestionnaireSTE.AjouterCommanditaire(txtPrenomCommanditaire.Text, txtNomCommanditaire.Text, gestionnaireSTE.commanditaires.Count);
        }

        private void BtnAjouterDon_Click(object sender, EventArgs e)
        {
            dateExpiration = numMois.Value.ToString("00") + "/" + numAnnee.Value.ToString();
            gestionnaireSTE.AjouterDon(dateExpiration, txtIDDon.Text, double.Parse(txtMontant.Text), gestionnaireSTE.dons.Count);
        }

        private void BtnAjouterDonateur_Click(object sender, EventArgs e)
        {
            
            
            char typeCarte = 'O';

            if (!(radAmex.Checked || radMC.Checked || radVisa.Checked) || mskTxtNumeroCarte.Text == "               " || !mskTxtNumeroCarte.MaskCompleted)
            {
                if (!(radAmex.Checked || radMC.Checked || radVisa.Checked))
                {
                    grRadioCarte.ForeColor = Color.Maroon;
                    if (grRadioCarte.Text == "Type de carte")
                        grRadioCarte.Text += "*";
                    MessageBox.Show("Vous devez choisir un type de carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMessageCredit.Visible = true;
                }

                if (mskTxtNumeroCarte.Text == "               ")
                {
                    lblNoCredit.ForeColor = Color.Maroon;
                    if (lblNoCredit.Text == "Numéro de carte :")
                        lblNoCredit.Text += "*";
                    lblMessageCredit.Visible = true;
                }
                else if (!mskTxtNumeroCarte.MaskCompleted)
                {
                    MessageBox.Show("Veuillez compléter le numéro de la carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTxtNumeroCarte.Focus();
                } 
            }
            else
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


                gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, mskTxtBoxTel.Text, typeCarte, mskTxtNumeroCarte.Text, dateExpiration, gestionnaireSTE.donateurs.Count);
                pnlDon.Visible = true;
                pnlPrix.Visible = true;
                pnlCarteCredit.Visible = false;
            }
        }



        private void BtnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDonateurs();
        }

        private void BtnAfficheDon_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDons();
        }

        private void BtnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherCommanditaires();
        }

        private void BtnAjouterPrix_Click(object sender, EventArgs e)
        {
            Prix television = new(txtDescription.Text, double.Parse(txtValeurPrix.Text), int.Parse(txtQuatitePrix.Text), "CMDT098", gestionnaireSTE.prix.Count);
            textBoxOutput.Text = television.ToString();
        }

        private void BtnSuivantDonateur_Click(object sender, EventArgs e)//TODO Essayer d'
        {
            Regex courrielRegex = new(@"^([\w]+)@([\w]+)(\.([\w])+)+$");
            Regex telephoneRegex = new(@"^\(\d{3}\) \d{3}\-\d{4}$");
            lblMessageDonateur.Visible = true;


            if(txtPrenomDonateur.Text == "" || txtNomDonateur.Text == "" || mskTxtBoxTel.Text == "(   )    -")
            {
                // Mise en évidence des champs vides
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

                if (mskTxtBoxTel.Text == "(   )    -")
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
            else if((!telephoneRegex.IsMatch(mskTxtBoxTel.Text)
            {
                mskTxtBoxTel.Focus();
                lblTelephone.ForeColor = Color.Maroon;
                MessageBox.Show("!! Il manque un ou des chiffres au #Téléphone !!");

                lblMessageDonateur.Visible = true;
            }
            else if (!courrielRegex.IsMatch(txtCourrielDonateur.Text) && txtCourrielDonateur.Text != String.Empty)
            {
                MessageBox.Show("Format de Courriel invalide\n\ressayer de nouveaux ou laisser le champ vide.");
                txtCourrielDonateur.Focus();
                lblMessageDonateur.Visible = true;
            }
            else if (pnlInfoDonateur.Visible)
            {
                pnlInfoDonateur.Visible = false;
                pnlCarteCredit.Visible = true;
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MskTxtBoxTel_Click(object sender, EventArgs e)
        {
            mskTxtBoxTel.Select(0, 0);
        }

        private void TxtNumeroCarte_Click(object sender, EventArgs e)
        {
            mskTxtNumeroCarte.Select(0, 0);
        }

        private void BtnCalculRecompense_Click(object sender, EventArgs e)
        {
            txtRecompense.Text = GestionnaireSTE.AttribuerPrix(double.Parse(txtMontant.Text));
        }

        private void Interface_temp_Load(object sender, EventArgs e)
        {

        }

       
    }

}