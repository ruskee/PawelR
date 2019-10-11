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
            /*
            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();

            int liczba = Convert.ToInt32(odpowiedz);

            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta"); //Szybsze rozwiązanie niż na ifach

            Console.ReadKey();
            */
            /*
            double odleglosc = int.MinValue;
            double suma = 0, licznik = 0;
            while (odleglosc !=0)
            {
                string odlegloscTekst = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscTekst); //W niektórych wypadkach działa, w niektórych nie
                suma += odleglosc;
                licznik++;
            }
            double wynik = suma / (licznik-1);

            Console.WriteLine(wynik);
            */




            //Napisać program który za kazdym wcisnieciem klawisza enter wypisuje unikatowy komunikat na ekranie

            int licznik = 1;
            string linia = string.Empty;
            while (linia != "exit") 
            {
                Console.WriteLine(licznik++);
                linia = Console.ReadLine();
            }
          

        }
    }
}