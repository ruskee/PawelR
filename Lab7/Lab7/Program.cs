using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers; //Biblioteki RandomDataGenerator
using RandomDataGenerator.FieldOptions; 

namespace Lab7
{
    public class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;
        public DateTime wiek;
        public string kraj;

        public Osoba(int id, string imie, string nazwisko, DateTime wiek, string kraj)
        {    
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.kraj = kraj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = Enumerable.Range(100, 150).ToList();
            List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
            double srednia = podzielnePrzez3.Average();
            int suma = podzielnePrzez3.Sum();

            int nrStrony = 1;
            int elemNaStronie = 10;

            
            foreach (var item in podzielnePrzez3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSrednia to {0}", srednia);
            Console.WriteLine("\nSuma to {0}", suma);
            

            //IEnumerable wystarcza do stworzenie fora
            IEnumerable<int> strona = lista.Skip(elemNaStronie * (nrStrony - 1)).Take(elemNaStronie);

            foreach(var item in strona)
            {
                Console.WriteLine(item);
            }
            

            List<Osoba> osoby = lista.Select(
                x => new Osoba()
                {
                    id = x,
                    imie = x.ToString(),
                    nazwisko = "aaa"
                }
                ).ToList();

            osoby[45].nazwisko = "bbb";
            
            List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
            List<string> unikalne_nazwiska = osoby.Select(x => x.nazwisko).Distinct().ToList();
            
            Osoba szukana = osoby.FirstOrDefault(x => x.nazwisko == "ccc");
            Console.WriteLine($"{szukana.id}:{szukana.imie} {szukana.nazwisko}");
            */

            var nameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName()); //Wygenerowanie randomowych danych
            var lastnameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var age = RandomizerFactory.GetRandomizer(new FieldOptionsDateTime());
            var country = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());

            List<Osoba> osoby = Enumerable.Range(100, 150)
                .Select(x =>
                new Osoba(
                    x,
                    nameGen.Generate(),
                    lastnameGen.Generate(),
                    age.Generate().Value,
                    country.Generate()
                    )

                    ).ToList();

            foreach (var item in osoby)
            {

                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");

            }

            /*
           List<Osoba> alfabetycznie = osoby.OrderBy(x=>x.nazwisko).ThenBy(x=>x.imie).ToList();

           foreach (var item in alfabetycznie)
           {

               Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");

           }
           */

        }
    }
}
