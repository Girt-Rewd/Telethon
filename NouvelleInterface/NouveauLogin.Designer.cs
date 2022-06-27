namespace NouvelleInterface
{
    partial class NouveauLogin
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.icoCadenas = new System.Windows.Forms.PictureBox();
            this.icoUser = new System.Windows.Forms.PictureBox();
            this.LogoEcoLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoCadenas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEcoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(136, 308);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(252, 23);
            this.txtNom.TabIndex = 0;
            this.txtNom.Text = "Telethon2022";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(136, 364);
            this.txtMotDePasse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(252, 23);
            this.txtMotDePasse.TabIndex = 1;
            this.txtMotDePasse.Text = "Don@2022";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.btnOk.Location = new System.Drawing.Point(134, 439);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "VALIDER";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(86)))), ((int)(((byte)(62)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 2;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(147)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(147)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.btnAnnuler.Location = new System.Drawing.Point(252, 439);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(105, 30);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImage = global::NouvelleInterface.Properties.Resources.panelLogin;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.icoCadenas);
            this.panelLogin.Controls.Add(this.icoUser);
            this.panelLogin.Controls.Add(this.LogoEcoLogin);
            this.panelLogin.Controls.Add(this.btnAnnuler);
            this.panelLogin.Controls.Add(this.btnOk);
            this.panelLogin.Controls.Add(this.txtNom);
            this.panelLogin.Controls.Add(this.txtMotDePasse);
            this.panelLogin.Location = new System.Drawing.Point(174, 37);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(491, 541);
            this.panelLogin.TabIndex = 4;
            // 
            // icoCadenas
            // 
            this.icoCadenas.Image = global::NouvelleInterface.Properties.Resources.icoCadenas;
            this.icoCadenas.Location = new System.Drawing.Point(103, 364);
            this.icoCadenas.Name = "icoCadenas";
            this.icoCadenas.Size = new System.Drawing.Size(18, 22);
            this.icoCadenas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icoCadenas.TabIndex = 6;
            this.icoCadenas.TabStop = false;
            // 
            // icoUser
            // 
            this.icoUser.Image = global::NouvelleInterface.Properties.Resources.icoUser;
            this.icoUser.Location = new System.Drawing.Point(102, 311);
            this.icoUser.Name = "icoUser";
            this.icoUser.Size = new System.Drawing.Size(20, 20);
            this.icoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icoUser.TabIndex = 5;
            this.icoUser.TabStop = false;
            // 
            // LogoEcoLogin
            // 
            this.LogoEcoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoEcoLogin.Image = global::NouvelleInterface.Properties.Resources.Logo150ppi;
            this.LogoEcoLogin.Location = new System.Drawing.Point(150, 74);
            this.LogoEcoLogin.Name = "LogoEcoLogin";
            this.LogoEcoLogin.Size = new System.Drawing.Size(190, 174);
            this.LogoEcoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoEcoLogin.TabIndex = 4;
            this.LogoEcoLogin.TabStop = false;
            // 
            // NouveauLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NouvelleInterface.Properties.Resources.Background150pp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(839, 628);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NouveauLogin";
            this.Text = "Autentification";
            this.Load += new System.EventHandler(this.NouveauLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoCadenas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEcoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
      //  private EventHandler btnOk_Click;
        private Panel panelLogin;
        private PictureBox LogoEcoLogin;
        private PictureBox icoCadenas;
        private PictureBox icoUser;

        public EventHandler BtnAnnuler_Click { get; private set; }
    }

}
