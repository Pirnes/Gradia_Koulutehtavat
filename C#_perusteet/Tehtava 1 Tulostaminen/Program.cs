using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi;
            int ika;

            Console.WriteLine("Mikä on sinun nimesi ");
            nimi = Console.ReadLine();

            Console.WriteLine("Kuinka vanha olet? ");
            ika = int.Parse(Console.ReadLine());

            Console.WriteLine("Moi " + nimi + ", olet hyvässä " + ika + " vuoden iässä");
            Console.ReadKey();

        }
    }
}
