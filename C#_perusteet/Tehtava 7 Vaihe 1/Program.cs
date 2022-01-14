using System;

namespace Tehtävä_7._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int value1, value2;
        
            Console.WriteLine("Näppäile numero:");
            value2 = int.Parse(Console.ReadLine());

            for (value1 = value2 -1; value1 >= 0; value1--)
            
                Console.WriteLine(value1);
                              
           
        }  
    }
}
