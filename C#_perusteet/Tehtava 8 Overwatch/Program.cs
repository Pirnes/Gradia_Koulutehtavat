using System;

namespace Owerwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string[,] heros = new string[4, 6];
            heros[0, 0] = "ANA  "; heros[0, 1] = "BASTION  "; heros[0, 2] = "BRIGITTE  "; heros[0, 3] = "D.Va(mech)  ";
            heros[1, 0] = "Role:"; heros[1, 1] = "Support  "; heros[1, 2] = "Defence  "; heros[1, 3] = "Tank  ";
            heros[2, 0] = "Armor:"; heros[2, 1] = "0  "; heros[2, 2] = "50  "; heros[2, 3] = "100  "; heros[2, 4] = "200  ";
            heros[3, 0] = "Health:"; heros[3, 1] = "200  "; heros[3, 2] = "400  ";

            Console.WriteLine("Ohjelma esittelee sinulle OverWatch- pelin 4 eri Hero- tyyppiä. Kun olet valmis paina jotain näppäintä: ");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine(heros[0, 0] + " (1)");
            Console.WriteLine(heros[0, 1] + " (2)");
            Console.WriteLine(heros[0, 2] + " (3)");
            Console.WriteLine(heros[0, 3] + " (4)");
            Console.WriteLine();
            Console.WriteLine("Valitse minkä Heron specsit haluat nähdä (1-4)");
            input = int.Parse(Console.ReadLine());


            if (input == 1)
            {
                Console.WriteLine(heros[0, 0] + heros[1, 0] + heros[1, 1] + heros[3, 0] + heros[3, 1] + heros [2,0] + heros[2,1]);
            }
            else if (input == 2)
            {
                Console.WriteLine(heros[0, 1] + heros[1, 0] + heros[1, 2] + heros[3, 0] + heros[3, 1] + heros[2, 0] + heros[2, 3]);
            }
            else if (input == 3)
            {
                Console.WriteLine(heros[0, 2] + heros[1, 0] + heros[1, 1] + heros[3, 0] + heros[3, 1] + heros[2, 0] + heros[2, 2]);
            }
            else
            {
                Console.WriteLine(heros[0, 3] + heros[1, 0] + heros[1, 3] + heros[3, 0] + heros[3, 2] + heros[2, 0] + heros[2, 4]);
            }
        }  
    }
}
