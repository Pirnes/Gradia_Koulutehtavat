using System;

namespace tehtävä_10_while_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, input;
            while (sum <= 100)
            {
                Console.WriteLine("Näppäile kokonaislukuja: ");
                input = int.Parse(Console.ReadLine());
                sum = input + sum;
            }

            Console.WriteLine("raja on saavutettu!!");
            Console.ReadKey();

        }
    }
}
