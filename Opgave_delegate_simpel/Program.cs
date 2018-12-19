using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_delegate_simpel
{
    // definere en delegate kaldet MinDelegate1 der kan holde referencer til void metoder
    // med en enkelt streng som argument. Placer definition på namespace niveau.
    //public delegate void MinDelegate1(string t);

    class Program

    {
        static void Main(string[] args)
        {
            //skab en ny instans af MinDeletage1 kaldet f1. Benyt new-syntaksen.
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            // Hvis jeg bruger Action slipper man for at def. delegate
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("test 1");

            //MinDelegate1 f2 = MinSkrivTilConsole;
            Action<string> f2 = MinSkrivTilConsole;
            f2("test 2");

            //f3 delegate indeholder her 2 metoder
            //MinDelegate1 f3 = MinSkrivTilConsole;
            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test 3");


            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            //Tester om delegate indeholder nogen metoder
            if (f3 != null)
                f3("ikke null");
            else
                Console.WriteLine("f3 er der ikke");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        // tom konsol app med følgende metode i Program-klassen
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }

    }
        
}
