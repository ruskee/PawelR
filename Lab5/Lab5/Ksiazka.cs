using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public int Regal;
        public int Polka;
        public int Miejsce;

        public Ksiazka(string tytul, string autor, int regal, int polka, int miejsce)
        {
            Tytul = tytul;
            Autor = autor;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }

    }
}
