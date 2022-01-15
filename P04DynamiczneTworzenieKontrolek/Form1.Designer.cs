
namespace P04DynamiczneTworzenieKontrolek
{
    partial class Form1
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
            this.btnStworzPrzycisk = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStworzPrzycisk
            // 
            this.btnStworzPrzycisk.Location = new System.Drawing.Point(12, 12);
            this.btnStworzPrzycisk.Name = "btnStworzPrzycisk";
            this.btnStworzPrzycisk.Size = new System.Drawing.Size(82, 69);
            this.btnStworzPrzycisk.TabIndex = 0;
            this.btnStworzPrzycisk.Text = "Stwórz przycisk";
            this.btnStworzPrzycisk.UseVisualStyleBackColor = true;
            this.btnStworzPrzycisk.Click += new System.EventHandler(this.btnStworzPrzycisk_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(13, 88);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 363);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.btnStworzPrzycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStworzPrzycisk;
        private System.Windows.Forms.Button btnWczytaj;
    }
}

