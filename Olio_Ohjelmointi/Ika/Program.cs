using System;
using Elaimet;

namespace Ika
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random koiranika = new Random();
            Random kissanika = new Random();
            int i =0;
            bool onnistui = false;

            while (!onnistui)
            {

                Koira PystyKorva = new Koira();
                Kissa PyhaBirma = new Kissa();
                PystyKorva.AsetaKoiranIka(koiranika.Next(1, 15));
                PyhaBirma.AsetaKissanIka(kissanika.Next(1, 10));
                if (PystyKorva.PalautaKoiranIka() > PyhaBirma.PalautaKissanIka())
                {
                    Console.WriteLine("Koira on vanhempi");
                }

                else
                    Console.WriteLine("Kissa on vanhempi");
                i++;
                if (i >=10)
                {
                    onnistui = true;
                }
            }
        }
    }
}
