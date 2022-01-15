using P03AplikacjaZawodnicy.Domains;
using P03AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04DynamiczneTworzenieKontrolek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStworzPrzycisk_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Name = "btnNowy";
            b.Top = 100;
            b.Left = 200;
            b.Text = "nowy przycisk";
            b.Click += new EventHandler(btnNowy_Click);

            Controls.Add(b);
        }

        private void btnNowy_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Kliknięty przycisk");
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Wczytaj();

            for (int i = 0; i < zr.Zawodnicy.Length; i++)
            {
                Button b = new Button();
                b.Name = $"btnZawodnik_{zr.Zawodnicy[i].Id_zawodnika}";
                b.Top = 20 + i*20;
                b.Left = 200;
                b.Width = 150;
                b.Tag = zr.Zawodnicy[i];
                b.Text= zr.Zawodnicy[i].ImieNazwisko;
                b.Click += new EventHandler(btnZawodnik_Click);
                Controls.Add(b);
            }
        }


        private void btnZawodnik_Click(object sender, EventArgs e)
        {
            var przyciskKlkiniety=  (Button)sender;
            var zawodnik = (Zawodnik)przyciskKlkiniety.Tag;

            MessageBox.Show("Kliknięty przycisk" + zawodnik.CalyRekord);
        }
    }
}
