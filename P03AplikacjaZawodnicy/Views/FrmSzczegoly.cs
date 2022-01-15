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
    public enum TrybOkienka
    {
        Stworzenie,
        Edycja,
        Usuwanie,

    }

    public partial class FrmSzczegoly : Form
    {
        FrmZawodnicy frmZawodnicy;
        Zawodnik zawodnik;
        TrybOkienka trybOkienka;

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy, TrybOkienka trybOkienka)
        {
            this.trybOkienka = trybOkienka;
            this.frmZawodnicy = frmZawodnicy;
            InitializeComponent();
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy, Zawodnik zaznaczony, TrybOkienka trybOkienka):this(frmZawodnicy, trybOkienka)
        {
            zawodnik = zaznaczony;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUrodzenia.Value = zawodnik.DataUrodzenia;
            txtWaga.Text = Convert.ToString(zawodnik.Waga);
            txtWzrost.Text = Convert.ToString(zawodnik.Wzrost);

            if (trybOkienka == TrybOkienka.Usuwanie)
            {
                txtImie.Enabled = false;
                txtNazwisko.Enabled = false;
                txtKraj.Enabled = false;
                dtpDataUrodzenia.Enabled = false;
                txtWaga.Enabled = false;
                txtWzrost.Enabled = false;
                btnZapisz.Text = "Usuń";
            }
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

            if (trybOkienka == TrybOkienka.Stworzenie)
            {
                zr.Dodaj(z);
            }
            else if(trybOkienka == TrybOkienka.Edycja)
            {
                // czyli jestesmy w trybie edycji
                z.Id_zawodnika = zawodnik.Id_zawodnika;
                zr.Edytuj(z);
            }else if(trybOkienka == TrybOkienka.Usuwanie)
            {
                if (txtPotwierdzenie.Text!="tak")
                {
                    MessageBox.Show("Aby potwierdzić usuwanie wpisz: \"tak\" w poniższym polu", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPotwierdzenie.Visible = true;
                    return;
                }
                else
                {
                    zr.Usun(zawodnik.Id_zawodnika);
                }
               
            }
           

            this.Close();
            frmZawodnicy.Odswiez();



        }
    }
}
