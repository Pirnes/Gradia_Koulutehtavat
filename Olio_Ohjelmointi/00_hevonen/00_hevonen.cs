using System;

namespace _00_hevonen {

    class Program {
    
        // Main Method
        static public void Main(String[] args)
        {
            Hevonen polle=new Hevonen();
            Console.WriteLine(polle.nimi+" "+polle.paino);
            polle.nimi="Histamiini";
            //polle.paino=89;
            Console.WriteLine(polle.nimi+" "+polle.paino);
            polle.KukaOlen();
            polle.KukaOlenYliluokanMielesta();
            polle.MiltaNaytan();

            Seepra seppo=new Seepra();
            //seppo.paino=250;
            Console.WriteLine("Seepra "+seppo.paino);
            seppo.KukaOlen();
            seppo.MiltaNaytan();
            seppo.Mieliruokani();

            KavioElain elain=new KavioElain();
            
            // Mahdotonta koska Nisakas on abstrakti eli epataydellinen luokka
            //Nisakas nisakas=new Nisakas();
        }
    }
}