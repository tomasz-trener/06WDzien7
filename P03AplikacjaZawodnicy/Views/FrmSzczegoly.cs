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

namespace P03AplikacjaZawodnicy.Views
{
    public partial class FrmSzczegoly : Form
    {
        FrmZawodnicy frmZawodnicy;

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy)
        {
            this.frmZawodnicy = frmZawodnicy;
            InitializeComponent();
        }

        private void FrmSzczegoly_Load(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik();
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpDataUrodzenia.Value;
            z.Waga = Convert.ToInt32(txtWaga.Text);
            z.Wzrost = Convert.ToInt32(txtWzrost.Text);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Dodaj(z);

            this.Close();
            frmZawodnicy.Odswiez();



        }
    }
}
