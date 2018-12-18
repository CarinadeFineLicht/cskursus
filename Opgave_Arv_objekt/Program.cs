using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Arv_objekt
{
    class Program
    {
        static void Main(string[] args)
        {
            faktura F = new faktura() { Nr = 1, Kunde = "Carina Licht", Dato = DateTime.Now.Date };

            Console.WriteLine(F);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }

    class faktura
    {
        private int nr;

        public int Nr
        {
            get { return nr; }
            set { nr = value; }
        }

        private DateTime dato;

        public DateTime Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private string kunde;

        public string Kunde
        {
            get { return kunde; }
            set { kunde = value; }
        }

        public override string ToString()
        {
            return $"Faktura nr {Nr} fra {Dato:D} til {Kunde}  ";
        }
    }
}
