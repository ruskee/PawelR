using System;

namespace Lab11
{
    class Program
    {
        static double ObliczCeneBiletu(object pasazer)
        {
            /*
            if (pasazer is Dziecko dziecko)
            {
                //var dziecko = (Dziecko)pasazer;
                Console.WriteLine($"To jest dziecko. ma znizke {dziecko.Znizka}");
            }
            else if (pasazer is OsobaStarsza oStarsza)
            {
                Console.WriteLine("To jest osoba starsza");
                if (oStarsza.ZwolnienieZOplaty)
                {
                    Console.WriteLine("Ma darmowy przejazd");
                }
            }
            */

            switch (pasazer)
            {
                case Dziecko d:
                    {
                        Console.WriteLine($"To jest dziecko. Ma znizke {d.Znizka}");
                        break;
                    }

                case OsobaStarsza os when os.ZwolnienieZOplaty:
                    {
                        Console.WriteLine("To jest osoba starsza." + " Ma darmowe przejazdy");
                        break;
                    }

                case OsobaStarsza os:
                    {
                        Console.WriteLine("To jest osoba starsza");
                        if (os.ZwolnienieZOplaty)
                        {
                            Console.WriteLine("Ma darmowy przejazd");
                        }
                        break;
                    }

                case null:
                    {
                        Console.WriteLine("Nie wiem co to jest");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Default");
                        break;
                    }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            /*
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplaty = true };

            ObliczCeneBiletu(pasazer);
            ObliczCeneBiletu(dziecko);
            ObliczCeneBiletu(emeryt);
            ObliczCeneBiletu("pasazer");
            ObliczCeneBiletu(null);
            */

            //var rencista1 = new Rencista() { ZwolnienieZOplaty = true, DataZakonczeniaRenty = new DateTime(2020,1,15) };
            //var rencista2 = new Rencista() { ZwolnienieZOplaty = true, DataZakonczeniaRenty = new DateTime(2020,2,19) };
            //ObliczCeneBiletu(rencista);

            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "12312312",
                ZwolnienieZOplaty = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/photos/Zdjecie.jpg"
            };
            /*
            (string legitka, bool znizka, DateTime dataUr, string fotka) = osoba.ZwrocWszystkieDane();//Mozliwosc 1

            var (legitymacja, obnizka, dataUrod, zdjecieRencisty) = osoba.ZwrocWszystkieDane();//Mozliwosc 2
            //(var legitymacja, var obnzika, var dataUrod, var zdjecieRencisty) = osoba.ZwrocWszystkieDane();
            var temp = osoba.ZwrocWszystkieDane();
            Console.WriteLine($"{temp.nrLegitymacji} {temp.zwolnienie} {temp.urodziny} {temp.zdjecie}");//Mozliwosc 3

            (_, bool zwolnienie, DateTime data, string fotografia) = osoba.ZwrocWszystkieDane();//Z wyrzuceniem nrLegitymacji
            */

            var (nrLegitymacji, zwolnienie, dataUr, zdjecie) = osoba;
            var (nrLeg, fotka) = osoba;
            var (Leg, zwol, zdj) = osoba;

            var Dziecko = new Dziecko(15);
        }
    }
}
