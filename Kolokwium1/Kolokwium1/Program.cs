using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{

    class EBook
    {  
        private int Autor { get; set; }
        private int Tytul { get; set; }
        private DateTime DataWydania { get; set; }
        public DateTime DataOstatniegoZakupu { get; set; }
        public int CenaStandardowa { get; set; }
        public int Obniżka { get; set; }

        public EBook(int autor, int tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, int cenaStandardowa, int obniżka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            CenaStandardowa = cenaStandardowa;
            Obniżka = obniżka;
        }

        static void Zadanie5_Wypiszdane()
        {
            Console.WriteLine();
        }

    }

    class Program
    {

        static void Zadanie1()
        {
            /*
            Console.WriteLine("Podaj n:");
            string linia = Console.ReadLine();
            

            int[] y = new int[100];
            int n0 = 1;    
      
            for(int i=0;i<y.GetLength(0);i++)
            {
               
                y[i]=1.5 *(y[n0]) - 1;
            }
            */
        }

        static void Zadanie2()
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

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                if (tab[i] % l == 0)
                {
                    if (l == 0)
                    {
                        throw new DivideByZeroException();                      
                    }
                    Console.WriteLine(tab[i]);
                }
            }
        }

        static void Zadanie3()
        {
            int[,] tab1 = new int[3, 10];
            int[,] tab2 = new int[10, 8];

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); i++)
                {
                    for (int k = 0; i < tab1.GetLength(0); i++)
                    {
                        for (int l = 0; j < tab1.GetLength(1); i++)
                        {
                            //tab1[i, j] + tab2[k, l];
                        }
                    }
                }
            }

        }

        static void Zadanie4()
        {
            float funkcja(int[,] tab)
            {
                int min = 1000;
                for (int i = 0; i < tab.GetLength(0); i++) {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[i, j] < min)
                        {
                            min = tab[i, j];
                        }
                    }
                }

                return min;
            }

            int[,] tab1 = new int[2, 3];
            int liczba = 10;

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = liczba--;
                    Console.Write(tab1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Najmniejszy element w tej tablicy to: " + funkcja(tab1));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer zadania");
            string linia = Console.ReadLine();

            switch (linia) {

                case "1":

                    Zadanie1();
                    break;

                case "2":

                    Zadanie2();
                    break;

                case "3":

                    Zadanie3();
                    break;

                case "4":
                    Zadanie4();
                    break;

                case "5":
                    //Zadanie 5

                    //EBook ksiazka = new EBook(1, 2, DateTime, DateTime, 15, 5);
                    //ksiazka.Zadanie5_Wypiszdane();

                    break;

                default:
                    Console.WriteLine("Brak zadania o podanym numerze");
                    break;
        }
            Console.ReadKey();
        }
    }
}
