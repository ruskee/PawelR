using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Kolokwium2_Poprawa;

namespace Kolokwium2_Poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            string d;
            Console.WriteLine("Podaj numer zadania: ");
            d = Console.ReadLine();

            switch (d)
            {
                case "1":
                    List<Piosenka> Playlista = new List<Piosenka>();
                    Playlista.Add(new Piosenka("Tytul1", "Autor1", new TimeSpan(0, 4, 50)));
                    Playlista.Add(new Piosenka("Tytul2", "Autor2", new TimeSpan(0, 3, 50)));
                    Playlista.Add(new Piosenka("Tytul3", "Autor3", new TimeSpan(0, 2, 50)));
                    Playlista.Add(new Piosenka("Tytul4", "Autor4", new TimeSpan(0, 3, 40)));

                    foreach(var item in Playlista)
                    {
                        //Console.WriteLine($"Tytul: {Playlista.Dlugosc}, Autor: {Playlista.Autor}, Dlugosc: {Playlista.Dlugosc}");
                    }

                    TimeSpan czasLaczny;
                    foreach(var item in Playlista)
                    {
                        //czasLaczny += Playlista.Dlugosc;
                    }

                    Playlista.Select(x => x).OrderBy(x=>x.Tytul);

                    Playlista.Select(x => x).OrderBy(x => x.Autor);
                 
                    break;


                case "2":
                    int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    ExtensionMet.Metoda(tab);
                    for(int i = 0; i < tab.GetLength(0); i++)
                    {
                        Console.WriteLine(tab[i]);
                    }
                    break;

                case "3":

                    break;


                case "4":

                    break;

                 
            }
        }
    }
}
