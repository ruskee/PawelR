using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    [Flags]
    enum TypOsoby
    {
        Dziecko = 1, // [0001]
        Mlodzierz = 2, // [0010]
        Dorosly = 4, // [0100]
        Starszy = 8 // [1000]
    }

    [Flags]
    enum Zainteresowania
    {
        Sport,
        Gaming,
        Sztuka,
        Biznes
    }
}
