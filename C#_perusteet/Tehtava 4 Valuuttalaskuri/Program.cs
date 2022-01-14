using System;

namespace Valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {

            Decimal  dollar=1.19m, pound=0.8623m;
            Decimal  euro;
            int choise;

            Console.WriteLine("        VALUUTTAMUUNNIN");
            Console.WriteLine();
            Console.WriteLine("Euro -> Dollari     Euro -> Punta");
            Console.WriteLine();
            Console.WriteLine("Syötä muunnettava euromäärä: ");
            Console.WriteLine();
            euro = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Jos haluat muunnoksen dollareina, valitse 1, tai jos haluat muunnoksen puntina valitse 2");
            Console.WriteLine();
            choise=int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choise == 1)

            {
                
                Console.Write(+euro + " euroa on dollareina: " + "{0:0.00}", euro * dollar);
                Console.WriteLine(" $");
                Console.ReadKey();

            }
            
            else if (choise ==2)
                            
            {
                
                Console.Write(+euro + " euroa on puntina   : " + "{0:0.00}", euro * pound);
                Console.WriteLine(" £");
                Console.WriteLine();
                Console.ReadKey();
                
            }

            else

            {

                Console.WriteLine("Virheellinen valinta");
                Console.ReadKey();

            }

        }
    }
}
