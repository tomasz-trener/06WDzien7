using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05MechanizmDziedziczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek();

            Zawodnik z = new Zawodnik() { Imie = "Adam", Nazwisko = "Nowak" };

            Trener t = new Trener() { Imie = "Jan", Nazwisko = "Kowalski" };

            List<Czlowiek> osoby = new List<Czlowiek>();
            osoby.Add(z);
            osoby.Add(t);

            for (int i = 0; i < osoby.Count; i++)
                osoby[i].PrzedstawSie();
            

            foreach (var o in osoby)
                o.PrzedstawSie();

            Czlowiek t1 = new Trener() { Imie = "Tomasz", Nazwisko = "Trener" };

            var t2 = (Trener)t1;

            int stazPracy = ((Trener)t1).StazPracy;


        }
    }
}
