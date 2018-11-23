using System;

namespace TestKode
{
    class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine("test");
            Console.ReadKey();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

    }
}
