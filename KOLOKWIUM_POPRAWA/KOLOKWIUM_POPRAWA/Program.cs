using System;

namespace KOLOKWIUM_POPRAWA
{
    class Program
    {
        /* Zadanie 1)
         *  Napisz funkcje która przyjmuje wspolrzedne x i y punktu z przedzialu [-1,1]. Funkcja powinna zwrocic wartosc true jesli punkt nalezy do kola o promieniu 1 i srodku w punkcie [0,0]
         *  lub false w przeciwnym wypadku . Wczytaj dane od uzytkownika i przetestuj funkcje [x^2+y^2<=1]
         *  
         *  Zadanie 2)
         *  Napisz funkcje która znajdzie w tablicy jednowymiarowej int najczesciej wystepujacy element. Stworz 10-elem tablice uzupelnij ja przykladowymi danymi i wykonaj funkcje
         *  
         *  Zadanie 3) 
         *  Napisz funkcje ktora przyjmie kwadratową, dwuwymiarowa tablice int i wypisze informacje czy suma elementów ponad przekatna tablicy jest rowna sumie elementów pod przekatna tablicy
         *  Wypelnij tablice np ze wzoru i+j. Wykonaj funkcje. Wprowadz dowolna zmiane w tablicy. Wykonaj funkcje ponownie.Przekatna [0,0] -> [n,n], elementow z przekatnej nie wliczamy
         *  
         *  Zadanie 4) 
         *  Stworz klase KontoBankowe. By utworzyc konto nalezy podaj imię i nazwisko wlasciciela. Podczas tworzenie konta wygeneruj numer skladajacy sie z 26 cyfr. Dane wlasciciela nie mogą
         *  byc zmieniane- utworz odpowidnie zabezpieczenie. Konto musi posiadac pole stan. stan moze byc zmieniany wylacznie za pomoca metody uznanie i obciazenie. utworz zabezpieczenie ktore
         *  nie pozwoli na debet wiekszy niz 100,00zł. Stworz kolelcke liczb Historia, w ktorej zapisane beda kwoty ostatnich 100 operacji (dodatnie lub ujemne). Jezeli wykonane bedzie ponad 100
         *  operacji, napisz najstarszy wpis.
         *  
         *  Zadanie 5)
         *  Napisz funkcje ktora przyjmie dwuwymiarową tablice double i usunie z niej wybrany wiersz lub kolumne. Funkcja powinna przyjmowac tablice, indeks numerowany od 0 a takze wartosc bool - true
         *  jesli usuwamy kolumne, false jesli wiersz. Funkcja powinna zwracac pomniejszona tablice z przepisanymi pozostalymi wartosciami. Stworz przykladowa tablice 3x3x, wypelnij danymi i usun
         *  srodkowy wiersz i pierwsza kolumne
         */
         
            /*
        static int Zad2(int max)
        {
            
            int q=0,w=0,e=0,r=0,t=0;
            int[] tab = new int[10];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                if (tab[i] == 1)
                {
                    q++;
                }

                if (tab[i] == 2)
                {
                    w++;
                }

                if (tab[i] == 3)
                {
                    e++;
                }

                if (tab[i] == 4)
                {
                    r++;
                }

                if (tab[i] == 5)
                {
                    t++;
                }
               
        
            }

        }

    */

            static void Zad3()
        {
            int[,] tab = new int[3, 3];
            int gora = 0;
            int dol = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {                  
                    tab[i, j] = i + j;
                    tab[0, 0] = 9;
                    Console.Write(tab[i, j] + "\t");
                    //dol = tab[1, 2] + tab[1, 3] + tab[2,3];
                    //gora = tab[2, 1] + tab[3, 1] + tab[3, 2];
                }               
                Console.WriteLine();
                
                /*
                   if(gora = dol)
                {
                    return rowne;
                }
                */
                   
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Podaj numer zadania: ");
            int.TryParse(Console.ReadLine(), out int l);

            switch(l)
            {

                case 1:
                    
                    break;

                case 2:

                    int[] tab = new int[10];
                    Random rnd = new Random();

                    for (int i = 0; i < tab.GetLength(0); i++)
                    {
                        tab[i] = rnd.Next(1, 4);
                        Console.Write(tab[i] + "\t");
                    }

                    break;

                case 3:
                    Zad3();
                    break;

                case 4:
                    break;

                case 5:
                    KontoBankowe konto = new KontoBankowe("Jan", "Kowalski", "123456789101112131516", 400.55, 40, -50.00, 0);
                    break;

            }
        }
    }
}
