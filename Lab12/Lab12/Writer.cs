using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab12
{
    public class Writer
    {
        public void WriteToFile(Person person,string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write($"[{person.Id}] {person.Name} {person.LastName}");
            }           
        }
    }
}
