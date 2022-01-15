using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieDziedziczenie
{
    class PlikCSV : Plik 
    {
        public PlikCSV()
        {
            Rozszerzenie = ".csv";
        }
        public override void Zapisz()
        {
            Zawartosc = Zawartosc.Replace(" ", ";");
            base.Zapisz();
        }
    }
}
