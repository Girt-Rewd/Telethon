namespace NouvelleInterface
{
    partial class affiche
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
            this.txtBoxAffiche = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoxAffiche
            // 
            this.txtBoxAffiche.Location = new System.Drawing.Point(12, 12);
            this.txtBoxAffiche.Name = "txtBoxAffiche";
            this.txtBoxAffiche.Size = new System.Drawing.Size(574, 410);
            this.txtBoxAffiche.TabIndex = 0;
            this.txtBoxAffiche.Text = "";
            // 
            // affiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 434);
            this.Controls.Add(this.txtBoxAffiche);
            this.Name = "affiche";
            this.Text = "affiche";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox txtBoxAffiche;
    }
}