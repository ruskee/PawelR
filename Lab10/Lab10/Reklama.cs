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
