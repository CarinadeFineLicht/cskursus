using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Arv_Dyr1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund() { Navn = "Fine hund" };
            h.SigNoget();

            Kat k = new Kat() { Navn = "Sorte kat" };
            k.SigNoget();

            Dyr d = new Kat() { Navn = "DyrKat" };
            d.SigNoget();


            Console.WriteLine();


            List<Dyr> forskelligeDyr = new List<Dyr>() { h, k, new Hund() { Navn = "c" }, new Kat() { Navn = "d" } };

            foreach (Dyr item in forskelligeDyr)

            {

                item.SigNoget();

            }

            Console.WriteLine();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    class Dyr
    {
        public string Navn { get; set; }
        // Metode 
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }


    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }
}
