using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot
{
    class Program
    {
        private static int Pienin(int eka, int toka, int kolmas)
        {
            int[] small = new int[3] { eka, toka, kolmas };
            Array.Sort(small);
            return small[0];
            // oma koodi 
        }


        private static int Suurin(int eka, int toka, int kolmas)
        {
            int[] big = new int[3] { eka, toka, kolmas };
            Array.Sort(big);
            Array.Reverse(big);
            return big[0];

            // oma koodi 
        }


        static void Main(string[] args)
        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            bool uudestaan = true;

            do
            {
                Console.Write("Anna eka luku:");
                if (int.TryParse(Console.ReadLine(), out luku1))
                {
                    uudestaan = false;
                }
                else
                {
                    Console.WriteLine("Anna eka luku numeroina!");
                }
            }
            while (uudestaan);
            
            uudestaan = true;
           
            do
            {
                Console.Write("Anna toka luku:");
                if (int.TryParse(Console.ReadLine(), out luku2))
                {
                    uudestaan = false; 
                }
                else
                {
                    Console.WriteLine("Anna toka luku numeroina!");
                }
            }
            while (uudestaan);
            uudestaan = true;

            do
            {
                Console.Write("Anna kolmas luku:");
                if (int.TryParse(Console.ReadLine(), out luku3))
                {
                    uudestaan = false;
                }
                else
                {
                    Console.WriteLine("Anna kolmas luku numeroina!");
                }
            }
            while (uudestaan);
            uudestaan = true;

            pieninLuku = Pienin(luku1, luku2, luku3);
            suurinLuku = Suurin(luku1, luku2, luku3);

            Console.WriteLine("Pienin luku on: " + pieninLuku + " ja suurin luku on: " + suurinLuku);

            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3. 

            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 
        }
    }
}