using System;

namespace ConsoleApp2Opgave_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            FilTyper fil = FilTyper.csv;

            Console.WriteLine($"Udskriver strengen:");
            Console.WriteLine(fil);
            Console.WriteLine("");
            Console.WriteLine($"Udskriver værdien:");
            Console.WriteLine((int)fil);


            Person pers;
            pers.Id = 1;
            pers.Navn = "Carina";
            pers.M_K = Køn.Kvinde;
            

            Console.WriteLine($"Person: {pers.Id + " " + pers.Navn + " " + pers.M_K}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public enum FilTyper
    {
        csv,
        pdf,
        txt
    }
    public struct Person
    {
        public int Id;
        public string Navn;
        public Køn M_K;
    }
    public enum Køn
    {
        Kvinde,
        Mand
    }
}
