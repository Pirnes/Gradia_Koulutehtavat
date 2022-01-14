using System;

namespace Laskeminen2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb, value;
            
            Console.WriteLine("Näppäile luku !");
            numb = int.Parse(Console.ReadLine());
            
            for (value=1;value<11; value++)
           
            {
                Console.Write("  "+numb + " * " + value + " = " + numb * value);
                Console.Write("  "+numb + " / " + value + " = " + numb / value);
                Console.WriteLine("  "+numb + " % " + value + " = " + numb % value);
                
            }
        }
    }
}
