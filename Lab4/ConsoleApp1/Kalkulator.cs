using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kalkulator
    {
        public static string WczytajLiczbe(string licznik) // aby wywołać funkcje w main to musi mieć ona takie samo słowo kluczowe (static)
        {
            Console.Write("Podaj liczbe " + licznik + ": ");
            string tekst = Console.ReadLine();
            return tekst;
        }

        public static int Dodaj(int l1, int l2)
        {
            int w = l1 + l2;
            return w;
        }

        public static int Dodaj(int l1, int l2, int l3) // Przeładowanie funkcji (Funkcja o takiej samej nazwie, ale z innymi parametrami)
        {
            // return l1+l2+l3;
            // return Dodaj(l1, l2) + l3;
            return Dodaj(Dodaj(l1, l2), l3);
        }

        public static int Dodaj(string tekst1, string tekst2) //Przeładowanie funkcji Dodaj, argumentami są zmienne typu tekstowego, następnie przekonwertowanie string na int
        {
            int l1 = Convert.ToInt32(tekst1);
            int l2 = Convert.ToInt32(tekst2);
            return l1 + l2;
        }

        public static int Odejmij(int l1, int l2)
        {
            int w = l1 - l2;
            return w;
        }
        public static int Mnóż(int l1, int l2)
        {
            int w = l1 * l2;
            return w;
        }
        public static double Dziel(int l1, int l2, out bool powodzenie)
        {
            if (l2 == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            double w = (double)l1 / l2;
            return w;
        }

        public static double PodzielZWyjatkiem(int l1, int l2) //Rzucenie wyjątku dzielenia przez 0
        {
            if (l2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)l1 / l2;
        }

    }
}
