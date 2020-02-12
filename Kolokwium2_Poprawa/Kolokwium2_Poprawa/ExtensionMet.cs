using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_Poprawa
{
    public static class ExtensionMet
    {
        public static void Metoda(this int[] tab)
        {
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i]= tab[i] * 10;
            }
        }
    }
}
