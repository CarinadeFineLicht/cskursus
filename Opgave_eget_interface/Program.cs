using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_eget_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();
            foreach (var item in array)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    //For at kunne gemme objekter af klasserne på samme konsistente måde, og give mulighed for at benytte polymorfi,
    //skal du skabe et interface kaldet IDbFunktioner, der udelukkende består af metoden void Gem()
    interface IDbFunktioner
    {
        void Gem(); 
    }

    class Hund : IDbFunktioner 
    {
        public string Navn { get; set; }

        // klassen implementerer interfacet og metoden implementeres ved at der skrives på consol ”Gemmer hund…”
        public void Gem()
        {
            Console.WriteLine("Gemmer hund..");
        }
    }

    class Ubåd : IDbFunktioner 
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        // klassen implementerer interfacet og metoden implementeres ved at der skrives på consol ”Gemmer ubåd…”
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd..");
        }
    }

}
