using System.Text.RegularExpressions;
using STELib;

//TODO continuer infoCarte de credit... validation CVC 

namespace Telethon
{
    public partial class Interface_temp : Form
    {

        /// <summary>
        /// Bloc de déclaration des variables globales
        /// </summary>
        GestionnaireSTE gestionnaireSTE = new();
        string dateExpiration = "";

        /// <summary>
        /// Constructeur
        /// </summary>
        public Interface_temp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// BtnAjouterDonateur_Click effectue un ensemble de validation sur des champs correspondants aux informations de la carte de crédit, tant au niveau
        /// de leur complétude que de leur format. Si les critères nécessaires sont remplis elle crée l’objet donateur correspondant aux informations personnelles 
        /// fournies par l’utilisateur et affiche les sous-formulaires ayant trait au don.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDonateur_Click(object sender, EventArgs e)
        {
            char typeCarte = 'O';
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
                signalerIncompletude(mskTxtNumeroCarte, "               ", lblNoCredit, lblMessageCredit, "Numéro de carte :");
                
                if (!mskTxtNumeroCarte.MaskCompleted)
                {
                    MessageBox.Show("Veuillez compléter le numéro de la carte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMessageCredit.Text = "* Incomplet";
                    lblMessageCredit.Visible = true;
                    mskTxtNumeroCarte.Focus();
                }
                #endregion
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

                gestionnaireSTE.AjouterDonateur(txtPrenomDonateur.Text, txtNomDonateur.Text, txtCourrielDonateur.Text, mskTxtBoxTel.Text, typeCarte, mskTxtNumeroCarte.Text, dateExpiration, gestionnaireSTE.donateurs.Count);

                //Passage au prochain sous menu
                pnlDon.Visible = true;
                pnlPrix.Visible = true;
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
            dateExpiration = numMois.Value.ToString("00") + "/" + numAnnee.Value.ToString();
            try
            {
                gestionnaireSTE.AjouterDon(dateExpiration, txtIDDon.Text, double.Parse(txtMontant.Text), gestionnaireSTE.dons.Count);
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez utiliser une virgule pour les décimales", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMontant.Focus();
            }
        }

        
        /// <summary>
        /// BtnAjouterComm_Click appelle la fonction qui crée une nouvelle instance de la classe Commanditaire à partir des paramètres fournis par l’utilisateur
        /// via l’interface. Elle est activée par l’événement click du bouton btnAjouterComm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterComm_Click(object sender, EventArgs e)
        {
            if (txtPrenomCommanditaire.Text == "" || txtNomCommanditaire.Text == "")
            {
                signalerIncompletude(txtNomCommanditaire, "", lblNomCommanditaire, lblMessageCommanditaire, "Nom :");
                signalerIncompletude(txtPrenomCommanditaire, "", lblPrenomCommanditaire, lblMessageCommanditaire, "Prénom :");
               
            }
            else
            {
                gestionnaireSTE.AjouterCommanditaire(txtPrenomCommanditaire.Text, txtNomCommanditaire.Text, gestionnaireSTE.commanditaires.Count);
            }
        }

        /// <summary>
        /// BtnAjouterPrix_Click vérifier les champs des prix donnés par les commanditaire et enregistre un objet correspondant dans le tableau approprié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterPrix_Click(object sender, EventArgs e)
        {
            //insister pour que les champs relatifs aux prix soient complets
            if (txtDescription.Text == "" || txtValeurPrix.Text == "" || txtQuantitePrix.Text == "") {

                signalerIncompletude(txtQuantitePrix, "", lblQuatitePrix, lblMessagePrix, "Quantité :");
                signalerIncompletude(txtValeurPrix, "", lblValeur, lblMessagePrix, "Valeur unitaire :");
                signalerIncompletude(txtDescription, "", lblDescPrix, lblMessagePrix, "Description :");
            }
            else
            {
                try
                {
                    gestionnaireSTE.AjouterPrix(txtDescription.Text, double.Parse(txtValeurPrix.Text), int.Parse(txtQuantitePrix.Text), "CMDT098", gestionnaireSTE.prix.Count);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Veuillez utiliser une virgule pour les décimales", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValeurPrix.Focus();
                }
                
            }
            
        }

        /// <summary>
        /// BtnAfficherDonateur_Click affiche la liste des donateurs temporairement stockés par l’application dans la RAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficherDonateur_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDonateurs();
        }

        /// <summary>
        /// BtnAfficheDon_Click affiche tous les dons recueillis durant la session de l’utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficheDon_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherDons();
        }

        /// <summary>
        /// BtnAfficherCommanditaire_Click présente la liste de tous les commanditaires préservés en mémoire vive sous la forme d’une sympatiques chaine de caractères
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = gestionnaireSTE.AfficherCommanditaires();
        }


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
                signalerIncompletude(mskTxtBoxTel, "(   )    -", lblTelephone, lblMessageDonateur, "Téléphone :");
                signalerIncompletude(txtNomDonateur, "", lblNomDonateur, lblMessageDonateur, "Nom :");
                signalerIncompletude(txtPrenomDonateur, "", lblPrenomDonateur, lblMessageDonateur, "Prénom :");
                
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
            }
        }

        /// <summary>
        /// BtnQuitter_Click quitte l’application vers la fenêtre de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
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
            txtRecompense.Text = GestionnaireSTE.AttribuerPrix(double.Parse(txtMontant.Text));
        }


        /// <summary>
        /// Interface_temp_Load Fonction qui gère ce qui doit être fait au moment du chargement de notre formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_temp_Load(object sender, EventArgs e)
        {

        }

        // TODO consulter cet exemple d’utilisation de l’infoBulle
        // TODO bouton désactiver/Activer Infobulle (on pourrait faire un onglet "option de l’interface"  avec ce bouton et le bouton dark mode par exemple)
        private void txtPrenomDonateur_MouseHover(object sender, EventArgs e)
        {
            infoBulle.SetToolTip(txtPrenomDonateur, "Champ obligatoire");
        }

        /// <summary>
        /// signalerIncompletude permet de mettre en évidence un champ de type Textbox obligatoire qui est rester vide
        /// </summary>
        /// <param name="monTxt"></param> le champ dont on teste la complétude
        /// <param name="chaineVide"></param> une chaine de caractère qui correspond au champ laisser intouché (utile surtout pour les maskedTextbox qui ne sont pas vide lorsque rien n’y a été entré)
        /// <param name="monLbl"></param> le label qui identifie monTxt sur le formulaire. On en change la couleur
        /// <param name="monMessage"></param> le label de message que nous affichons si monTxt est vide
        /// <param name="etiquette"></param> une chaine de caractère qui correspond à la valeur attendue de monMessage si le champ est n’est pas vide
        private void signalerIncompletude(Control monTxt, string chaineVide, Control monLbl, Control monMessage, string etiquette){
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
        private void TxtNoir(Control lblAchange, string chaineAchange) {
            lblAchange.ForeColor = Color.Black;
            lblAchange.Text = chaineAchange;
        }

        private void txtPrenomDonateurNoir_Click(object sender, EventArgs e)
        {
            TxtNoir(lblPrenomDonateur, "Prénom :");
        }

        private void txtNomDonateur_Click(object sender, EventArgs e)
        {
            TxtNoir(lblNomDonateur, "Nom :");
        }

        private void txtCourrielDonateur_Click(object sender, EventArgs e)
        {
            TxtNoir(lblCourriel, "Courriel :");
        }

        private void mskTxtNumeroCarte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #region ensemble de fonction qui remette le texte des labels des champs erronés en Noir et qui réinitialise leur valeur
        private void txtPrenomCommanditaire_Click(object sender, EventArgs e)
        {
            TxtNoir(lblPrenomCommanditaire, "Prénom :");
        }

        private void txtNomCommanditaire_Click(object sender, EventArgs e)
        {
            TxtNoir(lblNomCommanditaire, "Nom :");
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            TxtNoir(lblDescPrix, "Description :");
        }

        private void txtValeurPrix_Click(object sender, EventArgs e)
        {
            TxtNoir(lblValeur, "Valeur unitaire :");
        }

        private void txtQuantitePrix_Click(object sender, EventArgs e)
        {
            TxtNoir(lblQuatitePrix, "Quantité :");
        }
        #endregion
    }
}
