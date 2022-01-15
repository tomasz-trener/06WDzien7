using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieDziedziczenie
{
    abstract class Plik
    {
        public string Autor;
        public string Sciezka;
        public int Rozmiar;
        public string Zawartosc;
        public string Rozszerzenie;

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + Rozszerzenie, Zawartosc);
        }
    }
}
