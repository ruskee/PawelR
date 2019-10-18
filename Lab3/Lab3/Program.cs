using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = string.Empty;
            int suma = 0, licznik = -1;
            while(tekst != "0")
            {
                tekst = Console.ReadLine();
                int ocena;
                bool czyPrzekonwertowano = int.TryParse(tekst, out ocena);
                if (czyPrzekonwertowano)
                {
                    suma += ocena;
                    licznik++;
                }
                else
                {
                    Console.WriteLine("Podano niepoprawną liczbe");
                }
            }

            float srednia = (float)suma / licznik;
            Console.WriteLine("Srednia wynosi: ");
            Console.WriteLine(srednia);
        }
    }
}
