using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    public class Samochod
    {
        private static int IloscModeli = 0;

        public readonly string Model;      
        
        public int VIN { get; private set; }
        public int Przebieg { get; private set; }
        public void ZwiekszPrzebieg(int dystans)
        {
        if (dystans < 0)
        {
            throw new ArgumentException("Dystans nie moze byc ujemny");
        }
        }

        private Samochod()
        {
            VIN = IloscModeli++;
        }
      
        private int _przebieg;
        /*
        public int Przebieg
        {
            get { return _przebieg; }
            set
            {
                if (value > Przebieg)
                {
                    _przebieg = value;
                }
            }
        }
        */

        public int IloscDrzwi { get; private set; }

        private int _waga;


        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {             
                _waga = value;
                if(_waga < 0) // Można także rzucić wyjątek
                {
                    _waga = 0;
                }
            }
        }
        void SetWaga(int value)
        {
            _waga = value;
        }
  
            public Samochod(string model, int przebieg, int iloscDrzwi, int waga)
            {
                Model = model;
                Przebieg = przebieg;
                IloscDrzwi = iloscDrzwi;
                Waga = waga;
                VIN = IloscModeli++;
            }

        public Samochod(int id)
        {
            //var dane = Baza.GetById(id);
            //Przebieg = dane.Przebieg;
        }

        public Samochod(int iloscDrzwi,int waga)
            :this("Multipla",0, iloscDrzwi,waga)
        {/* Tego nie musi już być dzięki this powyzej
            Model = "Multipla";
            Przebieg = 0;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
           */
        }

        }
    }
