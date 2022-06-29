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

namespace NouvelleInterface
{
    public partial class InterfacePrincipale : Form
    {
        public static string TotalDon = "0";

        /// <summary>
        /// Bloc de déclaration des variables globales
        /// </summary>
        GestionnaireSTE gestionnaireSTE = new();



        /// <summary>
        /// Constructeur
        /// </summary>
        public InterfacePrincipale()
        {
            InitializeComponent();

        }
        char typeCarte;
        /// <summary>
        /// BtnAjouterDonateur_Click effectue un ensemble de validation sur des champs correspondants aux informations de la carte de crédit, tant au niveau
        /// de leur complétude que de leur format. Si les critères nécessaires sont remplis elle crée l’objet donateur correspondant aux informations personnelles 
        /// fournies par l’utilisateur et affiche les sous-formulaires ayant trait au don.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDonateur_Click(object sender, EventArgs e)
        {
            typeCarte = 'O';
            // insister sur la complétude des champs des informations de la carte de crédit
            if (!(radAmex.Checked || radMC.Checked || radVisa.Checked) || mskTxtNumeroCarte.Text == "               " || !mskTxtNumeroCarte.MaskCompleted)
            {

                // Afficher un message d’erreur si aucun type de carte n’a été choisi
                if (!(radAmex.Checked || radMC.Checked || radVisa.Checked))
                {
                    grRadioCarte.ForeColor = Color.Maroon;
                    if (grRadioCarte.Text == "Type de carte")
                        grRadioCarte.Text += "*";
                    MessageBox.Show("Vous devez choisir un type de carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMessageCredit.Visible = true;
                }

                #region Test de complétude et validation du numéro de la carte de crédit
                SignalerIncompletude(mskTxtNumeroCarte, "               ", lblNoCredit, lblMessageCredit, "Numéro de carte :");

                if (!mskTxtNumeroCarte.MaskCompleted)
                {
                    MessageBox.Show("Veuillez compléter le numéro de la carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMessageCredit.Text = "* Incomplet";
                    lblMessageCredit.Visible = true;
                    mskTxtNumeroCarte.Focus();
                }

            }

            // Tous le champs sont complets et valides
            else
            {
                //Récupère le type de carte choisi
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


                gestionnaireSTE.AjouterDonateur(txtNomDonateur.Text, txtPrenomDonateur.Text, txtCourrielDonateur.Text, mskTxtBoxTel.Text, typeCarte, mskTxtNumeroCarte.Text, numMois.Text + "/" + numAnnee.Text, dgvDonateurs.RowCount + 1, txtBoxCvc.Text);
                MessageBox.Show("VALIDER INFO DU DONATEUR \n\r\r" + gestionnaireSTE.donateurs.Last().ToString());



                //Passage au prochain sous menu
                pnlDon.Visible = true;

                pnlCarteCredit.Visible = false;

            }
        }

        /// <summary>
        /// BtnAjouterDon_Click effectue un ensemble de validation par rapport à un don avant de le transférer dans le tableau aménagé à cet effet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDon_Click(object sender, EventArgs e)
        {
            if (txtMontant.Text != null)
            {
                Accueil parent = (Accueil)this.Owner;
                parent.GetTotalDon("" + (gestionnaireSTE.SommeDons()+ double.Parse(Accueil.montantPasse)));
            }
            string dateExpiration = numMois.Value.ToString("00") + "/" + numAnnee.Value.ToString();
            try
            {
                gestionnaireSTE.AjouterDon(dateExpiration, double.Parse(txtMontant.Text), gestionnaireSTE.dons.Count);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez utiliser une virgule pour les décimales", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMontant.Focus();
            }


            dgvDonateurs.Rows.Add("DNTR" + dgvDonateurs.RowCount + 1, txtNomDonateur.Text, txtPrenomDonateur.Text, mskTxtBoxTel.Text, txtCourrielDonateur.Text, typeCarte, mskTxtNumeroCarte.Text, numMois.Text + "/" + numAnnee.Text, txtBoxCvc.Text);
        }



        /// <summary>
        /// BtnAjouterComm_Click appelle la fonction qui crée une nouvelle instance de la classe Commanditaire à partir des paramètres fournis par l’utilisateur
        /// via l’interface. Elle est activée par l’événement click du bouton btnAjouterComm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterComm_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// BtnAjouterPrix_Click vérifier les champs des prix donnés par les commanditaire et enregistre un objet correspondant dans le tableau approprié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterPrix_Click(object sender, EventArgs e)
        {
            if (txtPrenomCommanditaire.Text == "" || txtNomCommanditaire.Text == "")
            {
                SignalerIncompletude(txtNomCommanditaire, "", lblNomCommanditaire, lblMessageCommanditaire, "Nom :");
                SignalerIncompletude(txtPrenomCommanditaire, "", lblPrenomCommanditaire, lblMessageCommanditaire, "Prénom :");
                //MessageBox.Show
            }
            else if (txtQuantitePrix.Text == "" || cbbPrix.SelectedIndex <= -1)
            {
                SignalerIncompletude(txtQuantitePrix, "", lblQuatitePrix, lblMessagePrix, "Quantité :");
                if (cbbPrix.SelectedIndex <= -1)
                {
                    lblChoixPrix.ForeColor = Color.Maroon;

                    if (lblChoixPrix.Text == "Choix Prix :")
                    {
                        lblChoixPrix.Text += "*";
                        cbbPrix.Focus();
                    }
                    else
                    {
                        lblChoixPrix.ForeColor = Color.Black;
                        lblChoixPrix.Text = "Choix Prix :";
                    }
                }
            }
            else
            {
                gestionnaireSTE.AjouterCommanditaire(txtPrenomCommanditaire.Text, txtNomCommanditaire.Text, gestionnaireSTE.commanditaires.Count);
                gestionnaireSTE.AjouterPrix(cbbPrix.Text, double.Parse(txtValeurPrix.Text), int.Parse(txtQuantitePrix.Text), gestionnaireSTE.commanditaires.Last().getIdc(), gestionnaireSTE.prix.Count);
                MessageBox.Show(gestionnaireSTE.commanditaires.Last().ToString() + " Valeur de commandite " + int.Parse(txtValeurPrix.Text) * int.Parse(txtQuantitePrix.Text) + "$");
            }
         

        }
        #endregion
        // TODO boutton afficher prix.
        #region Affiche les objets.
        /// <summary>
        /// BtnAfficherDonateur_Click affiche la liste des donateurs temporairement stockés par l’application dans la RAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficherDonateur_Click(object sender, EventArgs e)
        {
            if (dgvDonateurs.Visible == false)
            {
                StreamReader readList = new StreamReader("listeDonateurs.txt");
                string ligne = string.Empty;
                while ((ligne = readList.ReadLine()) != null)
                {
                    string[] tabLigne = ligne.Split('/');

                    dgvDonateurs.Rows.Add(tabLigne);

                }
                readList.Close();
                dgvDonateurs.Visible = true;
            }
        }

        /// <summary>
        /// BtnAfficheDon_Click affiche tous les dons recueillis durant la session de l’utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficheDon_Click(object sender, EventArgs e)
        {
            //textBoxOutput.Text = gestionnaireSTE.AfficherDons();
        }

        /// <summary>
        /// BtnAfficherCommanditaire_Click présente la liste de tous les commanditaires préservés en mémoire vive sous la forme d’une sympatiques chaine de caractères
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            txtBoxCommanditaire.Text = gestionnaireSTE.AfficherCommanditaires();
        }

        #endregion

        /// <summary>
        /// BtnSuivantDonateur_Click effectue un ensemble de validation sur la complétude et le format des informations personnelles du donateurs. Si les critères sont bien
        /// observés, elle cache le sous-formulaire des informations personnelles et révèle le sous-formulaire de la carte de crédit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuivantDonateur_Click(object sender, EventArgs e)
        {
            Regex courrielRegex = new(@"^([\w]+)@([\w]+)(\.([\w])+)+$");
            Regex telephoneRegex = new(@"^\(\d{3}\) \d{3}\-\d{4}$");
            lblMessageDonateur.Visible = true;

            if (txtPrenomDonateur.Text == "" || txtNomDonateur.Text == "" || mskTxtBoxTel.Text == "(   )    -")
            {
                // Mise en évidence des champs vides
                SignalerIncompletude(mskTxtBoxTel, "(   )    -", lblTelephone, lblMessageDonateur, "Téléphone :");
                SignalerIncompletude(txtNomDonateur, "", lblNomDonateur, lblMessageDonateur, "Nom :");
                SignalerIncompletude(txtPrenomDonateur, "", lblPrenomDonateur, lblMessageDonateur, "Prénom :");

            }


            else if (!telephoneRegex.IsMatch(mskTxtBoxTel.Text))
            {
                mskTxtBoxTel.Focus();
                lblTelephone.ForeColor = Color.Maroon;
                MessageBox.Show("!! Il manque un ou des chiffres au #Téléphone !!");

                lblMessageDonateur.Visible = true;
            }

            else if (!courrielRegex.IsMatch(txtCourrielDonateur.Text) && txtCourrielDonateur.Text != String.Empty)
            {
                txtCourrielDonateur.Focus();
                lblMessageDonateur.Visible = true;
                MessageBox.Show("Format de Courriel invalide\n\ressayer de nouveaux ou laisser le champ vide.");
            }
            else if (pnlInfoDonateur.Visible)
            {
                pnlInfoDonateur.Visible = false;
                pnlCarteCredit.Visible = true;
                lblID.Text = "IDD: DNTR" + (dgvDonateurs.RowCount + 1) + "\n\rNom :" + txtPrenomDonateur.Text + " " + txtNomDonateur.Text;
            }
        }

        /// <summary>
        /// BtnQuitter_Click quitte l’application vers la fenêtre de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            StreamWriter saveListCommaditaires = new("ListeCommanditaires.txt", false);
            StreamWriter saveListDon = new("ListeDon.txt", false);
            StreamWriter saveListDonateurs = new("ListeDonateurs.txt", false);

            foreach (DataGridViewRow colonne in dgvDonateurs.Rows)
            {
                string? IDD;
                string? nom;
                string? prenom;
                string? telephone;
                string? courriel;
                string? typeDeCarte;
                string? numeroDeCarte;
                string? dateDexpiration;

                if (colonne.Cells[0].Value.ToString() != null)
                    IDD = colonne.Cells[0].Value.ToString();
                else
                    IDD = "";

                if (colonne.Cells[1].Value.ToString() != null)
                    nom = colonne.Cells[1].Value.ToString();
                else
                    nom = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    prenom = colonne.Cells[2].Value.ToString();
                else
                    prenom = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    telephone = colonne.Cells[4].Value.ToString();
                else
                    telephone = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    courriel = colonne.Cells[3].Value.ToString();
                else
                    courriel = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    typeDeCarte = colonne.Cells[5].Value.ToString();
                else
                    typeDeCarte = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    numeroDeCarte = colonne.Cells[6].Value.ToString();
                else
                    numeroDeCarte = "";

                if (colonne.Cells[2].Value.ToString() != null)
                    dateDexpiration = colonne.Cells[7].Value.ToString();
                else
                    dateDexpiration = "";
                if (IDD != "" ||
                    nom != "" ||
                    prenom != "" ||
                    telephone != "" ||
                    typeDeCarte != "" ||
                    numeroDeCarte != "" ||
                    dateDexpiration != "")

                    saveListDonateurs.WriteLine(IDD + "/" + nom + "/" + prenom + "/" + telephone + "/" + courriel + "/" + typeDeCarte + "/" + numeroDeCarte + "/" + dateDexpiration);
            }
            foreach (Donateur listDonateur in gestionnaireSTE.donateurs)
            {

                saveListCommaditaires.WriteLine(listDonateur.ToString());
            }


            double total = double.Parse(Accueil.montantPasse);
            foreach (Don listDons in gestionnaireSTE.dons)
            {
                total += listDons.getMontantDon();
            }
            saveListDon.WriteLine(total.ToString());
            saveListCommaditaires.Close();
            saveListDon.Close();
            saveListDonateurs.Close();
            this.Close();
        }


        /// <summary>
        /// MskTxtBoxTel_Click positionne le curseur au début du la boîte de texte du numéro de téléphone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MskTxtBoxTel_Click(object sender, EventArgs e)
        {
            TxtNoir(lblTelephone, "Téléphone :");
            mskTxtBoxTel.Select(0, 0);
        }


        /// <summary>
        /// TxtNumeroCarte_Click place la petite patente qui indique où on est rendu au début du rectangle de capture du numéro de carte de crédit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNumeroCarte_Click(object sender, EventArgs e)
        {
            TxtNoir(lblNoCredit, "Numéro de carte :");
            mskTxtNumeroCarte.Select(0, 0);
        }


        /// <summary>
        /// BtnCalculRecompense_Click Bouton Calcule Récompense 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculRecompense_Click(object sender, EventArgs e)
        {
            txtRecompense.Text = gestionnaireSTE.AttribuerPrix(double.Parse(txtMontant.Text));
        }


        /// <summary>
        /// Interface_temp_Load Fonction qui gère ce qui doit être fait au moment du chargement de notre formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_temp_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Permet d'afficher une infoBulle , lorsque le curseur survol les textbox des champs obligatoires, info donnateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtDonnateurChampsObligatoire_mouseHover(object sender, EventArgs e)
        {
            infoBulle.SetToolTip(txtPrenomDonateur, "Prénom obligatoire");
            infoBulle.SetToolTip(txtNomDonateur, "Nom obligatoire");
            infoBulle.SetToolTip(mskTxtBoxTel, "Téléphone obligatoire");

        }

        /// <summary>
        /// signalerIncompletude permet de mettre en évidence un champ de type Textbox obligatoire qui est rester vide
        /// </summary>
        /// <param name="monTxt"></param> le champ dont on teste la complétude
        /// <param name="chaineVide"></param> une chaine de caractère qui correspond au champ laisser intouché (utile surtout pour les maskedTextbox qui ne sont pas vide lorsque rien n’y a été entré)
        /// <param name="monLbl"></param> le label qui identifie monTxt sur le formulaire. On en change la couleur
        /// <param name="monMessage"></param> le label de message que nous affichons si monTxt est vide
        /// <param name="etiquette"></param> une chaine de caractère qui correspond à la valeur attendue de monMessage si le champ est n’est pas vide
        private static void SignalerIncompletude(Control monTxt, string chaineVide, Control monLbl, Control monMessage, string etiquette)
        {
            if (monTxt.Text == chaineVide)
            {
                monLbl.ForeColor = Color.Maroon;
                if (monLbl.Text == etiquette)
                    monLbl.Text += "*";
                monMessage.Visible = true;
                monTxt.Focus();
            }
            else
            {
                monLbl.ForeColor = Color.Black;
                monLbl.Text = etiquette;
            }

        }
        // TODO Commentaire
        private void TxtNoir(Control lblAchange, string chaineAchange)
        {
            lblAchange.ForeColor = Color.Black;
            lblAchange.Text = chaineAchange;
        }

        private void TxtPrenomDonateurNoir_Click(object sender, EventArgs e)
        {
            TxtNoir(lblPrenomDonateur, "Prénom :");
        }

        private void TxtNomDonateur_Click(object sender, EventArgs e)
        {
            TxtNoir(lblNomDonateur, "Nom :");
        }

        private void TxtCourrielDonateur_Click(object sender, EventArgs e)
        {
            TxtNoir(lblCourriel, "Courriel :");
        }

        private void MskTxtNumeroCarte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #region ensemble de fonction qui remette le texte des labels des champs erronés en Noir et qui réinitialise leur valeur
        private void TxtPrenomCommanditaire_Click(object sender, EventArgs e)
        {
            TxtNoir(lblPrenomCommanditaire, "Prénom :");
        }

        private void TxtNomCommanditaire_Click(object sender, EventArgs e)
        {
            TxtNoir(lblNomCommanditaire, "Nom :");
        }

        private void TxtDescription_Click(object sender, EventArgs e)
        {
            TxtNoir(lblChoixPrix, "Description :");
        }

        private void TxtValeurPrix_Click(object sender, EventArgs e)
        {
            TxtNoir(lblValeur, "Valeur unitaire :");
        }

        private void TxtQuantitePrix_Click(object sender, EventArgs e)
        {
            TxtNoir(lblQuatitePrix, "Quantité :");
        }

        #endregion

        private void btnValider_Click(object sender, EventArgs e)
        {
            radAmex.Checked = false;
            radMC.Checked = false;
            radVisa.Checked = false;
            txtBoxCvc.Text = string.Empty;
            txtNomDonateur.Text = string.Empty;
            txtPrenomDonateur.Text = string.Empty;
            txtCourrielDonateur.Text = string.Empty;
            mskTxtBoxTel.Text = string.Empty;
            mskTxtNumeroCarte.Text = string.Empty;
            pnlCarteCredit.Visible = false;
            pnlDon.Visible = false;
            pnlInfoDonateur.Visible = true;

        }

        private void cbbPrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prix = cbbPrix.Text;
            switch (prix)
            {
                case "Calendrier":
                    txtValeurPrix.Text = "10";
                    break;
                case "Repas pour 2":
                    txtValeurPrix.Text = "100";
                    break;
                case "BBQ":
                    txtValeurPrix.Text = "300";
                    break;
                default:
                    txtValeurPrix.Text = "1000";
                    break;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grRadioCarte_Enter(object sender, EventArgs e)
        {

        }

        private void tabDonateur_Click(object sender, EventArgs e)
        {

        }

        private void pnInfoDonTitre2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}