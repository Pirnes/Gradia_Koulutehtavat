using System;

namespace Lukupyramidi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i,i2,i3;

            Console.WriteLine("näppäile numero: ");
            i2 = int.Parse(Console.ReadLine());

            for (i = 1; i <= i2; i++)
            {
                for (i3 = 1; i3 <= i; i3++)
                {
                    Console.Write(i3);
                }
                Console.WriteLine();
            }
        }
    }
}
