using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2
{
    class Kierowca
    {
        public Kierowca(string nazwisko, DateTime dataWaznosciOC)
        {
            Nazwisko = nazwisko;
            DataWaznosciOC = dataWaznosciOC;
        }

        public string Nazwisko { get; set; }
        public DateTime DataWaznosciOC { get; set; }

        enum Uprawnienia
        {
            SamochódOsobowy,
            Traktor,
            SamochódCiezarowy,
            Motocykl
        }
    }
}
