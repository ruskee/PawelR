using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    class Sala
    {
        public int numer;
        public int iloscMiejsc;
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = Enumerable.Range(1, 100).ToList();
            IEnumerable<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
            IEnumerable<int> stronaDruga = podzielnePrzez3.Skip(10).Take(10);
            double srednia = lista.Average();
            int suma = lista.Sum();

            foreach (var element in stronaDruga)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Srednia z calej listy to {0}", srednia);
            Console.WriteLine("Srednia z calej listy to {0}", suma);

            List<Sala> sale = lista.Select(
                x => new Sala() { numer = x, iloscMiejsc = 50 }).ToList();

            foreach (var item in sale)
            {
                Console.WriteLine("Sala nr {0} : {1}" + item.numer, item.iloscMiejsc);
            }
            List<int> pojemnosci = sale.Select(x => x.iloscMiejsc).Distinct().ToList();

            foreach (var element in pojemnosci)
            {
                Console.WriteLine(pojemnosci);
            }
        }
    }
}
