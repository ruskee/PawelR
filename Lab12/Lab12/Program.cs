using System;
using System.Linq;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("dane.txt");

            var sortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);

            foreach(var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.LastName}");
            }

            Writer writer = new Writer();
            writer.WriteToFile(sortedPeople.First(), "result.txt");

            Phone phone = new Phone();
            phone.PhoneToFile(sortedPeople.First(), "phone_one.txt");

            /* 
            var telefon = reader.ReadPeople("phone_list.txt");

            var sorted = people.Take(10);
            foreach(var person in sorted)
            {
                Console.WriteLine($"{person.Phone}");
            }
            */
        }
    }
}
