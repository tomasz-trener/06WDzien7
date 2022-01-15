
namespace P01KomunikacjaPomiedzyFormularzami
{
    partial class FrmStartowy
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
            this.btnOtworzSzczegoly = new System.Windows.Forms.Button();
            this.txtKomunikat = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.lblKomuniakt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOtworzSzczegoly
            // 
            this.btnOtworzSzczegoly.Location = new System.Drawing.Point(21, 24);
            this.btnOtworzSzczegoly.Name = "btnOtworzSzczegoly";
            this.btnOtworzSzczegoly.Size = new System.Drawing.Size(94, 77);
            this.btnOtworzSzczegoly.TabIndex = 0;
            this.btnOtworzSzczegoly.Text = "Otwórz szczegóły";
            this.btnOtworzSzczegoly.UseVisualStyleBackColor = true;
            this.btnOtworzSzczegoly.Click += new System.EventHandler(this.btnOtworzSzczegoly_Click);
            // 
            // txtKomunikat
            // 
            this.txtKomunikat.Location = new System.Drawing.Point(21, 197);
            this.txtKomunikat.Name = "txtKomunikat";
            this.txtKomunikat.Size = new System.Drawing.Size(94, 20);
            this.txtKomunikat.TabIndex = 1;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(21, 168);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(94, 23);
            this.btnWyslij.TabIndex = 2;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // lblKomuniakt
            // 
            this.lblKomuniakt.AutoSize = true;
            this.lblKomuniakt.Location = new System.Drawing.Point(168, 24);
            this.lblKomuniakt.Name = "lblKomuniakt";
            this.lblKomuniakt.Size = new System.Drawing.Size(35, 13);
            this.lblKomuniakt.TabIndex = 3;
            this.lblKomuniakt.Text = "label1";
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 229);
            this.Controls.Add(this.lblKomuniakt);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtKomunikat);
            this.Controls.Add(this.btnOtworzSzczegoly);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtworzSzczegoly;
        private System.Windows.Forms.TextBox txtKomunikat;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.Label lblKomuniakt;
    }
}

