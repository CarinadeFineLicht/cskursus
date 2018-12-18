using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Interface_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 15, Navn = "Andy" };
            hunde[2] = new Hund() { Alder = 14, Navn = "Lady" };
            hunde[3] = new Hund() { Alder = 14, Navn = "Ladi" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Hund other)
        {
            if (this.Alder > other.Alder)
                return 1;
            if (this.Alder > other.Alder)
                return -1;
            return String.Compare(this.Navn, other.Navn);
        }
    }
}
