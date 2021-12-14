using System;
using Elaimet;

namespace _00_hevonen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen ruuna = new Hevonen();
            Console.WriteLine(ruuna.nimi + " " + ruuna.paino);
            ruuna.nimi = "histamiini";
            ruuna.paino = 89;
            Console.WriteLine(ruuna.nimi + " " + ruuna.paino);
        }
    }
}
