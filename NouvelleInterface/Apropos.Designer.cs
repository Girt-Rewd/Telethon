namespace NouvelleInterface
{
    partial class Apropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apropos));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblOlivier = new System.Windows.Forms.Label();
            this.lblCatherine = new System.Windows.Forms.Label();
            this.lblFred = new System.Windows.Forms.Label();
            this.lblAuteur01 = new System.Windows.Forms.Label();
            this.lblInfoProjetSTE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(213, 33);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(626, 318);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblOlivier
            // 
            this.lblOlivier.AutoSize = true;
            this.lblOlivier.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOlivier.Location = new System.Drawing.Point(19, 106);
            this.lblOlivier.Name = "lblOlivier";
            this.lblOlivier.Size = new System.Drawing.Size(103, 18);
            this.lblOlivier.TabIndex = 2;
            this.lblOlivier.Text = "Olivier Raymond";
            // 
            // lblCatherine
            // 
            this.lblCatherine.AutoSize = true;
            this.lblCatherine.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatherine.Location = new System.Drawing.Point(19, 87);
            this.lblCatherine.Name = "lblCatherine";
            this.lblCatherine.Size = new System.Drawing.Size(100, 18);
            this.lblCatherine.TabIndex = 3;
            this.lblCatherine.Text = "Catherine Godin";
            // 
            // lblFred
            // 
            this.lblFred.AutoSize = true;
            this.lblFred.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFred.Location = new System.Drawing.Point(19, 68);
            this.lblFred.Name = "lblFred";
            this.lblFred.Size = new System.Drawing.Size(100, 18);
            this.lblFred.TabIndex = 4;
            this.lblFred.Text = "Frédérick Faidit";
            // 
            // lblAuteur01
            // 
            this.lblAuteur01.AutoSize = true;
            this.lblAuteur01.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuteur01.Location = new System.Drawing.Point(19, 49);
            this.lblAuteur01.Name = "lblAuteur01";
            this.lblAuteur01.Size = new System.Drawing.Size(61, 18);
            this.lblAuteur01.TabIndex = 5;
            this.lblAuteur01.Text = "Auteurs :";
            // 
            // lblInfoProjetSTE
            // 
            this.lblInfoProjetSTE.AutoSize = true;
            this.lblInfoProjetSTE.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoProjetSTE.Location = new System.Drawing.Point(19, 9);
            this.lblInfoProjetSTE.Name = "lblInfoProjetSTE";
            this.lblInfoProjetSTE.Size = new System.Drawing.Size(75, 25);
            this.lblInfoProjetSTE.TabIndex = 6;
            this.lblInfoProjetSTE.Text = "STE v1.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOlivier);
            this.panel1.Controls.Add(this.lblCatherine);
            this.panel1.Controls.Add(this.lblFred);
            this.panel1.Controls.Add(this.lblAuteur01);
            this.panel1.Controls.Add(this.lblInfoProjetSTE);
            this.panel1.Location = new System.Drawing.Point(55, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 142);
            this.panel1.TabIndex = 8;
            // 
            // Apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(147)))));
            this.BackgroundImage = global::NouvelleInterface.Properties.Resources.Background150pp;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Apropos";
            this.Text = "Apropos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Label lblOlivier;
        private Label lblCatherine;
        private Label lblFred;
        private Label lblAuteur01;
        private Label lblInfoProjetSTE;
        private Panel panel1;
    }
}