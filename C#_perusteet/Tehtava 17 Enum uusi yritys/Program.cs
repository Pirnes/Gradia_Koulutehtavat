using System;

namespace Tehtava_17_Enum_uusi_yritys
{
    class Program
    {
        enum Kysely { none = 0, lisaaNimi, lisaaSyntyma, naytaNimi, naytaIka, poistuOhj }

        static void Main(string[] args)
        {
            bool onnistui = false;
            string valinta;
            DateTime tamapvm = DateTime.Today;
            DateTime syntymapaiva = DateTime.Today;
            Kysely tulos = Kysely.none;
            bool epaonnistui = true;

            while (!onnistui)
            {
                int i = 0;
                foreach (string kyselykohde in Enum.GetNames(typeof(Kysely)))
                {
                    if (i > 0)
                    {
                        Console.WriteLine(i + ". " + kyselykohde);
                    }
                    i++;
                }

                valinta = Console.ReadLine();
                onnistui = Enum.TryParse(valinta, out tulos);
                onnistui = false;

                switch (tulos)
                {
                    case Kysely.lisaaNimi:
                        Console.WriteLine("Syötä nimesi");
                        string nimi = Console.ReadLine();
                        Console.WriteLine("Nimesi on Tallennettu");
                        onnistui = false;
                        break;
                    case Kysely.lisaaSyntyma:
                        while (epaonnistui)
                        {
                            Console.WriteLine("Syötä syntymäpäiväsi muodossa YYYY/MM/DD, esimerkki 2000/12/12");
                            string syote = Console.ReadLine();
                            epaonnistui = !DateTime.TryParse(syote, out syntymapaiva);
                        }
                        int ika = tamapvm.Year - syntymapaiva.Year;
                        Console.WriteLine("Ikäasi on " + (ika -1) + " vuotta! Gongrats!!");
                        break;
                    case Kysely.naytaNimi:
                        Console.WriteLine("Nimeäsi ei voi nyt valitettavasti näyttää");
                        break;
                    case Kysely.naytaIka:
                        Console.WriteLine("Ikääsi ei voi nyt valitettavasti näyttää");
                        break;
                    case Kysely.poistuOhj:
                        onnistui = true;
                        break;
                    default:
                        Console.WriteLine("Ei onnistunut, yritä uudelleen!");
                        break;
                }
            }
        }
    }
}
