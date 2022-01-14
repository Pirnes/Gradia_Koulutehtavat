using System;

namespace _07_Mitta
{
    class Program
    {
        static void Main(string[] args)
        {
            Mittari m = new Mittari();
            while (!m.Taynna())
            {
                Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());
                m.Lisaa();
            }

            Console.WriteLine("Täynnä! Mitta: " + m.Mitta());
            m.Vahenna();
            Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());
        }
    }
}
