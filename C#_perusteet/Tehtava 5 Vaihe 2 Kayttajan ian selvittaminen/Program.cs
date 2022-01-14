using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttäjän_iän_selvittäminen
{
    class Program
    {
        private static void AgeCheck(ref string choise, ref int age)
        {
            Console.WriteLine("Kerro ikäsi:");
            age = int.Parse(Console.ReadLine());

            if (choise == "n" && age < 13)
            {
                Console.WriteLine("Hei, tytsy");
            }

            else if (choise == "n" && age < 26)
            {
                Console.WriteLine("Mitä neitokainen?");
            }

            else if (choise == "n" && age < 57)
            {
                Console.WriteLine("Nainen parhaassa iässä!");
            }

            else if (choise == "n" && age > 56)
            {
                Console.WriteLine("Hakuna Matata lady, koska eläkepäivät lähestyy!!");
            }

            if (choise == "m" && age < 13)
            {
                Console.WriteLine("Hei, poitsu");
            }

            else if (choise == "m" && age < 26)
            {
                Console.WriteLine("Mitä nuorimies?");
            }


            else if (choise == "m" && age < 57)
            {
                Console.WriteLine("Mies parhaassa iässä!");
            }

            else if (choise == "m" && age > 56)
            {
                Console.WriteLine("Hakuna Matata gentleman, koska eläkepäivät lähestyy!!");
            }

        }


        static void Main(string[] args)
        {

            int age = 1;
                        
            Console.WriteLine("Hei, jos olet nainen valitse (n), jos olet mies valitse (m)");
            string choise = Console.ReadLine();

            AgeCheck(ref choise,ref age);

        }
    }
}
