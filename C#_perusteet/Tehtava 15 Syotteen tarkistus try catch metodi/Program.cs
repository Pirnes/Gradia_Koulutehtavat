using System;

namespace Tehtävä_15_syotteen_tarkistus_try_catch_metodi
{
    class Program
    {
        static void Main(string[] args)

        {

            int jakaja, jaettava;

            try
            {
                Console.WriteLine("Suoritetaan jakolasku:");
                Console.WriteLine("Anna jaettava luku:");
                jaettava = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna jakaja:");
                jakaja = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Jakolaskun tulos: " + jaettava / jakaja);
            }

            catch (FormatException)
            {
                Console.WriteLine("luku pitää antaa numeroina, näppäilysi sisälsi ehkä kirjaimia tai muita soveltumattomia merkkejä");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Yritit jakaa nollalla! Anna jakajaksi jokin muu, kuin nolla.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Et näppäillyt arvoa jaettavalle/jakajalle, muuttujaan pitää määritellä arvo!");
            }
            finally
            {
                Console.WriteLine("Kiitos ohjelman käytöstä!");
            }
        }
    }
}
