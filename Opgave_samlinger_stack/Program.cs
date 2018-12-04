using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_samlinger_stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke b = new Bunke();

            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });

            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });

            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });

            b.Vis();



            var k = b.FjernKort();

            Console.WriteLine();

            Console.WriteLine(k);

            Console.WriteLine();



            b.Vis();

            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
    // Klasse "Kort"
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
    // klasse Bunke som kan bruges til at gemme kort. 
    // , FjernKort der returnerer et kort, og en Vis der viser alle kort i bunken.
    public class Bunke
    {
        // Klassen bør opbevare kort i en privat Stack.
        private Stack<Kort> bunke = new Stack<Kort>();

        // Metode tilføj kort
        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        // Metode fjern kort
        public Kort FjernKort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
        }

        // Vis alle kort
        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }
    }

}
