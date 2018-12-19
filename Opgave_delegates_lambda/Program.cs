using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_delegates_lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine();
            //Skriver index vha. en metode
            Console.WriteLine(a.FindIndex(FindVærdi));
            //Skriver index vha. Lampda med return....
            Console.WriteLine(a.FindIndex((i)=> { return i == 51; }));
            //Skriver index vha. Lampda uden return....
            Console.WriteLine(a.FindIndex(i => i == 51));

            //Skriver wærdierne i listen
            Console.WriteLine();
            a.ForEach(ListVærdi);
            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine();
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
                        
        }

        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
