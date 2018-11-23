using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int ca;
            ca = 10;
            ca++;
            Console.WriteLine($"Mit tal {ca}");
            ca--;
            Console.WriteLine($"Mit tal {ca}");
            ca += 20;
            Console.WriteLine($"Mit tal {ca}");


            double cfl = 12.5;
            cfl++;
            Console.WriteLine($"{cfl}");
            cfl--;
            Console.WriteLine($"{cfl}");
            cfl *= 2;
            Console.WriteLine($"{cfl}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
