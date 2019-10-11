using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();

            int liczba;
            bool czySieUdalo = int.TryParse(odpowiedz, out liczba);
            if (czySieUdalo)
            {
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Parzysta");
                }
                else
                {
                    Console.WriteLine("Nieparzysta");
                }
            }
            else
            {
                Console.WriteLine("Nie podano liczby");
            }
            Console.ReadKey();
            */
            /* Lepsze rozwiązanie
            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();

            int liczba = Convert.ToInt32(odpowiedz);

            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");

            Console.ReadKey();
            */

            int odleglosc = int.MinValue;
            int suma = 0, licznik = 0;
            while (odleglosc !=0)
            {
                string odlegloscTekst = Console.ReadLine();
                odleglosc = Convert.ToInt32(odlegloscTekst);
                suma += odleglosc;
                licznik++;
            }
            double wynik = (double)suma / licznik;

            Console.WriteLine(wynik);
        }
    }
}