using System;

namespace Tehtava_20_Merkin_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onnistui = false;

            while (!onnistui)
            {
                Console.WriteLine("Näppäile joku merkki, kun haluat lopettaa, näppäile (quit).");
                string syote = Console.ReadLine();

                if (char.TryParse(syote, out char merkki))
                {
                    if (char.IsDigit(merkki))
                    {
                        Console.WriteLine("Antamasi merkki on numero " + merkki);
                    }
                    else if (char.IsWhiteSpace(merkki))
                    {
                        Console.WriteLine("Näppäilit näköjään välilyönnin");
                    }
                    else if (char.IsUpper(merkki))
                    {
                        Console.WriteLine("Syöttämäsi merkki oli näppäilty shift- tai Caps Lock- pohjassa!");
                    }
                    else if (char.IsLower(merkki))
                    {
                        Console.WriteLine("Syöttämäsi merkki oli pienellä!");
                    }
                    else if (char.IsSymbol(merkki))
                    {
                        Console.WriteLine("Näppäilit erikoismerkin tai symbolin");
                    }
                }
                else if (syote.Contains("quit"))
                    onnistui = true;
                else
                    Console.WriteLine("Et näppäillyt mitään merkkiä tai näppäilit useamman kuin yksi merkkiä, yritä uudelleen!");
            }
        }
    }
}
