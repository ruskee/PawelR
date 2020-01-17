using System;
using System.Collections.Generic;
using System.Text;

namespace KOLOKWIUM_POPRAWA
{
    /*
     Zadanie 4) 
        * Stworz klase KontoBankowe.By utworzyc konto nalezy podaj imię i nazwisko wlasciciela. Podczas tworzenie konta wygeneruj numer skladajacy sie z 26 cyfr.Dane wlasciciela nie mogą
         *  byc zmieniane- utworz odpowiednie zabezpieczenie.Konto musi posiadac pole stan.stan moze byc zmieniany wylacznie za pomoca metody uznanie i obciazenie.utworz zabezpieczenie ktore
        * nie pozwoli na debet wiekszy niz 100,00zł.Stworz kolekcje liczb Historia, w ktorej zapisane beda kwoty ostatnich 100 operacji (dodatnie lub ujemne). Jezeli wykonane bedzie ponad 100
         * operacji, napisz najstarszy wpis.
    */

    class KontoBankowe
    {
        private readonly string _imie;
        private readonly string _nazwisko;
        private string _numer;
        private double _stan;
        private double _uznanie;
        private double _obciazenie;
        private double _debet;
        private string _historia;

        public KontoBankowe(string imie, string nazwisko, string numer, double stan, double uznanie, double obciazenie, double debet)
        {
            _imie = imie;
            _nazwisko = nazwisko;
            _numer = numer;
            _stan = stan;
            _uznanie = uznanie;
            _obciazenie = obciazenie;
            _debet = debet;
        }

        public string imie { get => _imie; }
        public string nazwisko { get => nazwisko; }
        public string numer
        {
            get
            {
                return _numer;
            }

            set
            {
              //  numer = _numer.Length(26);
            }

        }
        public double stan
        {
            get
            {
                return _stan;
            }

        }

        public double debet
        {
            get
            {
                return _debet;
            }
            set
            {

            }
        }

        public string historia
        {
            get
            {
                return _historia;
            }
        }
       



    }


}
