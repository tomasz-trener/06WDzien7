
namespace P01KomunikacjaPomiedzyFormularzami
{
    partial class FrmSzczegoly
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
            this.lblKomuniakt = new System.Windows.Forms.Label();
            this.txtKomuniakt = new System.Windows.Forms.TextBox();
            this.btnWylisj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKomuniakt
            // 
            this.lblKomuniakt.AutoSize = true;
            this.lblKomuniakt.Location = new System.Drawing.Point(21, 30);
            this.lblKomuniakt.Name = "lblKomuniakt";
            this.lblKomuniakt.Size = new System.Drawing.Size(35, 13);
            this.lblKomuniakt.TabIndex = 0;
            this.lblKomuniakt.Text = "label1";
            // 
            // txtKomuniakt
            // 
            this.txtKomuniakt.Location = new System.Drawing.Point(12, 214);
            this.txtKomuniakt.Name = "txtKomuniakt";
            this.txtKomuniakt.Size = new System.Drawing.Size(100, 20);
            this.txtKomuniakt.TabIndex = 1;
            // 
            // btnWylisj
            // 
            this.btnWylisj.Location = new System.Drawing.Point(13, 185);
            this.btnWylisj.Name = "btnWylisj";
            this.btnWylisj.Size = new System.Drawing.Size(99, 23);
            this.btnWylisj.TabIndex = 2;
            this.btnWylisj.Text = "Wyślij";
            this.btnWylisj.UseVisualStyleBackColor = true;
            this.btnWylisj.Click += new System.EventHandler(this.btnWylisj_Click);
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnWylisj);
            this.Controls.Add(this.txtKomuniakt);
            this.Controls.Add(this.lblKomuniakt);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKomuniakt;
        private System.Windows.Forms.TextBox txtKomuniakt;
        private System.Windows.Forms.Button btnWylisj;
    }
}