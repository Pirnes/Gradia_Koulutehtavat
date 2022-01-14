using System;
using Elaimet;

namespace _01_kissa
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira UusiKoira = new Koira();
            UusiKoira.PalautaKoiranNimi();
            UusiKoira.AsetaKoiranNimi("Max");
            UusiKoira.PalautaKoiranNimi();
            UusiKoira.AsetaKoiranNimi("MuSTi");
            UusiKoira.PalautaKoiranNimi();
        }
    }
}
