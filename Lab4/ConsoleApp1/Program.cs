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
        static int Dziel(int l1, int l2)
        {
            int w = l1 / l2;
            return w;
        }
        static void Main(string[] args)
        {     
            string tekst1 = WczytajLiczbe("1");
            string tekst2 = WczytajLiczbe("2");

            Console.WriteLine("Wybierz operacje do wykonania: ");
            string operacja = Console.ReadLine();

            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            int wynik;

            switch (operacja)
            {
                case "+":
                   
                    wynik = Dodaj(liczba1, liczba2);
                    Console.WriteLine("Wynik wynosi: " + wynik);
                    break;

                case "-":
                    wynik = Odejmij(liczba1, liczba2);
                    Console.WriteLine("Wynik wynosi: " + wynik);
                    break;

                case "*":    
                    wynik = Mnóż(liczba1, liczba2);
                    Console.WriteLine("Wynik wynosi: " + wynik);
                    break;

                case "/":               
                    wynik = Dziel(liczba1, liczba2);
                    Console.WriteLine("Wynik wynosi: " + wynik);
                    break;

                default:
                    break;
            }
        }
    }
}
