using System;

namespace Arvonta
{
    class Program
    {
        static void Main(string[] args)
        {
            int lottery, i, guess,i2=19;
            Random hnumb = new Random();
            lottery = hnumb.Next(1,50);

            Console.WriteLine("arvaa luku väliltä 1-50 näppäilemällä se, sinulla on 20 yritystä");
            guess = int.Parse(Console.ReadLine());

            for (i=1; i<20; i++)

            {
                if (guess == lottery)
                {
                    Console.WriteLine("Onneksi olkoon, arvasit oikein!!");
                    i = 20;
                }
                else 
                {
                    Console.WriteLine("Ei osunut, yritä uudelleen, sinulla on " + i2 + " yritystä jäljellä");
                    guess = int.Parse(Console.ReadLine());
                    i2--;
                    if (i2<1)
                    {
                        Console.WriteLine("Yritykset loppuivat, kiitos mielenkiinnosta");
                    }
                }
                                
            }
                        
        }
    }
}
