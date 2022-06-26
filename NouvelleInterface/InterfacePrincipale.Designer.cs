namespace NouvelleInterface
{
    partial class InterfacePrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabEntrees = new System.Windows.Forms.TabControl();
            this.tabDonateur = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.pnlCarteCredit = new System.Windows.Forms.Panel();
            this.txtBoxCvc = new System.Windows.Forms.TextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtBoxDateExpCarte = new System.Windows.Forms.TextBox();
            this.mskTxtNumeroCarte = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouterDonateur = new System.Windows.Forms.Button();
            this.lblMessageCredit = new System.Windows.Forms.Label();
            this.grRadioCarte = new System.Windows.Forms.GroupBox();
            this.radAmex = new System.Windows.Forms.RadioButton();
            this.radMC = new System.Windows.Forms.RadioButton();
            this.radVisa = new System.Windows.Forms.RadioButton();
            this.lblNoCredit = new System.Windows.Forms.Label();
            this.lblCarteCredit = new System.Windows.Forms.Label();
            this.lblDateExp = new System.Windows.Forms.Label();
            this.pnlPrix = new System.Windows.Forms.Panel();
            this.lblqte = new System.Windows.Forms.Label();
            this.txtRecompense = new System.Windows.Forms.TextBox();
            this.btnCalculRecompense = new System.Windows.Forms.Button();
            this.lblRecompense = new System.Windows.Forms.Label();
            this.pnlDon = new System.Windows.Forms.Panel();
            this.lblIDDon = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtIDDon = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnAjouterDon = new System.Windows.Forms.Button();
            this.lblInfoDon = new System.Windows.Forms.Label();
            this.pnlInfoDonateur = new System.Windows.Forms.Panel();
            this.mskTxtBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.lblMessageDonateur = new System.Windows.Forms.Label();
            this.lblnfoDonateur = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.txtPrenomDonateur = new System.Windows.Forms.TextBox();
            this.lblPrenomDonateur = new System.Windows.Forms.Label();
            this.lblNomDonateur = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.txtNomDonateur = new System.Windows.Forms.TextBox();
            this.txtCourrielDonateur = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.btnAfficherDonateur = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAfficheDon = new System.Windows.Forms.Button();
            this.tabCommanditaire = new System.Windows.Forms.TabPage();
            this.btnAffichePrix = new System.Windows.Forms.Button();
            this.btnAjouterPrix = new System.Windows.Forms.Button();
            this.btnAfficherComm = new System.Windows.Forms.Button();
            this.btnAjouterComm = new System.Windows.Forms.Button();
            this.txtQuatitePrix = new System.Windows.Forms.TextBox();
            this.txtValeurPrix = new System.Windows.Forms.TextBox();
            this.txtNomCommanditaire = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrenomCommanditaire = new System.Windows.Forms.TextBox();
            this.txtIDPrix = new System.Windows.Forms.TextBox();
            this.txtIDCommanditaire = new System.Windows.Forms.TextBox();
            this.lblQuatitePrix = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            this.lblNomCommanditaire = new System.Windows.Forms.Label();
            this.lblDescPrix = new System.Windows.Forms.Label();
            this.lblPrenomCommanditaire = new System.Windows.Forms.Label();
            this.lblInfoPrix = new System.Windows.Forms.Label();
            this.lblIDPrix = new System.Windows.Forms.Label();
            this.lblInfoCommanditaire = new System.Windows.Forms.Label();
            this.lblIDCommanditaire = new System.Windows.Forms.Label();
            this.tabAPropos = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblOlivier = new System.Windows.Forms.Label();
            this.lblCatherine = new System.Windows.Forms.Label();
            this.lblFred = new System.Windows.Forms.Label();
            this.lblAuteur01 = new System.Windows.Forms.Label();
            this.lblInfoProjetSTE = new System.Windows.Forms.Label();
            this.tabEntrees.SuspendLayout();
            this.tabDonateur.SuspendLayout();
            this.pnlCarteCredit.SuspendLayout();
            this.grRadioCarte.SuspendLayout();
            this.pnlPrix.SuspendLayout();
            this.pnlDon.SuspendLayout();
            this.pnlInfoDonateur.SuspendLayout();
            this.tabCommanditaire.SuspendLayout();
            this.tabAPropos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEntrees
            // 
            this.tabEntrees.Controls.Add(this.tabDonateur);
            this.tabEntrees.Controls.Add(this.tabCommanditaire);
            this.tabEntrees.Controls.Add(this.tabAPropos);
            this.tabEntrees.Location = new System.Drawing.Point(32, 13);
            this.tabEntrees.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabEntrees.Name = "tabEntrees";
            this.tabEntrees.SelectedIndex = 0;
            this.tabEntrees.Size = new System.Drawing.Size(1294, 991);
            this.tabEntrees.TabIndex = 1;
            // 
            // tabDonateur
            // 
            this.tabDonateur.Controls.Add(this.textBoxOutput);
            this.tabDonateur.Controls.Add(this.pnlCarteCredit);
            this.tabDonateur.Controls.Add(this.pnlPrix);
            this.tabDonateur.Controls.Add(this.pnlDon);
            this.tabDonateur.Controls.Add(this.pnlInfoDonateur);
            this.tabDonateur.Controls.Add(this.btnAfficherDonateur);
            this.tabDonateur.Controls.Add(this.btnQuitter);
            this.tabDonateur.Controls.Add(this.btnAfficheDon);
            this.tabDonateur.Location = new System.Drawing.Point(4, 29);
            this.tabDonateur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDonateur.Name = "tabDonateur";
            this.tabDonateur.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDonateur.Size = new System.Drawing.Size(1286, 958);
            this.tabDonateur.TabIndex = 0;
            this.tabDonateur.Text = "Donateur";
            this.tabDonateur.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(9, 620);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(610, 316);
            this.textBoxOutput.TabIndex = 0;
            // 
            // pnlCarteCredit
            // 
            this.pnlCarteCredit.Controls.Add(this.txtBoxCvc);
            this.pnlCarteCredit.Controls.Add(this.lblCVC);
            this.pnlCarteCredit.Controls.Add(this.txtBoxDateExpCarte);
            this.pnlCarteCredit.Controls.Add(this.mskTxtNumeroCarte);
            this.pnlCarteCredit.Controls.Add(this.btnAjouterDonateur);
            this.pnlCarteCredit.Controls.Add(this.lblMessageCredit);
            this.pnlCarteCredit.Controls.Add(this.grRadioCarte);
            this.pnlCarteCredit.Controls.Add(this.lblNoCredit);
            this.pnlCarteCredit.Controls.Add(this.lblCarteCredit);
            this.pnlCarteCredit.Controls.Add(this.lblDateExp);
            this.pnlCarteCredit.Location = new System.Drawing.Point(746, 520);
            this.pnlCarteCredit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCarteCredit.Name = "pnlCarteCredit";
            this.pnlCarteCredit.Size = new System.Drawing.Size(491, 417);
            this.pnlCarteCredit.TabIndex = 13;
            this.pnlCarteCredit.Visible = false;
            // 
            // txtBoxCvc
            // 
            this.txtBoxCvc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxCvc.Location = new System.Drawing.Point(319, 216);
            this.txtBoxCvc.MaxLength = 4;
            this.txtBoxCvc.Name = "txtBoxCvc";
            this.txtBoxCvc.PasswordChar = '*';
            this.txtBoxCvc.Size = new System.Drawing.Size(63, 27);
            this.txtBoxCvc.TabIndex = 20;
            this.txtBoxCvc.Tag = "";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(194, 216);
            this.lblCVC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(43, 20);
            this.lblCVC.TabIndex = 19;
            this.lblCVC.Text = "CVC :";
            // 
            // txtBoxDateExpCarte
            // 
            this.txtBoxDateExpCarte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxDateExpCarte.Location = new System.Drawing.Point(319, 173);
            this.txtBoxDateExpCarte.MaxLength = 5;
            this.txtBoxDateExpCarte.Name = "txtBoxDateExpCarte";
            this.txtBoxDateExpCarte.PlaceholderText = "mm/aa";
            this.txtBoxDateExpCarte.Size = new System.Drawing.Size(63, 27);
            this.txtBoxDateExpCarte.TabIndex = 18;
            this.txtBoxDateExpCarte.Tag = "mm/aa";
            // 
            // mskTxtNumeroCarte
            // 
            this.mskTxtNumeroCarte.Location = new System.Drawing.Point(319, 128);
            this.mskTxtNumeroCarte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskTxtNumeroCarte.Mask = "0000 0000 0000 0000";
            this.mskTxtNumeroCarte.Name = "mskTxtNumeroCarte";
            this.mskTxtNumeroCarte.Size = new System.Drawing.Size(157, 27);
            this.mskTxtNumeroCarte.TabIndex = 17;
            this.mskTxtNumeroCarte.Click += new System.EventHandler(this.TxtNumeroCarte_Click);
            this.mskTxtNumeroCarte.Text = "1234123412341234"; // TODO enlever la valeur par défaut juste avant la remise _mskTxtNumeroCarte
            // 
            // btnAjouterDonateur
            // 
            this.btnAjouterDonateur.Location = new System.Drawing.Point(215, 230);
            this.btnAjouterDonateur.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterDonateur.Name = "btnAjouterDonateur";
            this.btnAjouterDonateur.Size = new System.Drawing.Size(189, 34);
            this.btnAjouterDonateur.TabIndex = 10;
            this.btnAjouterDonateur.Text = "Ajouter un Donateur";
            this.btnAjouterDonateur.UseVisualStyleBackColor = true;
            this.btnAjouterDonateur.Click += new System.EventHandler(this.BtnAjouterDonateur_Click);
            // 
            // lblMessageCredit
            // 
            this.lblMessageCredit.AutoSize = true;
            this.lblMessageCredit.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessageCredit.Location = new System.Drawing.Point(246, 268);
            this.lblMessageCredit.Name = "lblMessageCredit";
            this.lblMessageCredit.Size = new System.Drawing.Size(166, 20);
            this.lblMessageCredit.TabIndex = 16;
            this.lblMessageCredit.Text = "* Champs obligatoire(s)";
            this.lblMessageCredit.Visible = false;
            // 
            // grRadioCarte
            // 
            this.grRadioCarte.Controls.Add(this.radAmex);
            this.grRadioCarte.Controls.Add(this.radMC);
            this.grRadioCarte.Controls.Add(this.radVisa);
            this.grRadioCarte.Location = new System.Drawing.Point(109, 44);
            this.grRadioCarte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grRadioCarte.Name = "grRadioCarte";
            this.grRadioCarte.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grRadioCarte.Size = new System.Drawing.Size(367, 67);
            this.grRadioCarte.TabIndex = 0;
            this.grRadioCarte.TabStop = false;
            this.grRadioCarte.Text = "Type de carte";
            // 
            // radAmex
            // 
            this.radAmex.AutoSize = true;
            this.radAmex.Location = new System.Drawing.Point(267, 29);
            this.radAmex.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radAmex.Name = "radAmex";
            this.radAmex.Size = new System.Drawing.Size(68, 24);
            this.radAmex.TabIndex = 2;
            this.radAmex.TabStop = true;
            this.radAmex.Text = "Amex";
            this.radAmex.UseVisualStyleBackColor = true;
            // 
            // radMC
            // 
            this.radMC.AutoSize = true;
            this.radMC.Location = new System.Drawing.Point(147, 29);
            this.radMC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radMC.Name = "radMC";
            this.radMC.Size = new System.Drawing.Size(52, 24);
            this.radMC.TabIndex = 1;
            this.radMC.TabStop = true;
            this.radMC.Text = "MC";
            this.radMC.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            this.radVisa.AutoSize = true;
            this.radVisa.Location = new System.Drawing.Point(22, 22);
            this.radVisa.Checked = true; // TODO enlever la valeur par défaut juste avant la remise _radVisa
            this.radVisa.Margin = new System.Windows.Forms.Padding(4);
            this.radVisa.Name = "radVisa";
            this.radVisa.Size = new System.Drawing.Size(57, 24);
            this.radVisa.TabIndex = 0;
            this.radVisa.TabStop = true;
            this.radVisa.Text = "Visa";
            this.radVisa.UseVisualStyleBackColor = true;
            // 
            // lblNoCredit
            // 
            this.lblNoCredit.AutoSize = true;
            this.lblNoCredit.Location = new System.Drawing.Point(109, 131);
            this.lblNoCredit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNoCredit.Name = "lblNoCredit";
            this.lblNoCredit.Size = new System.Drawing.Size(128, 20);
            this.lblNoCredit.TabIndex = 0;
            this.lblNoCredit.Text = "Numéro de carte :";
            // 
            // lblCarteCredit
            // 
            this.lblCarteCredit.AutoSize = true;
            this.lblCarteCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarteCredit.Location = new System.Drawing.Point(16, 12);
            this.lblCarteCredit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCarteCredit.Name = "lblCarteCredit";
            this.lblCarteCredit.Size = new System.Drawing.Size(138, 18);
            this.lblCarteCredit.TabIndex = 0;
            this.lblCarteCredit.Text = "Informations Don";
            // 
            // lblDateExp
            // 
            this.lblDateExp.AutoSize = true;
            this.lblDateExp.Location = new System.Drawing.Point(109, 176);
            this.lblDateExp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateExp.Name = "lblDateExp";
            this.lblDateExp.Size = new System.Drawing.Size(131, 20);
            this.lblDateExp.TabIndex = 0;
            this.lblDateExp.Text = "Date d’expiration :";
            // 
            // pnlPrix
            // 
            this.pnlPrix.Controls.Add(this.lblqte);
            this.pnlPrix.Controls.Add(this.txtRecompense);
            this.pnlPrix.Controls.Add(this.btnCalculRecompense);
            this.pnlPrix.Controls.Add(this.lblRecompense);
            this.pnlPrix.Location = new System.Drawing.Point(679, 16);
            this.pnlPrix.Name = "pnlPrix";
            this.pnlPrix.Size = new System.Drawing.Size(283, 204);
            this.pnlPrix.TabIndex = 12;
            this.pnlPrix.Visible = false;
            // 
            // lblqte
            // 
            this.lblqte.AutoSize = true;
            this.lblqte.Location = new System.Drawing.Point(33, 132);
            this.lblqte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblqte.Name = "lblqte";
            this.lblqte.Size = new System.Drawing.Size(101, 20);
            this.lblqte.TabIndex = 0;
            this.lblqte.Text = "Récompense :";
            // 
            // txtRecompense
            // 
            this.txtRecompense.Location = new System.Drawing.Point(135, 128);
            this.txtRecompense.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRecompense.Name = "txtRecompense";
            this.txtRecompense.Size = new System.Drawing.Size(118, 27);
            this.txtRecompense.TabIndex = 2;
            // 
            // btnCalculRecompense
            // 
            this.btnCalculRecompense.Location = new System.Drawing.Point(33, 75);
            this.btnCalculRecompense.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCalculRecompense.Name = "btnCalculRecompense";
            this.btnCalculRecompense.Size = new System.Drawing.Size(221, 35);
            this.btnCalculRecompense.TabIndex = 0;
            this.btnCalculRecompense.Text = "Afficher la récompense";
            this.btnCalculRecompense.UseVisualStyleBackColor = true;
            this.btnCalculRecompense.Click += new System.EventHandler(this.BtnCalculRecompense_Click);
            // 
            // lblRecompense
            // 
            this.lblRecompense.AutoSize = true;
            this.lblRecompense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecompense.Location = new System.Drawing.Point(14, 11);
            this.lblRecompense.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecompense.Name = "lblRecompense";
            this.lblRecompense.Size = new System.Drawing.Size(107, 18);
            this.lblRecompense.TabIndex = 0;
            this.lblRecompense.Text = "Récompense";
            // 
            // pnlDon
            // 
            this.pnlDon.Controls.Add(this.lblIDDon);
            this.pnlDon.Controls.Add(this.lblMontant);
            this.pnlDon.Controls.Add(this.txtIDDon);
            this.pnlDon.Controls.Add(this.txtMontant);
            this.pnlDon.Controls.Add(this.btnAjouterDon);
            this.pnlDon.Controls.Add(this.lblInfoDon);
            this.pnlDon.Location = new System.Drawing.Point(39, 380);
            this.pnlDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDon.Name = "pnlDon";
            this.pnlDon.Size = new System.Drawing.Size(283, 204);
            this.pnlDon.TabIndex = 12;
            this.pnlDon.Visible = false;
            // 
            // lblIDDon
            // 
            this.lblIDDon.AutoSize = true;
            this.lblIDDon.Location = new System.Drawing.Point(24, 51);
            this.lblIDDon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIDDon.Name = "lblIDDon";
            this.lblIDDon.Size = new System.Drawing.Size(61, 20);
            this.lblIDDon.TabIndex = 0;
            this.lblIDDon.Text = "ID don :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(24, 96);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(72, 20);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant :";
            // 
            // txtIDDon
            // 
            this.txtIDDon.Location = new System.Drawing.Point(114, 45);
            this.txtIDDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDDon.Name = "txtIDDon";
            this.txtIDDon.Size = new System.Drawing.Size(142, 27);
            this.txtIDDon.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(114, 92);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(125, 23);
            this.txtMontant.Text = "2500"; // TODO enlever la valeur par défaut juste avant la remise _txtMontant
            this.txtMontant.TabIndex = 7;
            // 
            // btnAjouterDon
            // 
            this.btnAjouterDon.Location = new System.Drawing.Point(114, 132);
            this.btnAjouterDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAjouterDon.Name = "btnAjouterDon";
            this.btnAjouterDon.Size = new System.Drawing.Size(143, 45);
            this.btnAjouterDon.TabIndex = 8;
            this.btnAjouterDon.Text = "Ajouter un don";
            this.btnAjouterDon.UseVisualStyleBackColor = true;
            this.btnAjouterDon.Click += new System.EventHandler(this.BtnAjouterDon_Click);
            // 
            // lblInfoDon
            // 
            this.lblInfoDon.AutoSize = true;
            this.lblInfoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoDon.Location = new System.Drawing.Point(16, 15);
            this.lblInfoDon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfoDon.Name = "lblInfoDon";
            this.lblInfoDon.Size = new System.Drawing.Size(138, 18);
            this.lblInfoDon.TabIndex = 0;
            this.lblInfoDon.Text = "Informations Don";
            // 
            // pnlInfoDonateur
            // 
            this.pnlInfoDonateur.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfoDonateur.Controls.Add(this.mskTxtBoxTel);
            this.pnlInfoDonateur.Controls.Add(this.lblMessageDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblnfoDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblID);
            this.pnlInfoDonateur.Controls.Add(this.txtID);
            this.pnlInfoDonateur.Controls.Add(this.btnSuivant);
            this.pnlInfoDonateur.Controls.Add(this.txtPrenomDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblPrenomDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblNomDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblCourriel);
            this.pnlInfoDonateur.Controls.Add(this.txtNomDonateur);
            this.pnlInfoDonateur.Controls.Add(this.txtCourrielDonateur);
            this.pnlInfoDonateur.Controls.Add(this.lblTelephone);
            this.pnlInfoDonateur.Location = new System.Drawing.Point(39, 16);
            this.pnlInfoDonateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlInfoDonateur.Name = "pnlInfoDonateur";
            this.pnlInfoDonateur.Size = new System.Drawing.Size(581, 321);
            this.pnlInfoDonateur.TabIndex = 3;
            // 
            // mskTxtBoxTel
            // 
            this.mskTxtBoxTel.Location = new System.Drawing.Point(129, 245);
            this.mskTxtBoxTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTxtBoxTel.Mask = "\\(000\\) 000\\-0000";
            this.mskTxtBoxTel.Name = "mskTxtBoxTel";
            this.mskTxtBoxTel.Size = new System.Drawing.Size(191, 27);
            this.mskTxtBoxTel.TabIndex = 17;
            this.mskTxtBoxTel.Text = "5141112222";// TODO enlever la valeur par défaut juste avant la remise _msktxtBoxTel
            this.mskTxtBoxTel.Click += new System.EventHandler(this.MskTxtBoxTel_Click);
            // 
            // lblMessageDonateur
            // 
            this.lblMessageDonateur.AutoSize = true;
            this.lblMessageDonateur.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessageDonateur.Location = new System.Drawing.Point(129, 289);
            this.lblMessageDonateur.Name = "lblMessageDonateur";
            this.lblMessageDonateur.Size = new System.Drawing.Size(166, 20);
            this.lblMessageDonateur.TabIndex = 16;
            this.lblMessageDonateur.Text = "* Champs obligatoire(s)";
            this.lblMessageDonateur.Visible = false;
            // 
            // lblnfoDonateur
            // 
            this.lblnfoDonateur.AutoSize = true;
            this.lblnfoDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnfoDonateur.Location = new System.Drawing.Point(16, 16);
            this.lblnfoDonateur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnfoDonateur.Name = "lblnfoDonateur";
            this.lblnfoDonateur.Size = new System.Drawing.Size(176, 18);
            this.lblnfoDonateur.TabIndex = 14;
            this.lblnfoDonateur.Text = "Informations Donateur";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(38, 79);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 75);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 27);
            this.txtID.TabIndex = 1;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(401, 231);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(115, 45);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnCacher_Click);
            // 
            // txtPrenomDonateur
            // 
            this.txtPrenomDonateur.Location = new System.Drawing.Point(129, 117);
            this.txtPrenomDonateur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrenomDonateur.Name = "txtPrenomDonateur";
            this.txtPrenomDonateur.Size = new System.Drawing.Size(191, 27);
            this.txtPrenomDonateur.TabIndex = 2;
            this.txtPrenomDonateur.Text = "Fredolicath"; // TODO enlever la valeur par défaut juste avant la remise _txtPrenomDonateur
            // 
            // lblPrenomDonateur
            // 
            this.lblPrenomDonateur.AutoSize = true;
            this.lblPrenomDonateur.Location = new System.Drawing.Point(38, 121);
            this.lblPrenomDonateur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrenomDonateur.Name = "lblPrenomDonateur";
            this.lblPrenomDonateur.Size = new System.Drawing.Size(67, 20);
            this.lblPrenomDonateur.TabIndex = 0;
            this.lblPrenomDonateur.Text = "Prénom :";
            // 
            // lblNomDonateur
            // 
            this.lblNomDonateur.AutoSize = true;
            this.lblNomDonateur.Location = new System.Drawing.Point(38, 164);
            this.lblNomDonateur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomDonateur.Name = "lblNomDonateur";
            this.lblNomDonateur.Size = new System.Drawing.Size(53, 20);
            this.lblNomDonateur.TabIndex = 0;
            this.lblNomDonateur.Text = "Nom : ";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(38, 207);
            this.lblCourriel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(68, 20);
            this.lblCourriel.TabIndex = 0;
            this.lblCourriel.Text = "Courriel :";
            // 
            // txtNomDonateur
            // 
            this.txtNomDonateur.Location = new System.Drawing.Point(129, 160);
            this.txtNomDonateur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNomDonateur.Name = "txtNomDonateur";
            this.txtNomDonateur.Size = new System.Drawing.Size(191, 27);
            this.txtNomDonateur.TabIndex = 3;
            this.txtNomDonateur.Text = "Gofaimond"; // TODO enlever la valeur par défaut juste avant la remise _txtNomDonateur
            // 
            // txtCourrielDonateur
            // 
            this.txtCourrielDonateur.Location = new System.Drawing.Point(129, 203);
            this.txtCourrielDonateur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCourrielDonateur.Name = "txtCourrielDonateur";
            this.txtCourrielDonateur.PlaceholderText = "aaaaaa@domain.com";
            this.txtCourrielDonateur.Size = new System.Drawing.Size(191, 27);
            this.txtCourrielDonateur.TabIndex = 4;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(38, 249);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(85, 20);
            this.lblTelephone.TabIndex = 0;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // btnAfficherDonateur
            // 
            this.btnAfficherDonateur.Location = new System.Drawing.Point(970, 200);
            this.btnAfficherDonateur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAfficherDonateur.Name = "btnAfficherDonateur";
            this.btnAfficherDonateur.Size = new System.Drawing.Size(216, 45);
            this.btnAfficherDonateur.TabIndex = 11;
            this.btnAfficherDonateur.Text = "Afficher les donateurs";
            this.btnAfficherDonateur.UseVisualStyleBackColor = true;
            this.btnAfficherDonateur.Click += new System.EventHandler(this.BtnAfficherDonateur_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(970, 293);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(216, 45);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // btnAfficheDon
            // 
            this.btnAfficheDon.Location = new System.Drawing.Point(970, 144);
            this.btnAfficheDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAfficheDon.Name = "btnAfficheDon";
            this.btnAfficheDon.Size = new System.Drawing.Size(216, 45);
            this.btnAfficheDon.TabIndex = 9;
            this.btnAfficheDon.Text = "Afficher les dons";
            this.btnAfficheDon.UseVisualStyleBackColor = true;
            this.btnAfficheDon.Click += new System.EventHandler(this.BtnAfficheDon_Click);
            // 
            // tabCommanditaire
            // 
            this.tabCommanditaire.Controls.Add(this.btnAffichePrix);
            this.tabCommanditaire.Controls.Add(this.btnAjouterPrix);
            this.tabCommanditaire.Controls.Add(this.btnAfficherComm);
            this.tabCommanditaire.Controls.Add(this.btnAjouterComm);
            this.tabCommanditaire.Controls.Add(this.txtQuatitePrix);
            this.tabCommanditaire.Controls.Add(this.txtValeurPrix);
            this.tabCommanditaire.Controls.Add(this.txtNomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.txtDescription);
            this.tabCommanditaire.Controls.Add(this.txtPrenomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.txtIDPrix);
            this.tabCommanditaire.Controls.Add(this.txtIDCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblQuatitePrix);
            this.tabCommanditaire.Controls.Add(this.lblValeur);
            this.tabCommanditaire.Controls.Add(this.lblNomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblDescPrix);
            this.tabCommanditaire.Controls.Add(this.lblPrenomCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblInfoPrix);
            this.tabCommanditaire.Controls.Add(this.lblIDPrix);
            this.tabCommanditaire.Controls.Add(this.lblInfoCommanditaire);
            this.tabCommanditaire.Controls.Add(this.lblIDCommanditaire);
            this.tabCommanditaire.Location = new System.Drawing.Point(4, 29);
            this.tabCommanditaire.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabCommanditaire.Name = "tabCommanditaire";
            this.tabCommanditaire.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCommanditaire.Size = new System.Drawing.Size(1286, 958);
            this.tabCommanditaire.TabIndex = 1;
            this.tabCommanditaire.Text = "Commanditaires";
            this.tabCommanditaire.UseVisualStyleBackColor = true;
            // 
            // btnAffichePrix
            // 
            this.btnAffichePrix.Location = new System.Drawing.Point(682, 399);
            this.btnAffichePrix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAffichePrix.Name = "btnAffichePrix";
            this.btnAffichePrix.Size = new System.Drawing.Size(182, 41);
            this.btnAffichePrix.TabIndex = 14;
            this.btnAffichePrix.Text = "Afficher les prix";
            this.btnAffichePrix.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPrix
            // 
            this.btnAjouterPrix.Location = new System.Drawing.Point(682, 336);
            this.btnAjouterPrix.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAjouterPrix.Name = "btnAjouterPrix";
            this.btnAjouterPrix.Size = new System.Drawing.Size(182, 41);
            this.btnAjouterPrix.TabIndex = 15;
            this.btnAjouterPrix.Text = "Ajouter un prix";
            this.btnAjouterPrix.UseVisualStyleBackColor = true;
            this.btnAjouterPrix.Click += new System.EventHandler(this.BtnAjouterPrix_Click);
            // 
            // btnAfficherComm
            // 
            this.btnAfficherComm.Location = new System.Drawing.Point(166, 369);
            this.btnAfficherComm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAfficherComm.Name = "btnAfficherComm";
            this.btnAfficherComm.Size = new System.Drawing.Size(208, 55);
            this.btnAfficherComm.TabIndex = 16;
            this.btnAfficherComm.Text = "Afficher les Commanditaires";
            this.btnAfficherComm.UseVisualStyleBackColor = true;
            this.btnAfficherComm.Click += new System.EventHandler(this.BtnAfficherCommanditaire_Click);
            // 
            // btnAjouterComm
            // 
            this.btnAjouterComm.Location = new System.Drawing.Point(166, 280);
            this.btnAjouterComm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAjouterComm.Name = "btnAjouterComm";
            this.btnAjouterComm.Size = new System.Drawing.Size(208, 55);
            this.btnAjouterComm.TabIndex = 17;
            this.btnAjouterComm.Text = "Ajouter un Commanditaire";
            this.btnAjouterComm.UseVisualStyleBackColor = true;
            this.btnAjouterComm.Click += new System.EventHandler(this.BtnAjouterComm_Click);
            // 
            // txtQuatitePrix
            // 
            this.txtQuatitePrix.Location = new System.Drawing.Point(673, 275);
            this.txtQuatitePrix.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtQuatitePrix.Name = "txtQuatitePrix";
            this.txtQuatitePrix.Size = new System.Drawing.Size(191, 27);
            this.txtQuatitePrix.TabIndex = 10;
            // 
            // txtValeurPrix
            // 
            this.txtValeurPrix.Location = new System.Drawing.Point(673, 229);
            this.txtValeurPrix.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtValeurPrix.Name = "txtValeurPrix";
            this.txtValeurPrix.Size = new System.Drawing.Size(191, 27);
            this.txtValeurPrix.TabIndex = 11;
            // 
            // txtNomCommanditaire
            // 
            this.txtNomCommanditaire.Location = new System.Drawing.Point(183, 229);
            this.txtNomCommanditaire.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNomCommanditaire.Name = "txtNomCommanditaire";
            this.txtNomCommanditaire.Size = new System.Drawing.Size(191, 27);
            this.txtNomCommanditaire.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(673, 183);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 27);
            this.txtDescription.TabIndex = 12;
            // 
            // txtPrenomCommanditaire
            // 
            this.txtPrenomCommanditaire.Location = new System.Drawing.Point(183, 183);
            this.txtPrenomCommanditaire.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrenomCommanditaire.Name = "txtPrenomCommanditaire";
            this.txtPrenomCommanditaire.Size = new System.Drawing.Size(191, 27);
            this.txtPrenomCommanditaire.TabIndex = 12;
            // 
            // txtIDPrix
            // 
            this.txtIDPrix.Location = new System.Drawing.Point(673, 137);
            this.txtIDPrix.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDPrix.Name = "txtIDPrix";
            this.txtIDPrix.Size = new System.Drawing.Size(191, 27);
            this.txtIDPrix.TabIndex = 13;
            // 
            // txtIDCommanditaire
            // 
            this.txtIDCommanditaire.Location = new System.Drawing.Point(183, 137);
            this.txtIDCommanditaire.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDCommanditaire.Name = "txtIDCommanditaire";
            this.txtIDCommanditaire.Size = new System.Drawing.Size(191, 27);
            this.txtIDCommanditaire.TabIndex = 13;
            // 
            // lblQuatitePrix
            // 
            this.lblQuatitePrix.AutoSize = true;
            this.lblQuatitePrix.Location = new System.Drawing.Point(560, 280);
            this.lblQuatitePrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuatitePrix.Name = "lblQuatitePrix";
            this.lblQuatitePrix.Size = new System.Drawing.Size(73, 20);
            this.lblQuatitePrix.TabIndex = 4;
            this.lblQuatitePrix.Text = "Quantité :";
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(560, 233);
            this.lblValeur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(111, 20);
            this.lblValeur.TabIndex = 5;
            this.lblValeur.Text = "Valeur unitaire :";
            // 
            // lblNomCommanditaire
            // 
            this.lblNomCommanditaire.AutoSize = true;
            this.lblNomCommanditaire.Location = new System.Drawing.Point(120, 236);
            this.lblNomCommanditaire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomCommanditaire.Name = "lblNomCommanditaire";
            this.lblNomCommanditaire.Size = new System.Drawing.Size(53, 20);
            this.lblNomCommanditaire.TabIndex = 5;
            this.lblNomCommanditaire.Text = "Nom : ";
            // 
            // lblDescPrix
            // 
            this.lblDescPrix.AutoSize = true;
            this.lblDescPrix.Location = new System.Drawing.Point(560, 188);
            this.lblDescPrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescPrix.Name = "lblDescPrix";
            this.lblDescPrix.Size = new System.Drawing.Size(92, 20);
            this.lblDescPrix.TabIndex = 6;
            this.lblDescPrix.Text = "Description :";
            // 
            // lblPrenomCommanditaire
            // 
            this.lblPrenomCommanditaire.AutoSize = true;
            this.lblPrenomCommanditaire.Location = new System.Drawing.Point(106, 189);
            this.lblPrenomCommanditaire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrenomCommanditaire.Name = "lblPrenomCommanditaire";
            this.lblPrenomCommanditaire.Size = new System.Drawing.Size(67, 20);
            this.lblPrenomCommanditaire.TabIndex = 6;
            this.lblPrenomCommanditaire.Text = "Prénom :";
            // 
            // lblInfoPrix
            // 
            this.lblInfoPrix.AutoSize = true;
            this.lblInfoPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoPrix.Location = new System.Drawing.Point(560, 87);
            this.lblInfoPrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfoPrix.Name = "lblInfoPrix";
            this.lblInfoPrix.Size = new System.Drawing.Size(134, 18);
            this.lblInfoPrix.TabIndex = 7;
            this.lblInfoPrix.Text = "Informations prix";
            // 
            // lblIDPrix
            // 
            this.lblIDPrix.AutoSize = true;
            this.lblIDPrix.Location = new System.Drawing.Point(560, 141);
            this.lblIDPrix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIDPrix.Name = "lblIDPrix";
            this.lblIDPrix.Size = new System.Drawing.Size(31, 20);
            this.lblIDPrix.TabIndex = 8;
            this.lblIDPrix.Text = "ID :";
            // 
            // lblInfoCommanditaire
            // 
            this.lblInfoCommanditaire.AutoSize = true;
            this.lblInfoCommanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoCommanditaire.Location = new System.Drawing.Point(69, 87);
            this.lblInfoCommanditaire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfoCommanditaire.Name = "lblInfoCommanditaire";
            this.lblInfoCommanditaire.Size = new System.Drawing.Size(221, 18);
            this.lblInfoCommanditaire.TabIndex = 7;
            this.lblInfoCommanditaire.Text = "Informations Commanditaire";
            // 
            // lblIDCommanditaire
            // 
            this.lblIDCommanditaire.AutoSize = true;
            this.lblIDCommanditaire.Location = new System.Drawing.Point(142, 144);
            this.lblIDCommanditaire.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIDCommanditaire.Name = "lblIDCommanditaire";
            this.lblIDCommanditaire.Size = new System.Drawing.Size(31, 20);
            this.lblIDCommanditaire.TabIndex = 8;
            this.lblIDCommanditaire.Text = "ID :";
            // 
            // tabAPropos
            // 
            this.tabAPropos.Controls.Add(this.richTextBox1);
            this.tabAPropos.Controls.Add(this.lblOlivier);
            this.tabAPropos.Controls.Add(this.lblCatherine);
            this.tabAPropos.Controls.Add(this.lblFred);
            this.tabAPropos.Controls.Add(this.lblAuteur01);
            this.tabAPropos.Controls.Add(this.lblInfoProjetSTE);
            this.tabAPropos.Location = new System.Drawing.Point(4, 29);
            this.tabAPropos.Name = "tabAPropos";
            this.tabAPropos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAPropos.Size = new System.Drawing.Size(1286, 958);
            this.tabAPropos.TabIndex = 2;
            this.tabAPropos.Text = "À propros";
            this.tabAPropos.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 251);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lblOlivier
            // 
            this.lblOlivier.AutoSize = true;
            this.lblOlivier.Location = new System.Drawing.Point(94, 147);
            this.lblOlivier.Name = "lblOlivier";
            this.lblOlivier.Size = new System.Drawing.Size(119, 20);
            this.lblOlivier.TabIndex = 0;
            this.lblOlivier.Text = "Olivier Raymond";
            // 
            // lblCatherine
            // 
            this.lblCatherine.AutoSize = true;
            this.lblCatherine.Location = new System.Drawing.Point(94, 120);
            this.lblCatherine.Name = "lblCatherine";
            this.lblCatherine.Size = new System.Drawing.Size(116, 20);
            this.lblCatherine.TabIndex = 0;
            this.lblCatherine.Text = "Catherine Godin";
            // 
            // lblFred
            // 
            this.lblFred.AutoSize = true;
            this.lblFred.Location = new System.Drawing.Point(94, 95);
            this.lblFred.Name = "lblFred";
            this.lblFred.Size = new System.Drawing.Size(109, 20);
            this.lblFred.TabIndex = 0;
            this.lblFred.Text = "Frédérick Faidit";
            // 
            // lblAuteur01
            // 
            this.lblAuteur01.AutoSize = true;
            this.lblAuteur01.Location = new System.Drawing.Point(48, 69);
            this.lblAuteur01.Name = "lblAuteur01";
            this.lblAuteur01.Size = new System.Drawing.Size(66, 20);
            this.lblAuteur01.TabIndex = 0;
            this.lblAuteur01.Text = "Auteurs :";
            // 
            // lblInfoProjetSTE
            // 
            this.lblInfoProjetSTE.AutoSize = true;
            this.lblInfoProjetSTE.Location = new System.Drawing.Point(55, 48);
            this.lblInfoProjetSTE.Name = "lblInfoProjetSTE";
            this.lblInfoProjetSTE.Size = new System.Drawing.Size(63, 20);
            this.lblInfoProjetSTE.TabIndex = 0;
            this.lblInfoProjetSTE.Text = "STE v1.0";
            // 
            // InterfacePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 1024);
            this.Controls.Add(this.tabEntrees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfacePrincipale";
            this.Text = "Form2";
            this.tabEntrees.ResumeLayout(false);
            this.tabDonateur.ResumeLayout(false);
            this.tabDonateur.PerformLayout();
            this.pnlCarteCredit.ResumeLayout(false);
            this.pnlCarteCredit.PerformLayout();
            this.grRadioCarte.ResumeLayout(false);
            this.grRadioCarte.PerformLayout();
            this.pnlPrix.ResumeLayout(false);
            this.pnlPrix.PerformLayout();
            this.pnlDon.ResumeLayout(false);
            this.pnlDon.PerformLayout();
            this.pnlInfoDonateur.ResumeLayout(false);
            this.pnlInfoDonateur.PerformLayout();
            this.tabCommanditaire.ResumeLayout(false);
            this.tabCommanditaire.PerformLayout();
            this.tabAPropos.ResumeLayout(false);
            this.tabAPropos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabEntrees;
        private TabPage tabDonateur;
        private TabPage tabCommanditaire;
        private Button btnAfficherDonateur;
        private Button btnAjouterDonateur;
        private Button btnAfficheDon;
        private Button btnAjouterDon;
        private GroupBox grRadioCarte;
        private RadioButton radAmex;
        private RadioButton radMC;
        private RadioButton radVisa;
        private Label lblNoCredit;
        private Label lblDateExp;
        private TextBox txtMontant;
        private TextBox txtIDDon;
        private TextBox txtCourrielDonateur;
        private TextBox txtNomDonateur;
        private TextBox txtPrenomDonateur;
        private TextBox txtID;
        private Label lblMontant;
        private Label lblTelephone;
        private Label lblCourriel;
        private Label lblIDDon;
        private Label lblNomDonateur;
        private Label lblPrenomDonateur;
        private Label lblInfoDon;
        private Label lblnfoDonateur;
        private Label lblID;
        private TextBox textBoxOutput;
        private Button btnQuitter;
        private Button btnAffichePrix;
        private Button btnAjouterPrix;
        private Button btnAfficherComm;
        private Button btnAjouterComm;
        private TextBox txtQuatitePrix;
        private TextBox txtValeurPrix;
        private TextBox txtNomCommanditaire;
        private TextBox txtDescription;
        private TextBox txtPrenomCommanditaire;
        private TextBox txtIDPrix;
        private TextBox txtIDCommanditaire;
        private Label lblQuatitePrix;
        private Label lblValeur;
        private Label lblNomCommanditaire;
        private Label lblDescPrix;
        private Label lblPrenomCommanditaire;
        private Label lblInfoPrix;
        private Label lblIDPrix;
        private Label lblInfoCommanditaire;
        private Label lblIDCommanditaire;
        private Label lblInfoProjetSTE;
        private Panel pnlInfoDonateur;
        private Button btnSuivant;
        private Panel pnlDon;
        private Label lblMessageDonateur;
        private Label lblMessageCredit;
        private Panel pnlCarteCredit;
        private Label lblCarteCredit;
        private Panel pnlPrix;
        private Label lblRecompense;
        private Label lblqte;
        private TextBox txtRecompense;
        private Button btnCalculRecompense;
        private TabPage tabAPropos;
        private RichTextBox richTextBox1;
        private Label lblOlivier;
        private Label lblCatherine;
        private Label lblFred;
        private Label lblAuteur01;
        private MaskedTextBox mskTxtNumeroCarte;
        private MaskedTextBox mskTxtBoxTel;
        private TextBox txtBoxDateExpCarte;
        private TextBox txtBoxCvc;
        private Label lblCVC;
    }
}