using System;

namespace hedelmä_taulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int i,i2=1,input1;

            Console.WriteLine("Näppäile numeroilla montako tuotetta haluat lisätä: ");
            input1 = int.Parse(Console.ReadLine());
            string[] fruits = new string[input1];
            decimal[] price = new decimal[input1];
            int[] numb1 = new int[input1];



            for (i = 0; i < input1; i++)
            {
                Console.WriteLine("näppäile " + i2 + ". tuotteen nimi:");
                fruits[i] = Console.ReadLine();
                Console.WriteLine("näppäile " + i2 + ". tuotteen hinta:");
                price[i] = decimal.Parse(Console.ReadLine());
                Console.WriteLine("näppäile " + i2 + ". tuotteen lukumäärä:");
                numb1[i] = int.Parse(Console.ReadLine());
                i2++;
            }
            for (i=0; i <input1; i++)
            {
                Console.WriteLine(fruits[i] + " " + numb1[i] + " kpl maksaa " + (price[i] * numb1[i]) + " € ");
            }
        }
    }
}
