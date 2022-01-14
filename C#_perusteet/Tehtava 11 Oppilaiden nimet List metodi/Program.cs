using System;
using System.Collections.Generic;

namespace _11_oppilaiden_nimet
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            int i, i2 = 1, namenumb;

            Console.WriteLine("Ohjelma kysyy luokan oppilaiden nimiä, voit lisätä niitä haluamasi määrän");
            Console.WriteLine("Jos olet valmis aloittamaan, paina jotain näppäintä: ");
            Console.ReadKey();

            for (i = 0; ; i++)
            {
                Console.WriteLine("Kirjoita " + i2 + ". nimi");
                names.Add(Console.ReadLine());
                i2++;
                Console.WriteLine("haluatko lisätä nimiä lisää: kyllä (k)  ei (e)");
                string choise = Console.ReadLine();
                if (choise == "k")
                {

                }
                else
                {

                    Console.WriteLine("Näppäile montako nimeä haluat tulostaa:");
                    namenumb = int.Parse(Console.ReadLine());

                        for (i = 0; i < namenumb; i++)
                        {
                            Console.WriteLine(names[i]);
                        }
                        break;
                    

                }
            }
        }
    }
}