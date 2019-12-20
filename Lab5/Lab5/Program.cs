using System;

namespace Lab5
{
    class Program
    {
        /* Napisz program wspomagający magazyn biblioteki. Każda ksiązka ma tytuł. Magazyn ma 3 regały. Regał ma 6 półek. Półka ma 10 miejsc. Wskaż
         gdzie szukać ksiązki na podstawie tytułu */

        static void Main(string[] args)
        {
            Ksiazka[,,] tab = new Ksiazka[3,6,10];

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(2); k++)
                    {
                        tab[i, j, k] = new Ksiazka("Pan Tadeusz", "Mickiewicz",i,j,k);
                    }
                }
            }
            tab[2, 5, 3] = new Ksiazka("Potop", "Sienkiewicz",2,5,3); //Wykorzystanie klasy Ksiazka
       
            
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(2); k++)
                    {
                        Console.WriteLine("Regał nr {0}, Półka nr {1}, Miejsce nr {2}", i, j, k);
                        Console.WriteLine(tab[i, j, k].Tytul + " " + tab[i, j, k].Autor);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Podaj tytul lub autora ktorego szukasz: ");
            string nazwa = Convert.ToString(Console.ReadLine());

             for (int i = 0; i < tab.GetLength(0); i++)
             {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    for (int k = 0; k < tab.GetLength(2); k++)
                    {
                        if (nazwa == tab[i, j, k].Tytul || nazwa == tab[i, j, k].Autor)
                        {
                            Console.WriteLine("Ksiazka znajduje się w regale {0}, półce {1}, miejscu {2}", i, j, k);
                        }                    
                    }
                 }
             }
  
        }
    }
}
