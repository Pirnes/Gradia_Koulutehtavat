using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elaimet;

namespace Oliot_listaan_ja_logiikkaharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int elaintenmaara = 0;
            bool onnistui = false;
            Random randomi = new Random();
            List<Elain> Elainlista = new List<Elain>();

            while (!onnistui)
            {
                Console.WriteLine("Hei, harjoitusta varten luodaan muutama eläinolio, montako eläinoliota haluat luoda?");
                string maara = Console.ReadLine();

                if (int.TryParse(maara, out int tulos))
                {
                    elaintenmaara = tulos;
                    onnistui = true;
                }
            }

            //for (int i = 0; i <= elaintenmaara-1; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        if (i % 4 == 3)
            //        {
            //            Hevonen polle = new Hevonen();
            //            polle.AsetaElaimenNimi("Polle");
            //            polle.AsetaElaimenIka(18);
            //            polle.AsetaOnLihanSyoja(false);
            //            polle.AsetaImetyskyky(true);
            //            Elainlista.Add(polle);
            //            Console.WriteLine("Hevonen");
            //        }

            //        else
            //        {
            //            Kissa misse = new Kissa();
            //            misse.AsetaElaimenNimi("Misse");
            //            misse.AsetaElaimenIka(5);
            //            misse.AsetaOnLihanSyoja(true);
            //            misse.AsetaImetyskyky(true);
            //            Elainlista.Add(misse);
            //            Console.WriteLine("Kissa");
            //        }
            //    }

            //    if (i % 3 == 1)
            //    {
            //        if (i % 4 == 3)
            //        {
            //            Hevonen polle = new Hevonen();
            //            polle.AsetaElaimenNimi("Polle");
            //            polle.AsetaElaimenIka(18);
            //            polle.AsetaOnLihanSyoja(false);
            //            polle.AsetaImetyskyky(true);
            //            Elainlista.Add(polle);
            //            Console.WriteLine("Hevonen");
            //        }

            //        else
            //        {
            //            Koira musti = new Koira();
            //            musti.AsetaElaimenNimi("Musti");
            //            musti.AsetaElaimenIka(9);
            //            musti.AsetaOnLihanSyoja(true);
            //            musti.AsetaImetyskyky(true);
            //            Elainlista.Add(musti);
            //            Console.WriteLine("Koira");
            //        }
            //    }

            //    if (i % 3 == 2)
            //    {
            //        if (i % 4 == 3)
            //        {
            //            Hevonen polle = new Hevonen();
            //            polle.AsetaElaimenNimi("Polle");
            //            polle.AsetaElaimenIka(18);
            //            polle.AsetaOnLihanSyoja(false);
            //            polle.AsetaImetyskyky(true);
            //            Elainlista.Add(polle);
            //            Console.WriteLine("Hevonen");
            //        }

            //        else
            //        { 
            //            Papukaija kalle = new Papukaija();
            //            kalle.AsetaElaimenNimi("Kalle");
            //            kalle.AsetaElaimenIka(33);
            //            kalle.AsetaOnLihanSyoja(false);
            //            kalle.OnLentokyky(true);
            //            Elainlista.Add(kalle);
            //            Console.WriteLine("Papukaija");
            //        }
            //    }


            for (int i = 0; i <= elaintenmaara - 1; i++)
            {
                if (i% 4 == 3)
                {
                    Hevonen polle = new Hevonen();
                    polle.AsetaOnLihanSyoja(false);
                    polle.AsetaElaimenNimi("Polle");
                    polle.AsetaElaimenIka(randomi.Next(1,30));
                    polle.AsetaImetyskyky(true);
                    Elainlista.Add(polle);
                }

                else if (i % 3 == 0)
                {
                    Kissa misse = new Kissa();
                    misse.AsetaOnLihanSyoja(true);
                    misse.AsetaElaimenNimi("Misse");
                    misse.AsetaElaimenIka(randomi.Next(1, 20));
                    misse.AsetaImetyskyky(true);
                    Elainlista.Add(misse);
                }

                else if (i% 3 == 1)
                {
                    Koira musti = new Koira();
                    musti.AsetaOnLihanSyoja(true);
                    musti.AsetaElaimenNimi("Musti");
                    musti.AsetaElaimenIka(randomi.Next(1, 19));
                    musti.AsetaImetyskyky(true);
                    Elainlista.Add(musti);
                }

                else
                {
                    Papukaija kalle = new Papukaija();
                    kalle.AsetaOnLihanSyoja(false);
                    kalle.AsetaElaimenNimi("Kalle");
                    kalle.AsetaElaimenIka(randomi.Next(1, 99));
                    kalle.OnLentokyky(true);
                    Elainlista.Add(kalle);
                }
                //Asettaa listan viimeisen elementin ominaisuuden
                //Elainlista.Last().AsetaElaimenNimi("Yleinen nimi");
            }

            foreach (Elain elain in Elainlista)
            {
                string lihansyoja = "ei ole lihansyöjä";
                if (elain.PalautaOnLihanSyoja())
                {
                    lihansyoja = "on lihansyöjä";
                }
                Console.WriteLine(elain.PalautaElaimenNimi() + " on " + elain.GetType() + " ja on " + elain.PalautaElaimenIka() + " vuotias ja " + lihansyoja); ;
            }

            foreach (Nisakkaat nisakkaat in Elainlista.OfType<Nisakkaat>())
            {
                Console.WriteLine("Nisakas " + nisakkaat.PalautaElaimenNimi() + nisakkaat.PalautaImetysKyky());
            }

            foreach (Linnut lintu in Elainlista.OfType<Linnut>())
            {
                Console.WriteLine("Lintu " + lintu.PalautaElaimenNimi() + lintu.PalautaOnLentokyky());
            }

            //foreach (Elain elain in Elainlista.OfType<Elain>())
            //{
            //    Console.WriteLine(elain);
            //    Console.WriteLine("Ikä: " + elain.PalautaElaimenIka());
            //    Console.WriteLine("Onko lihansyöjä?: " + elain.PalautaOnLihanSyoja());
            //    Console.WriteLine("Nimi: " + elain.PalautaElaimenNimi());
            //    Console.WriteLine();
            //}

            //foreach (Kissa kissa in Elainlista.OfType<Kissa>())
            //{
            //    Console.WriteLine(kissa);
            //    Console.WriteLine("Ikä: " + kissa.PalautaElaimenIka());
            //    Console.WriteLine("Onko lihansyöjä?: " + kissa.PalautaOnLihanSyoja());
            //    Console.WriteLine("Nimi: " + kissa.PalautaElaimenNimi());
            //    Console.WriteLine(kissa.PalautaImetysKyky());
            //    Console.WriteLine();
            //}

            //foreach (Koira koira in Elainlista.OfType<Koira>())
            //{
            //    Console.WriteLine(koira);
            //    Console.WriteLine("Ikä: " + koira.PalautaElaimenIka());
            //    Console.WriteLine("Onko lihansyöjä?: " + koira.PalautaOnLihanSyoja());
            //    Console.WriteLine("Nimi: " + koira.PalautaElaimenNimi());
            //    Console.WriteLine(koira.PalautaImetysKyky());
            //    Console.WriteLine();
            //}

            //foreach (Papukaija papu in Elainlista.OfType<Papukaija>())
            //{
            //    Console.WriteLine(papu);
            //    Console.WriteLine("Ikä: " + papu.PalautaElaimenIka());
            //    Console.WriteLine("Onko lihansyöjä?: " + papu.PalautaOnLihanSyoja());
            //    Console.WriteLine("Nimi: " + papu.PalautaElaimenNimi());
            //    Console.WriteLine(papu.PalautaOnLentokyky());
            //    Console.WriteLine();
            //}

            //foreach (Hevonen heppa in Elainlista.OfType<Hevonen>())
            //{
            //    Console.WriteLine(heppa);
            //    Console.WriteLine("Ikä: " + heppa.PalautaElaimenIka());
            //    Console.WriteLine("Onko lihansyöjä?: " + heppa.PalautaOnLihanSyoja());
            //    Console.WriteLine("Nimi: " + heppa.PalautaElaimenNimi());
            //    Console.WriteLine(heppa.PalautaImetysKyky());
            //    Console.WriteLine();
            //}
        }
    }
}
