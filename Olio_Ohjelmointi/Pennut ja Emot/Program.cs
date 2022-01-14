using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elaimet;

namespace Pennut_ja_Emot
{
    class Program
    {

        static void Main(string[] args)
        {
            Kissa emo = new Kissa("Ensimmäinen emokissa");
            emo.LisaaPentu("ekapentu   ",1);
            emo.LisaaPentu("tokapentu  ",2);
            emo.LisaaPentu("kolmaspentu",3);

            Kissa emo2 = new Kissa("Toinen emokissa");
            emo2.LisaaPentu("neljäspentu", 4);
            emo2.LisaaPentu("viidespentu", 5);
            emo2.LisaaPentu("kuudespentu", 6);
            emo2.LisaaPentu("kukkuravidd", 99);

            foreach (Kissa kissa in emo.Pennut)
            {
                Console.Write("Pentujen lukumäärä: " + emo.Pennut.Count() + " kpl. ");
                Console.WriteLine("Pennun nimi: " + kissa.PalautaElaimenNimi() + ". Pennun ikä: " + kissa.PalautaElaimenIka() + ". Emon nimi: " + kissa.Emo.PalautaElaimenNimi());
            }

            Console.WriteLine("------------------------------");

            foreach (Kissa kissa in emo2.Pennut)
            {
                Console.Write("Pentujen lukumäärä: " + emo2.Pennut.Count() + " kpl. ");
                Console.WriteLine("Pennun nimi: " + kissa.PalautaElaimenNimi() + ". Pennun ikä: " + kissa.PalautaElaimenIka() + ". Emon nimi: " + kissa.Emo.PalautaElaimenNimi());
            }


        }
    }
}
