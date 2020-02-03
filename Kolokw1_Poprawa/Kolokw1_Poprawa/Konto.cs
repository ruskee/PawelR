using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokw1_Poprawa
{
    class Konto
    {
        private string _email;
        private readonly string _login;
        private string _haslo;
        private int _punkty;

        public Konto(string Email, string Login, string Haslo, int Punkty)
        {
            _email = Email;
            _login = Login;
            _haslo = Haslo;
            _punkty = 0;
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email.Contains("@"))
                {
                    Console.WriteLine("Mozna zmienic email");
                }
                else Console.WriteLine("Brak mozliwosci zmiany maila");
            }
        }

        public string Haslo
        {
            get
            {
                return _haslo;
            }
            set
            {
                if (_haslo.Length > 6)
                {
                    Console.WriteLine("Mozna zmienic haslo");
                }
            }

        }

        public string Login
        {
            get
            {
                return _login;
            }
        }

        public void ZmianaPunktów(int punkty)
        {
            if (punkty > 0)
            {
                _punkty += punkty;
            }

            if (punkty < 0)
            {
                _punkty += punkty;
            }

        }

        public int Punkty
        {
            get
            {
                return _punkty;
            }

            set
            {
                if(_punkty< 0)
                {
                    Console.WriteLine("Punkty nie moga byc mniejsze od 0");
                }
            }
           
        }
        
    }
}
