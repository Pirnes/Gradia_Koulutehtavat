using System;

namespace säätilan_kysymykset
{
    class Program
    {
        static void Main(string[] args)
        {

            string sun, water, temperature;

            Console.WriteLine("paistaako aurinko, kyllä (k) ei (e)");
            sun = Console.ReadLine();

            Console.WriteLine("sataako vettä, kyllä (k) ei (e)");
            water = Console.ReadLine();

            Console.WriteLine("onko ulkona lämpötila isompi kuin 0 astetta, kyllä (k) ei (e)");
            temperature = Console.ReadLine();

            if (sun == "k" && water == "k" && temperature == "k")

            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä!");

            }
            else if (sun == "e" && water == "k" && temperature == "k")
            {
                Console.WriteLine("Syksy saapui, lehdet vei tuuli mennessään");
            }
            else if (sun == "e" && water == "e" && temperature == "k")
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen");
            }
            else if (sun == "k" && water == "e" && temperature == "k")
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen");
            }
            else if (sun == "k" && water == "k" && temperature == "e")
            {
                Console.WriteLine("syksy ja pimeys on viemässä voiton");
            }
            else if (sun == "k" && water == "e" && temperature == "e")
            {
                Console.WriteLine("Kevättä rinnassa");
            }
            else if (sun == "e" && water == "e" && temperature == "e")
            {
                Console.WriteLine("Taitaapi olla kaamosta paraimmillaan");
            }
            else
            {
                Console.WriteLine("eipä voisi sää vähempää kiinnostaa =D ");
                Console.ReadKey();
            }
        }
    }
}
