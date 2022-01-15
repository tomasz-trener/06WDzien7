using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PrzykladKomunikacjiPomiedzyKlasami
{
    class Osoba
    {
        string imie;
        string nazwisko;

        public string ImieNazwisko
        {
            get { return imie + " " + nazwisko; } 
        }

        Samochod samochod;

        public void KupSamochod()
        {
            samochod = new Samochod(this);
        }

        public void PochwalSieSamochodem()
        {
            Console.WriteLine("Kolor mojego " +
                "samochodu to: " + samochod.Kolor);
        }

    }
}
