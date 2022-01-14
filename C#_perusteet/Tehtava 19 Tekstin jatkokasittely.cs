using System;
using System.IO;

namespace esim
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti = File.ReadAllText(@"D:\gradia\harjoitustehtävät\tiedot.txt");
            string opettajat = teksti.Replace("opettajat", "OPETTAJAT");
            string oppilaat = opettajat.Replace("oppilaat", "OPPILAAT");

            for (int i = 0; i < teksti.Length; i++)
            {
                string kirjain = oppilaat[i].ToString();

                switch (kirjain)
                {
                    case " ":
                        break;
                    case "{":
                        Console.WriteLine();
                        break;
                    case "}":
                        break;
                    case "[":
                        break;
                    case "]":
                        Console.WriteLine();
                        break;
                    default:
                        Console.Write(kirjain);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}