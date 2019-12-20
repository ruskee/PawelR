using System;

namespace Lab6
{
    class Program
    {
        /*
        static void opiszSamochod(Samochod auto)
        {
            Console.WriteLine(auto.Model + ": Przebieg: " + auto.Przebieg + "km, "
                + "Ilość drzwi: " + auto.IloscDrzwi + ", Waga: " + auto.Waga +"kg VIN: "+ auto.VIN);
        }
        */

          static void opisSerwer(Serwer strona)
        {
            Console.WriteLine(strona.SzybProcesora + "GHz, Łącze: " + strona.Lacze + ", " + strona.Ram + "GB, " + strona.Technologia);
        }

        static void Main(string[] args)
        {/*
            Samochod mojSamochod = new Samochod(
                "Fiat", 100000, 4, 1000);
            Samochod s2 = new Samochod(
                "VW", 10000, 3, 2000);
            Samochod s3 = new Samochod(
                "Audi", 20000, 2, 3000 );
            Samochod nowaMultipla = new Samochod(4, 1000);

            mojSamochod.Waga = 2000;
            //mojSamochod.Przebieg = 300000;
            mojSamochod.ZwiekszPrzebieg(1000);
            opiszSamochod(mojSamochod);
            opiszSamochod(s2);
            opiszSamochod(s3);
            opiszSamochod(nowaMultipla);
            */

            Serwer mojSerwer = new Serwer(
                4, 5, 16, ".NET");
            opisSerwer(mojSerwer);

            Console.ReadKey();
       
        }
    }
}
