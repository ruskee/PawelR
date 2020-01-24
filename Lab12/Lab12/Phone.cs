using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab12
{
    public class Phone
    {
        public void PhoneToFile(Person person, string fileName)
        {
            using (StreamWriter telefon = new StreamWriter(fileName, true))
            {
                telefon.Write($"{person.Phone}");
            }
        }
    }
}
