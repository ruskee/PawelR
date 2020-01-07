using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium1_Poprawa
{
    class EBook
    {
        private readonly string _autor;
        private readonly string _tytul;
        private readonly DateTime _dataWydania;
        private DateTime _dataOstatniegoZakupu;
        private double _cenaStandardowa;
        private int _obnizka;
        private double _aktualnaCena;

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, int obnizka)
        {
            _autor = autor;
            _tytul = tytul;
            _dataWydania = dataWydania;
            _dataOstatniegoZakupu = dataOstatniegoZakupu;
            _cenaStandardowa = cenaStandardowa;
            _obnizka = obnizka;
        }

        public string autor { get => _autor; }
        public string tytul { get => _tytul; }
        public DateTime dataWydania { get => _dataWydania; }
        public DateTime dataOstatniegoZakupu
        {
            get
            {
                return _dataOstatniegoZakupu;
            }
            set
            {
                if (value.Date < _dataOstatniegoZakupu.Date) _dataOstatniegoZakupu = value;
            }
        }

        public double cenaStandardowa
        {
            get
            {
                return _cenaStandardowa;
            }
            set
            {
                if (value > 0)
                {
                    _cenaStandardowa = value;
                }
                else Console.WriteLine("Cena standardowa nie może być mniejsza od 0");
            }
        }

        public int obnizka
        {
            get
            {
                return _obnizka;
            }
            set
            {
                if (_cenaStandardowa * (value/100) > 0.0) _obnizka = value;
                else Console.WriteLine("Obnizka nie moze dac ceny nizszej niz 0");
            }
        }

        public double aktualnaCena
        {
            get
            {
                return _aktualnaCena = _cenaStandardowa * ((100 - obnizka) / 100);
            }
        }

    }
}
