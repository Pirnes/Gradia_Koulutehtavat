using System;

namespace Arvosana
{
    class Program
    {
        static void ViikonPaiva()
        {
            bool kelvollinen = true;

            while (kelvollinen)
            {

                Console.WriteLine("Syota viikonpaivan numero 1 - 7:");
                string viikonpaiva = Console.ReadLine();

                switch (viikonpaiva)
                {
                    case "1":
                        Console.WriteLine("Päivä numero 1 on Maanantai.");
                        kelvollinen = false;
                        break;
                    case "2":
                        Console.WriteLine("Päivä numero 2 on tiistai.");
                        kelvollinen = false;
                        break;
                    case "3":
                        Console.WriteLine("Päivä numero 3 on keskiviikko.");
                        kelvollinen = false;
                        break;
                    case "4":
                        Console.WriteLine("Päivä numero 4 on torstai.");
                        kelvollinen = false;
                        break;
                    case "5":
                        Console.WriteLine("Päivä numero 5 on perjantai.");
                        kelvollinen = false;
                        break;
                    case "6":
                        Console.WriteLine("Päivä numero 6 on lauantai.");
                        kelvollinen = false;
                        break;
                    case "7":
                        Console.WriteLine("Päivä numero 7 on sunnuntai");
                        kelvollinen = false;
                        break;
                    default:
                        Console.WriteLine("Antamasi viikonpäivän numero ei ollut kelvollinen, yritä uudelleen");
                        kelvollinen = true;
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            ViikonPaiva();
        }
    }
}