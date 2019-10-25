using System;

namespace ConsoleApp1
{
    class Program
    {

        static string WczytajLiczbe(string licznik) // aby wywołać funkcje w main to musi mieć ona takie samo słowo kluczowe (static)
        {
            Console.Write("Podaj liczbe " + licznik + ": ");
            string tekst = Console.ReadLine();
            return tekst;
        }

        static int Dodaj(int l1, int l2)
        {
            int w = l1 + l2;
            return w;       
        }
        static int Dodaj(int l1, int l2, int l3) // Przeładowanie funkcji (Funkcja o takiej samej nazwie, ale z innymi parametrami)
        {
            // return l1+l2+l3;
            // return Dodaj(l1, l2) + l3;
             return Dodaj(Dodaj(l1, l2),l3);
        }

        static int Dodaj(string tekst1, string tekst2) //Przekształcenie string na int
        {
            int l1 = Convert.ToInt32(tekst1);
            int l2 = Convert.ToInt32(tekst2);
            return l1 + l2;
        }

        static int Odejmij(int l1, int l2)
        {
            int w = l1 - l2;
            return w;
        }
        static int Mnóż(int l1, int l2)
        {
            int w = l1 * l2;
            return w;
        }
        static double Dziel(int l1, int l2, out bool powodzenie)
        {
            if(l2 == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            double w = (double)l1 / l2;
            return w;       
        }

        static double PodzielZWyjatkiem(int l1, int l2) //Rzucenie wyjątku dzielenia przez 0
        {
            if(l2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)l1 / l2;
        }


        static void Main(string[] args)
        {     
            string tekst1 = WczytajLiczbe("1");
            string tekst2 = WczytajLiczbe("2");

            Console.Write("Wybierz operacje do wykonania: ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            switch (operacja)
            {
                case "+":
                    Console.WriteLine("Wynik wynosi: "  + Dodaj(tekst1, tekst2));
                    //Console.WriteLine("Wynik wynosi: " + Dodaj(liczba1, liczba2));
                    break;

                case "-":
                    Console.WriteLine("Wynik wynosi: " + Odejmij(liczba1, liczba2));
                    break;

                case "*":    
                    Console.WriteLine("Wynik wynosi: " + Mnóż(liczba1, liczba2));
                    break;

                case "/":
                    /*
                    bool rezultat;
                    double wynik = Dziel(liczba1, liczba2, out rezultat);
                    if (rezultat)
                    {
                        Console.WriteLine(wynik);
                    }
                    else
                    {
                        Console.WriteLine("Podzielone przez 0");
                    }*/

                    try
                    {
                        Console.WriteLine(PodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Podzielono przez 0");
                    }
                    break;

                default:
                    Console.WriteLine("Wybrano złą operacje");
                    break;
            }

            Console.ReadKey();
        }
    }
}
