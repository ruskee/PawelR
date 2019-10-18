using System;

namespace Lab3
{
    class Program
    {

        static double ObliczSrednia(string nazwa)
        {
            string tekst = string.Empty;
            double suma = 0;
            int licznik = 0;

            while (tekst != "0")
            {
                Console.WriteLine("Wpisz ocene dla: " + nazwa);
                tekst = Console.ReadLine();
                double ocena;
                bool czyPrzekonwertowano = double.TryParse(tekst, out ocena);
                if (czyPrzekonwertowano)
                {
                    if (ocena > 0 && ocena <= 5)
                    {
                        suma += ocena;
                        licznik++;
                    }
                    else
                    {
                        Console.WriteLine("To nie jest poprawna liczba");
                    }
                }
                else
                {
                    Console.WriteLine("Podano niepoprawną liczbe");
                }
            }

            double wynik = suma / licznik;
            Console.WriteLine("Srednia z " + nazwa + " to: " + wynik);
            return wynik;

        }
        static void Main(string[] args)
        {
            string[] przedmioty = { "P1", "BOIO", "PTC" };
            double[] srednie = new double[przedmioty.Length];

            for(int i = 0; i < przedmioty.Length; i++)
            {
                srednie[i] = ObliczSrednia(przedmioty[i]);
            }
            double sredniaCalkowita = 0;
            
            foreach(double sredniaCzastkowa in srednie)
            {
                sredniaCalkowita += sredniaCzastkowa;
            }
            Console.WriteLine("Srednia calkowita: " + sredniaCalkowita / przedmioty.Length);
            
         
        }
    }
}
