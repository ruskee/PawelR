using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_Poprawa
{
    public class Cytat
    {
        public Cytat(string autor, string tytul, DateTime dataWydania, string miejsceWydania, string wydawnictwo)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            MiejsceWydania = miejsceWydania;
            Wydawnictwo = wydawnictwo;
        }

        public string Autor { get; set; }
        public string Tytul { get; set; }
        public DateTime DataWydania { get; set; }
        public string MiejsceWydania { get; set; }
        public string Wydawnictwo { get; set; }

        public void Deconstruct1(out string autor, out DateTime dataWydania)
        {
            autor = Autor;
            dataWydania = DataWydania;
        }

        public void Deconstuct2(out string tytul, out string autor, out string miejsceWydania, out string wydawnictwo, out DateTime dataWydania)
        {
            autor = Autor.Substring(1, 5);
            dataWydania = DataWydania;
            tytul = Tytul;
            miejsceWydania = MiejsceWydania;
            wydawnictwo = Wydawnictwo;
        }
    }
}
