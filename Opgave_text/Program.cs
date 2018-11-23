using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_text
{
    class Program
    {
        static void Main(string[] args)
        {

            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";

            string navn = forNavn + " " + efterNavn;
            Console.WriteLine($"Navn: {navn}");

            Console.WriteLine($"Store bogstaver: {navn.ToUpper()}");

            Console.WriteLine($"Små bogstaver: {navn.ToLower()}");

            string delvis = navn.Substring(7, 4);
            Console.WriteLine($"Delvis streng: {delvis}");

            Console.WriteLine($"\\n : new line");
            Console.WriteLine($"\\r : Flyt til start af linie");
            Console.WriteLine($"\\t : Tabullering");
            
            Console.WriteLine($"Mærkelige tegn: {forNavn + "\n\r " + efterNavn}");

            System.IO.File.WriteAllText("c:\\temp\\text.txt", navn);
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
