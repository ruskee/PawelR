using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = string.Empty;
            while(tekst != "0")
            {
                tekst = Console.ReadLine();
                int ocena;
                bool czyPrzekonwertowano = int.TryParse(tekst, out ocena);
            }
        }
    }
}
