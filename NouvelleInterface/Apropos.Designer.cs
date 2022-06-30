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
            this.lblOlivier = new System.Windows.Forms.Label();
            this.lblCatherine = new System.Windows.Forms.Label();
            this.lblFred = new System.Windows.Forms.Label();
            this.lblAuteur01 = new System.Windows.Forms.Label();
            this.lblInfoProjetSTE = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblOlivier
            // 
            this.lblOlivier.AutoSize = true;
            this.lblOlivier.Location = new System.Drawing.Point(53, 110);
            this.lblOlivier.Name = "lblOlivier";
            this.lblOlivier.Size = new System.Drawing.Size(95, 15);
            this.lblOlivier.TabIndex = 1;
            this.lblOlivier.Text = "Olivier Raymond";
            // 
            // lblCatherine
            // 
            this.lblCatherine.AutoSize = true;
            this.lblCatherine.Location = new System.Drawing.Point(53, 90);
            this.lblCatherine.Name = "lblCatherine";
            this.lblCatherine.Size = new System.Drawing.Size(93, 15);
            this.lblCatherine.TabIndex = 2;
            this.lblCatherine.Text = "Catherine Godin";
            // 
            // lblFred
            // 
            this.lblFred.AutoSize = true;
            this.lblFred.Location = new System.Drawing.Point(53, 71);
            this.lblFred.Name = "lblFred";
            this.lblFred.Size = new System.Drawing.Size(87, 15);
            this.lblFred.TabIndex = 3;
            this.lblFred.Text = "Frédérick Faidit";
            // 
            // lblAuteur01
            // 
            this.lblAuteur01.AutoSize = true;
            this.lblAuteur01.Location = new System.Drawing.Point(30, 52);
            this.lblAuteur01.Name = "lblAuteur01";
            this.lblAuteur01.Size = new System.Drawing.Size(54, 15);
            this.lblAuteur01.TabIndex = 4;
            this.lblAuteur01.Text = "Auteurs :";
            // 
            // lblInfoProjetSTE
            // 
            this.lblInfoProjetSTE.AutoSize = true;
            this.lblInfoProjetSTE.Location = new System.Drawing.Point(30, 36);
            this.lblInfoProjetSTE.Name = "lblInfoProjetSTE";
            this.lblInfoProjetSTE.Size = new System.Drawing.Size(49, 15);
            this.lblInfoProjetSTE.TabIndex = 5;
            this.lblInfoProjetSTE.Text = "STE v1.0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(154, 22);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(626, 318);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOlivier);
            this.Controls.Add(this.lblCatherine);
            this.Controls.Add(this.lblFred);
            this.Controls.Add(this.lblAuteur01);
            this.Controls.Add(this.lblInfoProjetSTE);
            this.Name = "Apropos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOlivier;
        private Label lblCatherine;
        private Label lblFred;
        private Label lblAuteur01;
        private Label lblInfoProjetSTE;
        private RichTextBox richTextBox1;
    }
}