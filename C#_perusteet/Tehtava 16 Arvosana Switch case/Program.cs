using System;

namespace Arvosana
{
    class Program
    {
        static void ArvoSanat() 
        {
            bool kelvollinen = true;

            while (kelvollinen)
            {

                Console.WriteLine("Syötä saamasi arvosana:");
                string arvosana = Console.ReadLine();

                switch (arvosana)
                {
                    case "4":
                        Console.WriteLine("4 on hylätty arvosana");
                        kelvollinen = false;
                        break;
                    case "5":
                        Console.WriteLine("5 on huono arvosana");
                        kelvollinen = false;

                        break;
                    case "6":
                        Console.WriteLine("6 on välttävä arvosana");
                        kelvollinen = false;

                        break;
                    case "7":
                        Console.WriteLine("7 on tyydyttävä arvosana");
                        kelvollinen = false;

                        break;
                    case "8":
                        Console.WriteLine("8 on hyvä arvosana");
                        kelvollinen = false;

                        break;
                    case "9":
                        Console.WriteLine("9 on kiitettävä arvosana");
                        kelvollinen = false;

                        break;
                    case "10":
                        Console.WriteLine("10 on paras mahdollinen arvosana");
                        kelvollinen = false;

                        break;
                    default:
                        Console.WriteLine("Antamasi arvosana ei ollut kelvollinen, yritä uudelleen");
                        kelvollinen = true;
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            ArvoSanat();
        }
    }
}
