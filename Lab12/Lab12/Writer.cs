using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Lab12
{
    public class Writer
    {
        public void WriteToFile(Person person,string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"[{person.Id}] {person.Name} {person.LastName}");
            }           
        }

        // Zadanie 1 - Metoda ktora ma za zadanie tworzyc nowe podzielone co max 10 telefonow pliki.
        public void WriteToFileOnlyPhones(IEnumerable<Person> persons)
        {
            List<Person> mojaLista = persons.ToList();

            string fileName;
            string prefix = "result-10-numerow-part-";
            int part = 0;

            while (mojaLista.Count > part * 10)
            {
                fileName = prefix + ++part + ".txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    var nastepneLinie = mojaLista.Skip((part - 1) * 10).Take(10);

                    foreach (var item in nastepneLinie)
                    {
                        writer.Write($"[{item.Phone}, {item.LastName}]");
                    }
                }
            }
        }

        // Zadanie 2 - Metoda ktora ma tworzyc nowe pliki dla kazdej literki nazwiska.
        public void WriteTheLetters(IEnumerable<Person> persons)
        {
            List<Person> lista = persons.ToList();
            string fileName;

            for (int i = 65; i <= 90; i++)
            {
                char litera = Convert.ToChar(i);
                fileName = "nazwiska-dla-literki-" + litera + ".txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var query = lista.Where(x => x.LastName[0].Equals(litera)).ToList();

                    foreach (var item in query)
                        writer.WriteLine($"[{item.LastName}, {item.Name}]");
                }
                if (new FileInfo(fileName).Length <= 0)
                    File.Delete(fileName);
            }
        }
    }

}
