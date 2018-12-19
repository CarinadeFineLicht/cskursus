using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Events_Filwatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w =
            new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed - Skriv via metode
            w.Changed += W_Changed;

            // Skriv via lambda
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };


            w.Renamed += W_Rename;
            w.Renamed += (s, e) => { Console.WriteLine("ændret " + e.FullPath); };


            // Kør evig løkke, som afvikler kode, når hændelse forekommer
            do
            {

            } while (true);

        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }

        private static void W_Rename(object sender, System.IO.RenamedEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }
}
