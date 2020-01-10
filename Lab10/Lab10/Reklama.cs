using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Reklama
    {
        public string Tresc;
        private TypOsoby typOsoby;
        private Zainteresowania zainteresowania;

        public void Test()
        {
            if (typOsoby.HasFlag(TypOsoby.Dziecko))
            {
                Console.WriteLine("Ta reklama jest dla dzieci");
            }
            if (typOsoby < TypOsoby.Dorosly)
            {
                Console.WriteLine("Ta reklama jest dla pelnoletnich");
            }

            for (int i = 0; i <= TypOsoby.Brak.SumaTypowOsob(); i++)
            {
                Console.WriteLine((TypOsoby)i);
            }      
    }

        public Reklama(
            string tresc,
            TypOsoby typOsoby,
            Zainteresowania zainteresowania)
        {
            Tresc = tresc;
            this.typOsoby = typOsoby;
            this.zainteresowania = zainteresowania;
        }
        
    }
}
