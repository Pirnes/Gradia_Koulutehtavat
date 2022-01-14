using System;

namespace Tehtava_21_Nopanheitto
{
    class Program
    {
        static void NopanHeitto()
        {
            bool onnistui = false;
            Random noppaluku1 = new Random();
            Random noppaluku2 = new Random();
            int[] nopan1tulokset = new int[5];
            int[] nopan2tulokset = new int[5];
            int[] yt = new int[5];

            while (!onnistui)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        int tulos1 = noppaluku1.Next(1, 7);
                        nopan1tulokset[j] = tulos1;
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        int tulos2 = noppaluku2.Next(1, 7);
                        nopan2tulokset[j] = tulos2;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1  + ". Kierroksen tulokset:");
                    Console.WriteLine("Nopan 1 tulos: " + nopan1tulokset[i]);
                    Console.WriteLine("Nopan 2 tulos: " + nopan2tulokset[i]);
                    Console.WriteLine();
                }
                
                for (int i = 0; i < 5; i++)
                {
                yt[i] = nopan1tulokset[i] + nopan2tulokset[i];
                }
                
                Console.WriteLine("Noppien viiden kierroksen yhteistulos on: " + (yt[0] + yt[1] + yt[2] + yt[3] + yt[4]));
                Console.WriteLine();

                Console.WriteLine("Jos haluat jatkaa heittelyä, paina Enter");
                Console.WriteLine("Jos haluat lopettaa, paina (q)");
                string syote = Console.ReadLine();

                if (syote.Contains("q"))
                {
                    onnistui = true;
                }
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Heitetään noppaa kahdella nopalla viisi kierrosta joiden silmäluku on molemmissa 6.");
            Console.WriteLine("Kun olet valmis paina jotain näppäintä");
            Console.WriteLine();
            Console.ReadKey();

            NopanHeitto();
        }
    }
}
