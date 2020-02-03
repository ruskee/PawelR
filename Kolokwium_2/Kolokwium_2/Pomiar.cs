using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolokwium_2
{
    public class Pomiar 
    {
        Random rnd = new Random();
        public Pomiar(double temperatura, double wilgotnosc, double prWiatru, double cisnienie, int idpracownika)
        {
            Temperatura = NumberGenerator1();
            Wilgotnosc = NumberGenerator1();
            PrWiatru = NumberGenerator1();
            Cisnienie = NumberGenerator1();
            IDpracownika = NumberGenerator();
        }

        public double Temperatura { get; set; }
        public double Wilgotnosc { get; set; }
        public double PrWiatru { get; set; }
        public double Cisnienie { get; set; }
        public int IDpracownika { get; set; }

        public int NumberGenerator()
        {  
            int number = rnd.Next(3);
            return number;
        }

        public double NumberGenerator1()
        {
            double number1 = rnd.NextDouble()*50;
            return number1;
        }

    }
}
