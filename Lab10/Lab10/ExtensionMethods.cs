using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab10
{
    static public class ExtensionMethods
    {
        public static(int,int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }

        public static int Wylicz(this string tenString,char szukanaLitera)
        {
            int ile = 0;
            for(int i=0; i < tenString.Length; i++)
            {
                if (tenString[i] == szukanaLitera)
                {
                    ile++;
                }                
            }
            return ile;
        }

        public static int Wylicz(this string wyraz, char szukanaLitera1, char szukanaLitera2)
        {
            int ile = 0;
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (wyraz[i] == szukanaLitera1)
                {
                    ile++;
                }

                if (wyraz[i] == szukanaLitera2)
                {
                    ile++;
                }
            }
            return ile;
        }

        public static int ZliczZnaki(this string text, char character) //Z wykorzystaniem Linq
        {
            return text.Where(x => x.Equals(character)).Count();
        }

        public static int ZliczZnaki(this string text, char character, bool caseInvariant = true)
        {
            if (!caseInvariant)
            {
                text.ZliczZnaki(character);
            }

            if (char.IsLetter(character))
            {
                return text.ZliczZnaki(char.ToLower(character)) + text.ZliczZnaki(char.ToLower(character));
            }

            else
            {
                return text.ZliczZnaki(character);
            }
        }

        public static int ZliczZnaki2(this string text, char character, bool caseInvariant = true)
        {
            if (caseInvariant)
            {
                text = text.ToLower();
                character = char.ToLower(character);
            }
            return text.ZliczZnaki(character);
        }

        public static int SumaTypowOsob(this TypOsoby typ)
        {         
            return Enum.GetValues(typeof(TypOsoby)).Cast <TypOsoby>().Sum(x => (int)x);          
        }

        public static int SumaEnum<T>(this T typ) where T: System.Enum //Combos na kolokwium (4 w 1)
        {
            return Enum.GetValues(typeof(T)).Cast<int>()
        }
    }
}
