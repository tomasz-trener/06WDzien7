using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plik> pliki = new List<Plik>()
            {
                new PlikCSV() { Sciezka=@"c:\dane\pliki\p1", Zawartosc="ala ma kota" },
                new PlikHTML() { Sciezka = @"c:\dane\pliki\p2", Zawartosc = "ala ma kota" },
                new PlikSQL() { Sciezka = @"c:\dane\pliki\p3", Zawartosc = "ala ma kota" },
            };

            foreach (var p in pliki)
                p.Zapisz();

            // override nadpisuje metodę czyli uzywamy metody z klasy oryginalnej
            // new przeslania i wtedy uzywamy metody z klasy bazowej
            // jezeli nic nie napiszemy to domysle zachowanie jesttakie samo jak new czyli przesłanianie 

            // virtual w klasie bazowej pozwala na override . gdy nie ma virtrual to nie ma mozliwosci zastosowania override

            //foreach (var p in pliki)
            //{ 
            //    if(p is PlikCSV)
            //     ((PlikCSV)p).Zapisz();

            //    if (p is PlikHTML)
            //        ((PlikHTML)p).Zapisz();

            //    if (p is PlikSQL)
            //        ((PlikSQL)p).Zapisz();
            //}

             // Plik plik = new Plik() plik jest klasa abstracyjna to znaczy, ze stawnoi tylko szablon  dla innych klas
             // i poprzez slowo abstract ja zakazuje mozlowsci tworenia nowej instacji pliku 

        }
    }
}
