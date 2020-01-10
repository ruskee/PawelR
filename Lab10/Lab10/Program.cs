using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int liczba = Convert.ToInt32(Console.ReadLine());

            (int wynik,int reszta) = liczba.Podziel(3);
            Console.WriteLine($"{liczba}/3={wynik}r{reszta}");        

            string text = "Ala ma kota";
            Console.WriteLine(text.Wylicz('a'));
            Console.WriteLine(text.ZliczZnaki('a'));

            string text1 = "Alaa maA kota";
            Console.WriteLine(text1.Wylicz('a', 'A'));
            Console.WriteLine(text1.ZliczZnaki2('a',true));
            Console.WriteLine(text1);
            */

            Reklama reklama = new Reklama(
                "Kup teraz",
                TypOsoby.Dorosly,
                Zainteresowania.Gaming);
        }
    }
}
