using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Dziecko
    {
        private int _wiek;

        public Dziecko(int wiek)
        {
            _wiek = wiek;
        }

        public double Znizka { get; set; }
        /*
        public void klasa(out int wiek)
        { 
          if(_wiek == 14)
            {
                Console.WriteLine("Dziecko uczeszcza do klasy 1 liceum");
            }
          else if (_wiek == 15)
            {
                Console.WriteLine("Dziecko uczeszcza do klasy 2 liceum");
            }
          else if (_wiek == 16)
            {
                Console.WriteLine("Dziecko uczeszcza do klasy 3 liceum");
            }
        }
        */

    }
}
