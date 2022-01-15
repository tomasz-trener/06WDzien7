using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05MechanizmDziedziczenia
{
    class Czlowiek
    {
        public string Imie;
        public string Nazwisko;

        public void PrzedstawSie()
        {
            Console.WriteLine("Nazywam sie" + Imie + " " + Nazwisko);
        }
    }
}
