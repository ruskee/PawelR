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

            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();

            int liczba = Convert.ToInt32(odpowiedz);

            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");

            Console.ReadKey();
        }
    }
}