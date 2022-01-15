using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieDziedziczenie
{
    class PlikHTML : Plik
    {
        public PlikHTML()
        {
            Rozszerzenie = ".html";
        }

        string szablon = "<HTML><BODY><P>{0}</P></BODY></HTML>";

        public override void Zapisz()
        {
            Zawartosc = string.Format(szablon, Zawartosc);
            base.Zapisz();
        }
    }
}
