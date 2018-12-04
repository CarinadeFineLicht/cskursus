using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_samlinger_simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            //skab en instans af en generisk liste som kan arbejde med en Person.
            List<Person> lst1 = new List<Person>();

            //Tilføj 3 forskellige personer:
            lst1.Add(new Person() { Id = 1, Navn = "Carina" });
            lst1.Add(new Person() { Id = 2, Navn = "Jeanette" });

            // Kan også tilføjes således: (her tilføjes 3. person)
            Person p1 = new Person();
            p1.Id = 3;
            p1.Navn = "Lars";
            lst1.Add(p1);

            // Skriv dem ud i en ForEach
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Id + " " + item.Navn);
            }

            // generisk Dictionary hvor nøglen er en int og værdien af en instans af en Person. T
            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();

            // Tilføj 3 forskellige personer
            lst2.Add(1, new Person() { Id = 1, Navn = "Michael" });
            lst2.Add(2, new Person() { Id = 2, Navn = "Torben" });
            lst2.Add(3, new Person() { Id = 3, Navn = "Poul" });

            //  find en person udfra nøglen (lst[x]).
            var p = lst2[3];

            Console.WriteLine(p.Id + " " + p.Navn);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

class Person
    {
        
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
