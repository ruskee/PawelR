using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2
{
    abstract class Produkt
    {
        public Produkt(string nazwa, int cena, string producent)
        {
            Nazwa = nazwa;
            Cena = cena;
            Producent = producent;
        }

        public abstract string Nazwa {get; set;}
        public abstract int Cena { get; set; }
        public abstract string Producent { get; set; }


    }

}
