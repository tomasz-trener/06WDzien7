﻿
namespace P03AplikacjaZawodnicy.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.txtPotwierdzenie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(16, 39);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(165, 20);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(16, 84);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(165, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(16, 130);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(165, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kraj";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(16, 224);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(165, 20);
            this.txtWaga.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Waga";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(16, 274);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(165, 20);
            this.txtWzrost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wzrost";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(106, 303);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(16, 176);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(165, 20);
            this.dtpDataUrodzenia.TabIndex = 13;
            // 
            // txtPotwierdzenie
            // 
            this.txtPotwierdzenie.Location = new System.Drawing.Point(16, 332);
            this.txtPotwierdzenie.Name = "txtPotwierdzenie";
            this.txtPotwierdzenie.Size = new System.Drawing.Size(165, 20);
            this.txtPotwierdzenie.TabIndex = 14;
            this.txtPotwierdzenie.Visible = false;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 362);
            this.Controls.Add(this.txtPotwierdzenie);
            this.Controls.Add(this.dtpDataUrodzenia);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label1);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.Load += new System.EventHandler(this.FrmSzczegoly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.TextBox txtPotwierdzenie;
    }
}