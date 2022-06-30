namespace NouvelleInterface
{
    partial class Accueil
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
            System.Windows.Forms.Label txtAccueil;
            System.Windows.Forms.Label txtAccueil2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.logoEcoHor = new System.Windows.Forms.PictureBox();
            this.panelAccueil = new System.Windows.Forms.Panel();
            this.btnApropos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picArbre01 = new System.Windows.Forms.PictureBox();
            this.picArbre02 = new System.Windows.Forms.PictureBox();
            this.picArbre03 = new System.Windows.Forms.PictureBox();
            this.picArbre04 = new System.Windows.Forms.PictureBox();
            this.picArbre05 = new System.Windows.Forms.PictureBox();
            this.picArbre06 = new System.Windows.Forms.PictureBox();
            this.cadreMontant = new System.Windows.Forms.Panel();
            this.symboleDollar = new System.Windows.Forms.Label();
            this.txtAccueilDons = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.contourMontant = new System.Windows.Forms.Panel();
            this.txtObjectif = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            txtAccueil = new System.Windows.Forms.Label();
            txtAccueil2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoEcoHor)).BeginInit();
            this.panelAccueil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre06)).BeginInit();
            this.cadreMontant.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccueil
            // 
            txtAccueil.AutoSize = true;
            txtAccueil.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            txtAccueil.Location = new System.Drawing.Point(48, 392);
            txtAccueil.Name = "txtAccueil";
            txtAccueil.Size = new System.Drawing.Size(406, 35);
            txtAccueil.TabIndex = 1;
            txtAccueil.Text = "Votre don fait une différence ! ";
            txtAccueil.UseMnemonic = false;
            // 
            // txtAccueil2
            // 
            txtAccueil2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAccueil2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            txtAccueil2.Location = new System.Drawing.Point(48, 454);
            txtAccueil2.Name = "txtAccueil2";
            txtAccueil2.Size = new System.Drawing.Size(403, 138);
            txtAccueil2.TabIndex = 2;
            txtAccueil2.Text = "Faites GRANDIR cet arbre \r\net collaborez à la \r\nsauvegarde de \r\nla planète !";
            txtAccueil2.UseMnemonic = false;
            txtAccueil2.Click += new System.EventHandler(this.txtAccueil2_Click);
            // 
            // logoEcoHor
            // 
            this.logoEcoHor.BackColor = System.Drawing.Color.Transparent;
            this.logoEcoHor.Image = global::NouvelleInterface.Properties.Resources.Logo2_150ppi;
            this.logoEcoHor.Location = new System.Drawing.Point(52, 72);
            this.logoEcoHor.Name = "logoEcoHor";
            this.logoEcoHor.Size = new System.Drawing.Size(368, 72);
            this.logoEcoHor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEcoHor.TabIndex = 0;
            this.logoEcoHor.TabStop = false;
            // 
            // panelAccueil
            // 
            this.panelAccueil.BackColor = System.Drawing.Color.Transparent;
            this.panelAccueil.BackgroundImage = global::NouvelleInterface.Properties.Resources.pannelAccueil;
            this.panelAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAccueil.Controls.Add(this.btnApropos);
            this.panelAccueil.Controls.Add(txtAccueil2);
            this.panelAccueil.Controls.Add(this.panel1);
            this.panelAccueil.Controls.Add(txtAccueil);
            this.panelAccueil.Controls.Add(this.cadreMontant);
            this.panelAccueil.Controls.Add(this.txtObjectif);
            this.panelAccueil.Controls.Add(this.btnInscription);
            this.panelAccueil.Controls.Add(this.logoEcoHor);
            this.panelAccueil.Font = new System.Drawing.Font("Bahnschrift", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelAccueil.Location = new System.Drawing.Point(86, 56);
            this.panelAccueil.Name = "panelAccueil";
            this.panelAccueil.Size = new System.Drawing.Size(1010, 781);
            this.panelAccueil.TabIndex = 1;
            // 
            // btnApropos
            // 
            this.btnApropos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApropos.FlatAppearance.BorderSize = 0;
            this.btnApropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApropos.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApropos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.btnApropos.Location = new System.Drawing.Point(393, 657);
            this.btnApropos.Name = "btnApropos";
            this.btnApropos.Size = new System.Drawing.Size(167, 43);
            this.btnApropos.TabIndex = 8;
            this.btnApropos.Text = "À propos";
            this.btnApropos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picArbre01);
            this.panel1.Controls.Add(this.picArbre02);
            this.panel1.Controls.Add(this.picArbre03);
            this.panel1.Controls.Add(this.picArbre04);
            this.panel1.Controls.Add(this.picArbre05);
            this.panel1.Controls.Add(this.picArbre06);
            this.panel1.Location = new System.Drawing.Point(737, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 290);
            this.panel1.TabIndex = 7;
            // 
            // picArbre01
            // 
            this.picArbre01.Image = global::NouvelleInterface.Properties.Resources.Arbre1;
            this.picArbre01.Location = new System.Drawing.Point(68, 202);
            this.picArbre01.Name = "picArbre01";
            this.picArbre01.Size = new System.Drawing.Size(54, 88);
            this.picArbre01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArbre01.TabIndex = 0;
            this.picArbre01.TabStop = false;
            // 
            // picArbre02
            // 
            this.picArbre02.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picArbre02.Image = global::NouvelleInterface.Properties.Resources.Arbre2;
            this.picArbre02.Location = new System.Drawing.Point(53, 156);
            this.picArbre02.Name = "picArbre02";
            this.picArbre02.Size = new System.Drawing.Size(96, 134);
            this.picArbre02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbre02.TabIndex = 0;
            this.picArbre02.TabStop = false;
            this.picArbre02.Visible = false;
            // 
            // picArbre03
            // 
            this.picArbre03.Image = global::NouvelleInterface.Properties.Resources.Arbre3;
            this.picArbre03.Location = new System.Drawing.Point(43, 119);
            this.picArbre03.Name = "picArbre03";
            this.picArbre03.Size = new System.Drawing.Size(117, 171);
            this.picArbre03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbre03.TabIndex = 0;
            this.picArbre03.TabStop = false;
            this.picArbre03.Visible = false;
            // 
            // picArbre04
            // 
            this.picArbre04.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picArbre04.Image = global::NouvelleInterface.Properties.Resources.Arbre4;
            this.picArbre04.Location = new System.Drawing.Point(34, 79);
            this.picArbre04.Name = "picArbre04";
            this.picArbre04.Size = new System.Drawing.Size(157, 211);
            this.picArbre04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbre04.TabIndex = 0;
            this.picArbre04.TabStop = false;
            this.picArbre04.Visible = false;
            // 
            // picArbre05
            // 
            this.picArbre05.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picArbre05.Image = global::NouvelleInterface.Properties.Resources.Arbre5;
            this.picArbre05.Location = new System.Drawing.Point(10, 45);
            this.picArbre05.Name = "picArbre05";
            this.picArbre05.Size = new System.Drawing.Size(203, 245);
            this.picArbre05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbre05.TabIndex = 0;
            this.picArbre05.TabStop = false;
            this.picArbre05.Visible = false;
            // 
            // picArbre06
            // 
            this.picArbre06.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picArbre06.Image = global::NouvelleInterface.Properties.Resources.Arbre6;
            this.picArbre06.Location = new System.Drawing.Point(0, 0);
            this.picArbre06.Name = "picArbre06";
            this.picArbre06.Size = new System.Drawing.Size(221, 290);
            this.picArbre06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArbre06.TabIndex = 0;
            this.picArbre06.TabStop = false;
            this.picArbre06.Visible = false;
            // 
            // cadreMontant
            // 
            this.cadreMontant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadreMontant.AutoSize = true;
            this.cadreMontant.Controls.Add(this.symboleDollar);
            this.cadreMontant.Controls.Add(this.txtAccueilDons);
            this.cadreMontant.Controls.Add(this.txtMontant);
            this.cadreMontant.Controls.Add(this.contourMontant);
            this.cadreMontant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.cadreMontant.Location = new System.Drawing.Point(104, 205);
            this.cadreMontant.Name = "cadreMontant";
            this.cadreMontant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cadreMontant.Size = new System.Drawing.Size(802, 108);
            this.cadreMontant.TabIndex = 6;
            // 
            // symboleDollar
            // 
            this.symboleDollar.AutoSize = true;
            this.symboleDollar.BackColor = System.Drawing.Color.Transparent;
            this.symboleDollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symboleDollar.Font = new System.Drawing.Font("Bahnschrift", 41F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.symboleDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.symboleDollar.Location = new System.Drawing.Point(670, 17);
            this.symboleDollar.Name = "symboleDollar";
            this.symboleDollar.Size = new System.Drawing.Size(60, 66);
            this.symboleDollar.TabIndex = 5;
            this.symboleDollar.Text = "$";
            this.symboleDollar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.symboleDollar.UseMnemonic = false;
            // 
            // txtAccueilDons
            // 
            this.txtAccueilDons.AutoSize = true;
            this.txtAccueilDons.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccueilDons.Location = new System.Drawing.Point(82, 24);
            this.txtAccueilDons.Name = "txtAccueilDons";
            this.txtAccueilDons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAccueilDons.Size = new System.Drawing.Size(243, 48);
            this.txtAccueilDons.TabIndex = 3;
            this.txtAccueilDons.Text = "Dons reçus :";
            this.txtAccueilDons.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtAccueilDons.UseMnemonic = false;
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.White;
            this.txtMontant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontant.Font = new System.Drawing.Font("Bahnschrift", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMontant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.txtMontant.HideSelection = false;
            this.txtMontant.Location = new System.Drawing.Point(374, 14);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.ReadOnly = true;
            this.txtMontant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMontant.Size = new System.Drawing.Size(285, 73);
            this.txtMontant.TabIndex = 4;
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // contourMontant
            // 
            this.contourMontant.BackgroundImage = global::NouvelleInterface.Properties.Resources.forme;
            this.contourMontant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contourMontant.Location = new System.Drawing.Point(338, 4);
            this.contourMontant.Name = "contourMontant";
            this.contourMontant.Size = new System.Drawing.Size(415, 97);
            this.contourMontant.TabIndex = 7;
            // 
            // txtObjectif
            // 
            this.txtObjectif.AutoSize = true;
            this.txtObjectif.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtObjectif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.txtObjectif.Location = new System.Drawing.Point(558, 125);
            this.txtObjectif.Name = "txtObjectif";
            this.txtObjectif.Size = new System.Drawing.Size(348, 42);
            this.txtObjectif.TabIndex = 5;
            this.txtObjectif.Text = "Objectif : 1 000 000 $ :";
            this.txtObjectif.UseMnemonic = false;
            // 
            // btnInscription
            // 
            this.btnInscription.BackColor = System.Drawing.Color.Transparent;
            this.btnInscription.BackgroundImage = global::NouvelleInterface.Properties.Resources.btnInscription;
            this.btnInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInscription.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnInscription.FlatAppearance.BorderSize = 0;
            this.btnInscription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInscription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscription.ForeColor = System.Drawing.Color.White;
            this.btnInscription.Location = new System.Drawing.Point(52, 648);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(335, 96);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "&INSCRIPTION\r\nDons et Commandites";
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click_1);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::NouvelleInterface.Properties.Resources.Background150pp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 842);
            this.Controls.Add(this.panelAccueil);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Text = "EcoGreen - pour un avenir meilleur";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoEcoHor)).EndInit();
            this.panelAccueil.ResumeLayout(false);
            this.panelAccueil.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArbre01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArbre06)).EndInit();
            this.cadreMontant.ResumeLayout(false);
            this.cadreMontant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox logoEcoHor;
        private Panel panelAccueil;
        private Button btnInscription;
        private Label txtAccueilDons;
        private Label txtObjectif;
        private TextBox txtMontant;
        private Label symboleDollar;
        private Panel cadreMontant;
        private Panel contourMontant;
        private Panel panel1;
        private PictureBox picArbre05;
        private PictureBox picArbre01;
        private PictureBox picArbre02;
        private PictureBox picArbre03;
        private PictureBox picArbre04;
        private PictureBox picArbre06;
        private Button btnApropos;
    }
}