using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PrzykladKomunikacjiPomiedzyKlasami
{
    class Samochod
    {
        string kolor ="czerwony";

        Osoba wlasciciel;

        public Samochod(Osoba o)
        {
            wlasciciel = o;
        }


        public string Kolor
        {
            get { return kolor; }
        }

        public void Uruchom()
        {
            Console.WriteLine("Uruchamiam silnik");
            Console.WriteLine("Mój właściciel to: " +
                wlasciciel.ImieNazwisko
                );
        }
    }
}
