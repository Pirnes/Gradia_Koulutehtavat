using System;

namespace Matikkapeli
{
    class Program
    {
        enum VaihtoEhdot { none = 0, yhteenlaskut, vahennyslaskut, kertolaskut, jakolaskut, taitotasosi, lopetus }

        static int Valikko(int valinta)
        {
            bool onnistui = false;
            
            Console.WriteLine("Valitse allaolevasta valikosta mitä haluat tehdä:");
            Console.WriteLine();

            while (!onnistui)
            {
                int i = 0;
                foreach (string val in Enum.GetNames(typeof(VaihtoEhdot)))
                {
                    if (i > 0)
                    {
                        Console.WriteLine(i + ". " + val);
                    }
                    i++;
                }
                
                Console.WriteLine();
                string syote = Console.ReadLine();

                if (int.TryParse(syote, out valinta))
                {
                    onnistui = true;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Näppäile valinta numeronäppäimillä 1 - 6.");
                    Console.WriteLine();
                }
            }
            Console.Clear();
            return valinta;
        }

        static int YhteenLaskut(int yhteenlaskutaso)
        {
            Random laskettava1 = new Random();
            Random laskettava2 = new Random();
            bool onnistui = false;
            int taso = 0;

            Console.WriteLine("Harjoitellaan siis yhteenlaskuja. Laskuja on 20 kpl ja vastaamalla oikein vähintään puolet, saat palkinnon ja tasosi nousee!");
            Console.WriteLine("Vaikeammat tasot kerryttävät pisteitä ja palkintoja enemmän.");
            Console.WriteLine();
            Console.WriteLine("1. Helpot");
            Console.WriteLine("2. Keskivaikeat          Laskuissa mukana myös negatiivisia lukuja (esim. 2 + -5)");
            Console.WriteLine("3. Vaikeat               Lasketaan isommilla luvuilla, mukana myös negatiivisia lukuja");
            Console.WriteLine();
            Console.WriteLine("Takaisin päävalikkoon pääset painamalla Enter.");
            string syote = Console.ReadLine();
            Console.Clear();

            if (syote.Contains("1"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <=19 ; i++)
                    {
                        int luku1 = laskettava1.Next(0, 11);
                        int luku2 = laskettava2.Next(0, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " + " + luku2);
                        int vastaus = luku1 + luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            yhteenlaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("2"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19 ; i++)
                    {
                        int luku1 = laskettava1.Next(-10, 11);
                        int luku2 = laskettava2.Next(-10, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " + " + luku2);
                        int vastaus = luku1 + luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            yhteenlaskutaso++;
                            yhteenlaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("3"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(-50, 50);
                        int luku2 = laskettava2.Next(-50, 50);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " + " + luku2);
                        int vastaus = luku1 + luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            yhteenlaskutaso++;
                            yhteenlaskutaso++;
                            yhteenlaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }
            return yhteenlaskutaso;
        }

        static int VahennysLaskut(int vahennyslaskutaso)
        {
            Random laskettava1 = new Random();
            Random laskettava2 = new Random();
            bool onnistui = false;
            int taso = 0;

            Console.WriteLine("Harjoitellaan siis vähennyslaskuja. Laskuja on 20 kpl ja vastaamalla oikein vähintään puolet, saat palkinnon ja tasosi nousee!");
            Console.WriteLine("Vaikeammat tasot kerryttävät pisteitä ja palkintoja enemmän.");
            Console.WriteLine();
            Console.WriteLine("1. Helpot");
            Console.WriteLine("2. Keskivaikeat      Vastaus voi olla myös negatiivinen.   (esim. 2 - 6 = -4).");
            Console.WriteLine("3. Vaikeat           Laskuissa mukana negatiivisia lukuja. (esim. -4 + 6 = 2).");
            Console.WriteLine();
            Console.WriteLine("Takaisin päävalikkoon pääset painamalla Enter.");
            string syote = Console.ReadLine();
            Console.Clear();

            if (syote.Contains("1"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19 ; i++)
                    {
                        int luku1 = laskettava1.Next(0, 11);
                        int luku2 = laskettava2.Next(0, 11);
                        int vastaus = 0;

                        if (luku1 < luku2)
                        {
                            Console.WriteLine(i + 1 + ". lasku: " + luku2 + " - " + luku1);
                            vastaus = luku2 - luku1;
                        }

                        if (luku1 >= luku2)
                        {
                            Console.WriteLine(i + 1 + ". lasku: " + luku1 + " - " + luku2);
                            vastaus = luku1 - luku2;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            vahennyslaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("2"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(1, 11);
                        int luku2 = laskettava2.Next(1, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " - " + luku2);
                        int vastaus = luku1 - luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }
                        
                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            vahennyslaskutaso++;
                            vahennyslaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("3"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <=19; i++)
                    {
                        int luku1 = laskettava1.Next(-10, 11);
                        int luku2 = laskettava2.Next(-10, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " - " + luku2);
                        int vastaus = luku1 - luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            i = 20;
                            onnistui = true;
                            vahennyslaskutaso++;
                            vahennyslaskutaso++;
                            vahennyslaskutaso++;
                        }
                    }
                }
            }
            return vahennyslaskutaso;
        }

        static int KertoLaskut(int kertolaskutaso)
        {
            Random laskettava1 = new Random();
            Random laskettava2 = new Random();
            int taso = 0;
            bool onnistui = false;

            Console.WriteLine("Harjoitellaan siis kertolaskuja. Laskuja on 20 kpl ja vastaamalla oikein vähintään puolet, saat palkinnon ja tasosi nousee!");
            Console.WriteLine("Vaikeammat tasot kerryttävät pisteitä ja palkintoja enemmän.");
            Console.WriteLine();
            Console.WriteLine("1. Helpot        Lasketaan positiivisilla kokonaisluvuilla");
            Console.WriteLine("2. Keskivaikeat  Mukana on myös negatiivisia lukuja");
            Console.WriteLine("3. Vaikeat       Lasketaan isommilla luvuilla myös"); 
            Console.WriteLine();
            Console.WriteLine("Takaisin päävalikkoon pääset painamalla Enter.");
            string syote = Console.ReadLine();
            Console.Clear();

            if (syote.Contains("1"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(0, 11);
                        int luku2 = laskettava2.Next(0, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " * " + luku2);
                        int vastaus = luku1 * luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            kertolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("2"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(-10, 11);
                        int luku2 = laskettava2.Next(-10, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " * " + luku2);
                        int vastaus = luku1 * luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            kertolaskutaso++;
                            kertolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("3"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(-20, 20);
                        int luku2 = laskettava2.Next(-20, 20);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " * " + luku2);
                        int vastaus = luku1 * luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            kertolaskutaso++;
                            kertolaskutaso++;
                            kertolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }
            return kertolaskutaso;
        }

        static int JakoLaskut(int jakolaskutaso)
        {
            Random laskettava1 = new Random();
            Random laskettava2 = new Random();
            int taso = 0;
            bool onnistui = false;

            Console.WriteLine("Harjoitellaan jakolaskuja. Laskuja on 20 kpl ja vastaamalla oikein vähintään puolet, saat palkinnon ja tasosi nousee!");
            Console.WriteLine("Vaikeammat tasot kerryttävät pisteitä ja palkintoja enemmän.");
            Console.WriteLine();
            Console.WriteLine("1. Helpot.       Ei desimaaleja.");
            Console.WriteLine("2. Keskivaikeat. Mukana desimaalit yhden tarkkuudella.  (Esim. 1,5)");
            Console.WriteLine("3. Vaikeat.      Mukana desimaalit kahden tarkkuudella. (esim. 1,25)");
            Console.WriteLine();
            Console.WriteLine("Takaisin päävalikkoon pääset painamalla Enter.");
            string syote = Console.ReadLine();
            Console.Clear();

            if (syote.Contains("1"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        int luku1 = laskettava1.Next(0, 11);
                        int luku2 = laskettava2.Next(1, 11);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " / " + luku2);
                        int vastaus = luku1 / luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        int.TryParse(syote1, out int tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Vastaus oli siis: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus olisi ollut: " + vastaus + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            jakolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("2"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        decimal luku1 = laskettava1.Next(0, 10);
                        decimal luku2 = laskettava2.Next(1, 10);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " / " + luku2);
                        decimal vastaus = luku1 / luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        decimal.TryParse(syote1, out decimal tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Vastaus oli siis: " + string.Format("{0:0.0}",vastaus) + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus olisi ollut: " + string.Format("{0:0.0}",vastaus) + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            jakolaskutaso++;
                            jakolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }

            if (syote.Contains("3"))
            {
                while (!onnistui)
                {
                    for (int i = 0; i <= 19; i++)
                    {
                        decimal luku1 = laskettava1.Next(0, 20);
                        decimal luku2 = laskettava2.Next(1, 20);

                        Console.WriteLine(i + 1 + ". lasku: " + luku1 + " / " + luku2);
                        decimal vastaus = luku1 / luku2;
                        Console.WriteLine();
                        Console.WriteLine("Näppäile vastauksesi ja sitten Enter:");
                        Console.WriteLine();
                        string syote1 = Console.ReadLine();
                        decimal.TryParse(syote1, out decimal tulos);

                        if (i > 18)
                        {
                            Console.Clear();
                            Console.WriteLine("Yritykset loppuivat, jatka painamalla jotain näppäintä!");
                            Console.ReadKey();
                            onnistui = true;
                        }

                        if (tulos == vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Oikea vastaus. Vastaus oli siis: " + string.Format("{0:0.00}", vastaus) + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                            taso++;
                        }

                        if (tulos != vastaus)
                        {
                            Console.Clear();
                            Console.WriteLine("Väärä vastaus. Oikea vastaus olisi ollut: " + string.Format("{0:0.00}", vastaus) + ". jatketaan seuraavaan laskuun...");
                            Console.WriteLine();
                        }

                        if (taso >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("Sait 10 kpl laskuja oikein, Hienoa!!");
                            jakolaskutaso++;
                            jakolaskutaso++;
                            jakolaskutaso++;
                            i = 20;
                            onnistui = true;
                        }
                    }
                }
            }
            return jakolaskutaso;
        }

        static int JaloKivet(int jalokivet)
        {
            if (jalokivet < 5)
            {
                Console.WriteLine("Olet tasoltasi vielä aloittelija, mutta harjoitus tekee mestarin");
                Console.WriteLine("Sinulla on tällä hetkellä " + jalokivet + " kappaletta jalokiviä.");
            }

            else if (jalokivet < 10)
            {
                Console.WriteLine("Olet tasoltasi jo oppilas!! Jatka samaa rataa!!");
                Console.WriteLine("Sinulla on tällä hetkellä " + jalokivet + " kappaletta jalokiviä.");
            }

            else if (jalokivet < 20)
            {
                Console.WriteLine("Olet tasoltasi edistyksellinen!! Hienosti sujuu!!");
                Console.WriteLine("Sinulla on tällä hetkellä " + jalokivet + " kappaletta jalokiviä.");
            }

            else if (jalokivet < 30)
            {
                Console.WriteLine("Olet tasoltasi taitava!! Mahtavaa!!");
                Console.WriteLine("Sinulla on tällä hetkellä " + jalokivet + " kappaletta jalokiviä.");
            }

            else if (jalokivet < 50)
            {
                Console.WriteLine("Olet tasoltasi Mestari!! Tuskin enää tarvitset harjoitusta!!");
                Console.WriteLine("Sinulla on tällä hetkellä " + jalokivet + " kappaletta jalokiviä.");
            }
            return jalokivet;
        }


        static void Main(string[] args)
        {
            int yhteenlaskutaso = 0, vahennyslaskutaso = 0, kertolaskutaso = 0, jakolaskutaso = 0;
            int aloitusvalinta, valinta =0, jalokivet = 0;
            bool lopetapeli = false;

            Console.WriteLine("Tämä on matikkapeli, jossa harjoitellaan laskutoimituksia.");
            Console.WriteLine();

            while (!lopetapeli)
            {
                int tulos;
                JaloKivet(jalokivet);
                Console.WriteLine();
                aloitusvalinta = Valikko(valinta);
                Console.WriteLine();
                Console.Clear();

                if (aloitusvalinta == 1)
                {
                    tulos = YhteenLaskut(yhteenlaskutaso);

                    if (tulos == 1)
                    {
                        jalokivet++;
                        Console.WriteLine("Sait palkinnoksi Jalokiven!!");
                        Console.WriteLine();
                    }

                    if (tulos == 2)
                    {
                        jalokivet += 2;
                        Console.WriteLine("Sait palkinnoksi 2 jalokiveä!!");
                        Console.WriteLine();
                    }

                    if (tulos == 3)
                    {
                        jalokivet += 3;
                        Console.WriteLine("Sait palkinnoksi 3 jalokiveä!!");
                        Console.WriteLine();
                    }
                }

                if (aloitusvalinta == 2)
                {
                    tulos = VahennysLaskut(vahennyslaskutaso);

                    if (tulos == 1)
                    {
                        jalokivet++;
                        Console.WriteLine("Sait palkinnoksi jalokiven!!");
                        Console.WriteLine();
                    }

                    if (tulos == 2)
                    {
                        jalokivet += 3;
                        Console.WriteLine("Sait palkinnoksi 3 jalokiveä!!");
                        Console.WriteLine();
                    }

                    if (tulos == 3)
                    {
                        jalokivet += 6;
                        Console.WriteLine("Sait palkinnoksi 6 jalokiveä!!");
                        Console.WriteLine();
                    }
                }

                if (aloitusvalinta == 3)
                {
                    tulos = KertoLaskut(kertolaskutaso);

                    if (tulos == 1)
                    {
                        jalokivet++;
                        Console.WriteLine("Sait palkinnoksi jalokiven!!");
                        Console.WriteLine();
                    }

                    if (tulos == 2)
                    {
                        jalokivet += 3;
                        Console.WriteLine("Sait palkinnoksi 3 jalokiveä!!");
                        Console.WriteLine();
                    }

                    if (tulos == 3)
                    {
                        jalokivet += 6;
                        Console.WriteLine("Sait palkinnoksi 6 jalokiveä!!");
                        Console.WriteLine();
                    }
                }

                if (aloitusvalinta == 4)
                {
                    tulos = JakoLaskut(jakolaskutaso);

                    if (tulos == 1)
                    {
                        jalokivet += 2;
                        Console.WriteLine("Sait palkinnoksi 2 jalokiveä!!");
                        Console.WriteLine();
                    }

                    if (tulos == 2)
                    {
                        jalokivet += 5;
                        Console.WriteLine("Sait palkinnoksi 5 jalokiveä!!");
                        Console.WriteLine();
                    }

                    if (tulos == 3)
                    {
                        jalokivet += 10;
                        Console.WriteLine("Sait palkinnoksi 10 jalokiveä!!");
                        Console.WriteLine();
                    }
                }

                if (aloitusvalinta == 5)
                {
                    Console.Clear();
                    JaloKivet(jalokivet);
                    Console.WriteLine();
                    Console.WriteLine("Pääset takaisin päävalikkoon painamalla jotain näppäintä.");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (aloitusvalinta == 6)
                {
                    lopetapeli = true;
                }
            }
        }
    }
}
