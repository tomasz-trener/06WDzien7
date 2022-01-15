using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SlowoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c1 = new Czlowiek();

            c1.Imie = "Jan";
            Czlowiek.Nazwisko = "kowalski";

            Czlowiek c2 = new Czlowiek()
            {
                Imie = "Adam"
            };

            c1.PrzedstawSie();
            c2.PrzedstawSie();

            Czlowiek.MetodaStatyczna();

            Console.WriteLine("hej");
            File.WriteAllText("plik.txt", "aa");

            
        }
    }
}
