using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium_2
{
    public static class ExtensionMethodCenowka
    {
        public static double Cenowka(this String number)
        {
            double d = double.Parse("1000");
            return Math.Round(d, 2);
        }
    }
}
