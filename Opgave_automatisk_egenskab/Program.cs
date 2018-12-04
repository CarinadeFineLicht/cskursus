using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_automatisk_egenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Fornavn = "Ditte";

            p.Efternavn = "Licht";

            Console.WriteLine(p.FuldtNavn());



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();
            }
        }
    }

    //En klasse
    public class Person
    {
        //Konstructor
        public Person()
        {
        }   

        // Automatisk egenskab
        public string Fornavn { get; set; }

        // Full egenskab
        private String efternavn;
        public String Efternavn
        {
            get { return this.efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    this.efternavn = "";
                }
                else
                {
                    this.efternavn = value;
                }

            }
        }
        // Metode
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
