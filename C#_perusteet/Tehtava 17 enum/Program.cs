using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tehtava_17_enum
{
    class Program
    {
        enum Kysymyksia {None, LisaaNimi, LisaaIka, NaytaNimi, NaytaIka, Lopetus}

        static Kysymyksia TulostaKysymykset()
        {
            string valinta;
            bool onnistui = false;
            Kysymyksia valinta2 = Kysymyksia.None;

            while (!onnistui)
            {
                Console.WriteLine("Tervetuloa ohjelmaan, valitse toiminto:");
                Console.WriteLine();

                int i = 0;

                foreach (string quest in Enum.GetNames(typeof(Kysymyksia)))
                {

                    if (i > 0)
                    {
                        Console.WriteLine(i + ". " + quest);
                    }
                    i++;
                }
                valinta = Console.ReadLine();
                onnistui = Enum.TryParse(valinta, out valinta2);
            }
            return valinta2;
        }

        static Kysymyksia Nimi()
        {
            valinta2 = 
        }

        static void Main(string[] args)
        {
            TulostaKysymykset();

            Nimi();
        }
    }
}
