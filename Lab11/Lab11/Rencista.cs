using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Rencista
    {
        private DateTime _dataZakonczeniaRenty;

        public Rencista(DateTime DataZakonczeniaRenty)
        {
            _dataZakonczeniaRenty = DataZakonczeniaRenty;
        }

        public bool ZwolnienieZOplaty { get; set; }
        public DateTime DataZakonczeniaRenty
        {
          
            get
            {
                return _dataZakonczeniaRenty;
            }

            set
            {
                if(DateTime.Now > DataZakonczeniaRenty.Date)
                {
                    Console.WriteLine("Okres renty zakonczyl sie");
                }
                else
                {
                    Console.WriteLine("Renta nadal przysluguje pasazerowi");
                }
            }
        }

    }
}
