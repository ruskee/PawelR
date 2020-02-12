using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_Poprawa
{
    public class Piosenka
    {
        public Piosenka(string tytul, string autor, TimeSpan dlugosc)
        {
            Tytul = tytul;
            Autor = autor;
            Dlugosc = dlugosc;
        }

        public string Tytul;
        public string Autor;
        public TimeSpan Dlugosc;

    }
}
