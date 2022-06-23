using System.Text.RegularExpressions;
using STELib;

//TODO continuer infoCarte de credit... validation CVC et dateEXp nouveaux format mm/aa

namespace Telethon
{
    public partial class Interface_temp : Form
    {
        GestionnaireSTE gestionnaireSTE = new();
        public Interface_temp()
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


                gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, mskTxtBoxTel.Text, typeCarte, mskTxtNumeroCarte.Text, txtBoxDateExpCarte.Text, gestionnaireSTE.donateurs.Count);
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

        private void BtnAjouterPrix_Click(object sender, EventArgs e)
        {
            Prix television = new(txtDescription.Text, double.Parse(txtValeurPrix.Text), int.Parse(txtQuatitePrix.Text), "CMDT098", gestionnaireSTE.prix.Count);
            textBoxOutput.Text = television.ToString();
        }

        private void BtnCacher_Click(object sender, EventArgs e)//TODO Essayer d'
        {
            Regex courrielRegex = new Regex(@"^([\w]+)@([\w]+)(\.([\w])+)+$");
            Regex telephoneRegex = new Regex(@"^\(\d{3}\) \d{3}\-\d{4}$");
            lblMessageDonateur.Visible = true;


            if(false == true)//HACK (txtPrenomDonateur.Text == "" || txtNomDonateur.Text == "" || mskTxtBoxTel.Text == "(   )    -")
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
            else if(false)/* HACK(!telephoneRegex.IsMatch(mskTxtBoxTel.Text))*/
            {

                mskTxtBoxTel.Focus();
                lblTelephone.ForeColor = Color.Maroon;
                MessageBox.Show("!! Il manque un ou des chiffres au #Téléphone !!");
                //mskTxtBoxTel.Text = "";

                lblMessageDonateur.Visible = true;
            }
            else if (false)/* HACK(!courrielRegex.IsMatch(txtCourrielDonateur.Text) && txtCourrielDonateur.Text != String.Empty)*/
            {
                MessageBox.Show("Format de Courriel invalide\n\ressayer de nouveaux ou laisser le champ vide.");
                //txtCourrielDonateur.Text = "";
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
            txtRecompense.Text = gestionnaireSTE.AttribuerPrix(double.Parse(txtMontant.Text));
        }

        private void interface_temp_Load(object sender, EventArgs e)
        {

        }
    }

}