using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_fejllog_simpel
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }  
            }
            

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   

        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er: " + res);
        }

    }
}
