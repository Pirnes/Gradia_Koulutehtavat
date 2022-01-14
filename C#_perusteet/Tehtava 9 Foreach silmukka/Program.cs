using System;

namespace Foreach_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,numbsum=0,numbavg=0;
            int[] numb = new int[5];

            Console.WriteLine("Näppäile 5 kpl numeroita: ");
            
            for (i = 0;i < 5; i++)
            {
                numb[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Näppäilemäsi numerot olivat siis: ");
            
            foreach (int ka in numb)
            {
                Console.Write(ka + " ");
                numbsum = numbsum + ka;
            }
            numbavg = numbsum / 5;
            Console.WriteLine("Antamiesi lukujen keskiarvo on: " + numbavg);
        }
    }
}
