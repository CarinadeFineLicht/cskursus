using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Dato_Tid
{
    class Program
    {
        static void Main(string[] args)
        {

            System.DateTime d1 = DateTime.Now;
            Console.WriteLine($"Maskin dato: {d1}");

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);


            DateTime d2, d3;
            d2 = new DateTime(2018, 12, 24, 00, 00, 00);
            d3 = new DateTime(2017, 12, 24, 00, 00, 00);
            TimeSpan t1 = d2.Subtract(d3);
            Console.WriteLine($"d2 minus d3: {t1.Days}");

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);
            Console.WriteLine($"Antal timer i min.: {t2.TotalMinutes}");

            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);
            Console.WriteLine($"Antal min.: {t3.Minutes}");

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);
            Console.WriteLine($"t2 minus t3 min.: {t4.TotalMinutes}");
            Console.WriteLine($"t2 minus t3 timer: {t4.TotalHours}");

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);
            Console.WriteLine($"t2 plus t3 min.: {t5.TotalMinutes}");
            Console.WriteLine($"t2 plus t3 timer: {t5.TotalHours}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
