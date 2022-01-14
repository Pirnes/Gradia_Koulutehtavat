using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
			//Luo Pekan kortti.Kortin alkusaldo on 20 euroa
			//Luo Matin kortti. Kortin alkusaldo on 30 euroa
			//Pekka syö maukkaasti
			//Matti syö edullisesti
			//Korttien arvot tulostetaan(molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
			//Pekka lataa rahaa 20 euroa
			//Matti syö maukkaasti
			//Korttien arvot tulostetaan(molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
			//Pekka syö edullisesti
			//Pekka syö edullisesti
			//Matti lataa rahaa 50 euroa
			//Korttien arvot tulostetaan(molemmat omalle rivilleen, rivin alkuun kortin omistajan nimi)
			Maksukortti Pekka = new Maksukortti(20);
			Maksukortti Matti = new Maksukortti(30);
			Pekka.SyoMaukkaasti();
			Matti.SyoEdullisesti();
			Console.WriteLine("Pekka: " + Pekka);
			Console.WriteLine("Matti: " + Matti);
			Pekka.LataaRahaa(20);
			Matti.SyoMaukkaasti();
			Console.WriteLine("Pekka: " + Pekka);
			Console.WriteLine("Matti: " + Matti);
			Pekka.SyoEdullisesti();
			Pekka.SyoEdullisesti();
			Matti.LataaRahaa(50);
			Console.WriteLine("Pekka: " + Pekka);
			Console.WriteLine("Matti: " + Matti);
		}
	}
}
