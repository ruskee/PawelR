using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_Poprawa
{
    public interface IKopiarka : ISkaner, IDrukarka
    {
         void Kopiuj(string a);
    }
}
