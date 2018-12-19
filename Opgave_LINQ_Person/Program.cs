using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_LINQ_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            Console.WriteLine();
            //Sorter efter navn og udskriv
            var res1 = people.OrderBy(i => i.Name);
            var res1l = from person in people orderby person.Name select person;
            //foreach (var person in res1)
            //    Console.WriteLine(person.Name + " " + person.Gender);


            Console.WriteLine();
            //Sorter efter køn og derefter navn og udskriv
            var res2 = people.OrderBy(i => i.Gender).ThenBy (i => i.Name);
            var res21 = from person in people orderby person.Gender, person.Name select person;
            //foreach (var person in res2)
            //    Console.WriteLine(person.Name + " " + person.Gender);
            //Console.WriteLine(
            //    );
            //foreach (var person in res21)
            //    Console.WriteLine(person.Gender + " " + person.Name);


            Console.WriteLine();
            //Filtre og udskriv således, at der kun vises personer hvor height < 170
            //var res3 = people.Where(i => i.Height < 170);
            var res31 = from person in people where person.Height < 170 orderby person.Height select person;
            //foreach (var person in res31)
            //    Console.WriteLine(person.Height + " " + person.Name);


            Console.WriteLine();
            //Filtre og udskriv således, at der kun vises personer hvor height = < 170, isHealthy = true
            var res4 = people.Where(i => i.Height < 170 && i.IsHealthy);
            var res41 = from person in people where person.Height < 170 && person.IsHealthy orderby person.Height select person;
            foreach (var person in res41)
                Console.WriteLine(person.Height + " " + person.Name);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
