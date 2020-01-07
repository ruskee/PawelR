using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1_Poprawa
{
    class Program
    {

        public static double Zadanie1(int number)
        {        
            int n = number;
            if (n == 0)
            {
                return 1.0;
            }
            else
                return (1.5 * (Zadanie1(n - 1))) - 1;
        }

        public static void Zadanie2()
        {
            Console.Write("Podaj liczbe: ");
            string linia = Console.ReadLine();
            int l;
            int.TryParse(linia, out l);

            int[] tab = new int[200];
            int liczba = 1;
      

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                tab[i] = liczba++;
            }

            if (l == 0)
            {
                throw new DivideByZeroException();
            }

            else
            {
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    if (tab[i] % l == 0)
                    {
                        Console.WriteLine(tab[i]);
                    }
                }
            }
        }

        static void Zadanie3()
        {
            int[,] jeden = new int[4, 3];
            int[,] dwa = new int[3, 8];

            int rozmiar1 = Math.Max(jeden.GetLength(0), dwa.GetLength(0));

            int rozmiar2 = Math.Max(jeden.GetLength(1), dwa.GetLength(1));

            int[,] wynik = new int[rozmiar1, rozmiar2];

            for (int i = 0; i < jeden.GetLength(0); i++)
            {
                for (int j = 0; j < jeden.GetLength(1); j++)
                {
                    jeden[i, j] = 1;
                    wynik[i, j] += jeden[i, j];
                }
            }

            for (int i = 0; i < dwa.GetLength(0); i++)
            {
                for (int j = 0; j < dwa.GetLength(1); j++)
                {
                    dwa[i, j] = 0;
                    wynik[i, j] += dwa[i, j];
                }
            }

            for (int i = 0; i < rozmiar1; i++)
            {
                for (int j = 0; j < rozmiar2; j++)
                {
                    Console.Write(wynik[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int[,] NewTable1()
        {
            int[,] tab1 = new int[3, 5];

            Random rnd = new Random();

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = rnd.Next(0, 100);
                    Console.Write(tab1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return tab1;
        }

        static int[][] NewTable2()
        {
            Random rnd = new Random();

            int[][] tab2 = new int[rnd.Next(1, 10)][];

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = new int[rnd.Next(1, 10)];
            }

            for (int i = 0; i < tab2.Length; i++)
            {
                for (int j = 0; j < tab2[i].Length; j++)
                {
                    tab2[i][j] = rnd.Next(0, 100);
                    Console.Write(tab2[i][j] + "\t");
                }
                Console.WriteLine();
            }

            return tab2;
        }

            
        static void Zadanie4(int[,] tab)
        {

            int min = int.MaxValue;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] < min)
                    {
                        min = tab[i, j];
                    }
                }
            }

            Console.WriteLine("Najmniejszy element w tej tablicy to: " + min);
            Console.WriteLine();
        }

        static void Zadanie4(int[][] tab)
        {

            int min = int.MaxValue;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    if (tab[i][j] < min)
                    {
                        min = tab[i][j];
                    }
                }
            }

            Console.WriteLine("Najmniejszy element w tej tablicy poszarpanej to: " + min);
        }


        static void Main(string[] args)
        {
            Console.Write("Podaj numer zadania: ");
            string linia = Console.ReadLine();

            switch (linia)
            {

                case "1":

                    Console.Write("Podaj liczbe n: ");
                    if (int.TryParse(Console.ReadLine(), out int liczba))
                    {
                        Console.WriteLine(Zadanie1(liczba));
                    }
                    break;

                case "2":

                    try
                    {
                        Zadanie2();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    break;

                case "3":
                    Zadanie3();
                    break;

                case "4":
                    Console.WriteLine();
                    Zadanie4(NewTable1());
                    Zadanie4(NewTable2());
                    break;

                case "5":
                    //Zadanie5
                    EBook eBook = new EBook("Bolesław Prus", "Lalka", new DateTime(1890 / 1 / 1), new DateTime(2019 / 12 / 15), 25.55, 10);
                    break;

                default:
                    Console.WriteLine("Brak zadania o podanym numerze");
                    break;
            }

            Console.ReadKey();
        }
    }
}