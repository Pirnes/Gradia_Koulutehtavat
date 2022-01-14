using System;
using System.Collections.Generic;

namespace Tehtava_18_Tekstinkasittely
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Kirjoita jotain!");
            Console.WriteLine();
            string syote = Console.ReadLine();
            string[] eroteltu = syote.Split(' ');
           
            foreach (string ero in eroteltu)
            {
                Console.WriteLine(ero);
            }
                        
            if (syote.Contains('a'))
            {
                Console.WriteLine("Kirjoittamasi sanan " + (syote.IndexOf('a')+1) + ". kirjain on a- kirjain");
            }
            else
            {
                Console.WriteLine("Kirjoittamasi sana ei sisältänyt lainkaan a- kirjainta");
            }
            
            foreach (string ero in eroteltu)
            {
                foreach (char sana in ero)
                {
                    Console.Write(sana + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (i=0; i < eroteltu.Length; i++)
            { 
                for (int j= eroteltu[i].Length-1; j>=0; j--)
                {
                    Console.Write(eroteltu[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
