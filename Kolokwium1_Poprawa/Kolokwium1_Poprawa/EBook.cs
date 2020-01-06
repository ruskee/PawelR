using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1_Poprawa
{
    class EBook
    {
        private readonly string Autor;
        private readonly string Tytul;
        private readonly DateTime DataWydania;
        private DateTime DataOstatniegoZakupu;
        private double CenaStandardowa;
        private int Obnizka;
        private double AktualnaCena;

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, int obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obnizka = obnizka;
        }

        public string autor { get => Autor; }
        public string tytul { get => Tytul; }
        public DateTime dataWydania { get => DataWydania; }
        public DateTime dataOstatniegoZakupu
        {
            get
            {
                return DataOstatniegoZakupu;
            }
            set
            {
                if (value.Date < DataOstatniegoZakupu.Date) DataOstatniegoZakupu = value;
            }
        }

        public double cenaStandardowa
        {
            get
            {
                return CenaStandardowa;
            }
            set
            {
                if (value > 0)
                {
                    CenaStandardowa = value;
                }
                else Console.WriteLine("Cena standardowa nie może być mniejsza od 0");
            }
        }

        public int obnizka
        {
            get
            {
                return Obnizka;
            }
            set
            {
                if (CenaStandardowa - value > 0) Obnizka = value;
                else Console.WriteLine("Obnizka nie moze dac ceny nizszej niz 0");
            }
        }

        public double aktualnaCena
        {
            get
            {
                return AktualnaCena = CenaStandardowa * ((100 - obnizka) / 100);
            }
            set
            {
                AktualnaCena = CenaStandardowa * ((100 - obnizka) / 100);
            }
        }

    }
}
