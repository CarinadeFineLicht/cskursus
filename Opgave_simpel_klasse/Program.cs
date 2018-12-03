using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_simpel_klasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person
            {
                Efternavn = "Licht",
                Fornavn = "Ditte",
                Fødselsår = 2002
            };

            Console.WriteLine(p1.FuldtNavn());

            Console.WriteLine(p1.EstimeretAlder());


            Person p2 = new Person("Anders", "Licht", 1999);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        // default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //Custom contructor
        public Person(string fornavn, string efternavn, int fødselsår )
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }


}
