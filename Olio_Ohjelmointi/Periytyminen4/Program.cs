using System;
using Elaimet;

namespace Periytyminen4
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira wuffe = new Koira();
            wuffe.Imetyskyky = true;
            Papukaija Harmaapapukaija = new Papukaija();
            Harmaapapukaija.Lentokyky = true;
            Harmaapapukaija.AsetaElaimenNimi("Turo");
            Harmaapapukaija.AsetaElaimenIka(25);
            wuffe.PalautaElaimenNimi();
            wuffe.PalautaElaimenIka();
            wuffe.PalautaImetysKyky();
            Harmaapapukaija.PalautaElaimenNimi();
            Harmaapapukaija.PalautaElaimenIka();
            Harmaapapukaija.PalautaOnLentokyky();
        }
    }
}
