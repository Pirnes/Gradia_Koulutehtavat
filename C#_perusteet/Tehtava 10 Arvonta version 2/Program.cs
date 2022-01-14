    using System;

namespace Arvonta_version_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int lottery,guess;
            Random rand1 = new Random();
            lottery = rand1.Next(1, 101);
            

            Console.WriteLine("Yritä arvata luku 0 - 100 väliltä: ");
            string guess1 = Console.ReadLine();
            guess = int.Parse(guess1);

            while (guess1 != "l" && guess != lottery)
            {
                Console.WriteLine("Ei osumaa, yritä uudelleen!");
                guess1 = Console.ReadLine();
                if (guess1 == "l")
                {
                    Console.WriteLine("lopetit ohjelman.");
                    break;
                }
                guess = int.Parse(guess1);
            }
            if (guess == lottery)
            {
                Console.WriteLine("And we have a winner!! You got it!");
            }
        }

    }
}