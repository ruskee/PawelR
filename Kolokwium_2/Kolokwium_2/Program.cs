using System;
using System.Linq;

namespace Kolokwium_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Zad1
            for (int i = 0; i <= 150; i++)
            {
                Pomiar pomiar = new Pomiar(13.12, 32.42, 140.4, 1000, 2);
                Console.WriteLine("Pomiar "+ i +") Temperatura: " + pomiar.Temperatura + " Wilgotnosc: " + pomiar.Wilgotnosc + " PrWiatru: " + pomiar.PrWiatru + " Cisnienie: " + pomiar.Cisnienie + " IDpracownika: " + pomiar.IDpracownika);            }
            }

        //Zad4
        //Kierowca kierowca = new Kierowca("Nowak", DateTime(2020/4/4) );
    }
}
