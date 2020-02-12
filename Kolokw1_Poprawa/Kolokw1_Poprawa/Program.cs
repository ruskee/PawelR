using System;

namespace Kolokw1_Poprawa
{
    class Program
    {
        public static double Zad1(double a, double b, double c)
        {
            return a * b * c;
        }

        public static void Zad2(int[] tab)
        {
            float zliczanie = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                zliczanie += tab[i];
            }
            double srednia = zliczanie / 10;

            double odchylenie = 0;
            double odchylenie1 = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                odchylenie += Math.Pow((tab[i] - srednia), 2.0);
            }

            odchylenie1 = Math.Sqrt(odchylenie/10);

            Console.WriteLine("Odchylenie wynosi: " + odchylenie1);
        }

        public static void Zad3(int [,] tab)
        {

        }

        //Zad4
        public static void Zad4_Otworz(int PIN)
        {
            if (PIN == 1234)
            {
                Console.WriteLine("Otwarcie drzwi");
            }
        }

        public static void Zad4_Otworz(string password)
        {
            if (password == "password")
            {
                Console.WriteLine("Otwarcie drzwi");
            }
        }

        public static void Zad4_Otworz(DateTime data)
        {
            if (data >= new DateTime(2020, 5, 1) && data <= new DateTime(2020, 5, 3))
            {
                Console.WriteLine("Otwarcie drzwi");
            }
        
        }     

        static void Main(string[] args)
        {
            Console.Write("Podaj numer zadania: ");
            string linia = Console.ReadLine();

            switch (linia)
            {

                case "1":
                    //Zad1
                    Random rnd = new Random();
                    double a = rnd.NextDouble();
                    double b = rnd.NextDouble();
                    double c = rnd.NextDouble();
                    Console.WriteLine("Prawdopodobienstwo wynosi: " + Zad1(a, b, c));
                    break;

                case "2":
                    //Zad2
                    int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    Zad2(tab);
                    break;


                case "4":
                    //Zad4
                    Zad4_Otworz(1234);
                    Zad4_Otworz("password");
                    Zad4_Otworz(new DateTime(2020, 5, 4));
                    break;
                case "5":

                    //Zad5
                    Konto konto = new Konto("jannowak@gmail.com", "jannowak", "jannowak123", 50);

                    konto.ZmianaPunktów(-500);
                    konto.ZmianaPunktów(1000);
                    Console.WriteLine($"Dane: Mail: {konto.Email} Login: {konto.Login} Haslo: {konto.Haslo} Ilosc punktów: {konto.Punkty}");
                    break;
            }



        }
    }
}
    
