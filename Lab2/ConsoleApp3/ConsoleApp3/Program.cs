using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();

            int liczba = Convert.ToInt32(odpowiedz);

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }
        }
    }
}