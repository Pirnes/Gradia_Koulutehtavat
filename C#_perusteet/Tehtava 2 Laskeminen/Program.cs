using System;

namespace _2._Laskeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, d = 4, e = 5;
            int x;

            Console.Write("Anna muuttujalle x arvo väliltä 1 - 10  ");
            x = int.Parse(Console.ReadLine());

            Console.Write("1 * x = " + a * x);
            Console.Write("    1 / x = " + a / x);
            Console.WriteLine("    1 % x = " + a % x);

            Console.Write("2 * x = " + b * x);
            Console.Write("    2 / x = " + b / x);
            Console.WriteLine("    2 % x = " + b % x);

            Console.Write("3 * x = " + c * x);
            Console.Write("    3 / x = " + c / x);
            Console.WriteLine("    3 % x = " + c % x);

            Console.Write("4 * x = " + d * x);
            Console.Write("    4 / x = " + d / x);
            Console.WriteLine("    4 % x = " + d % x);

            Console.Write("5 * x = " + e * x);
            Console.Write("    5 / x = " + e / x);
            Console.WriteLine("    5 % x = " + e % x);

            Console.ReadKey();



        }
    }
}
