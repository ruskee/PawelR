using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    [Flags]
    public enum TypOsoby
    {
        Brak = 0,
        Dziecko = 1, // [0001]
        Mlodziez = 2, // [0010]
        Dorosly = 4, // [0100]
        Starszy = 8 // [1000]
    }
    //Dziecko + Mlodziez + Starszy = [1011] => 11

    [Flags]
    public enum Zainteresowania
    {
        Sport,
        Gaming,
        Sztuka,
        Biznes
    }
}
