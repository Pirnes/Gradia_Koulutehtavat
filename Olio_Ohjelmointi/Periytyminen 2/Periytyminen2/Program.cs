using System;
using Elaimet;

namespace Periytyminen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa PyhaBirma = new Kissa();
            PyhaBirma.AsetaElaimenNimi("Misse");
            PyhaBirma.AsetaElaimenIka(13);
            PyhaBirma.AsetaOnLihanSyoja(true);
            PyhaBirma.PalautaElaimenNimi();
            PyhaBirma.PalautaElaimenIka();
            PyhaBirma.PalautaOnLihanSyoja();
            PyhaBirma.Kehraa();

            Koira Rottweiler = new Koira();
            Rottweiler.AsetaElaimenNimi("Karu");
            Rottweiler.AsetaElaimenIka(2);
            Rottweiler.AsetaOnLihanSyoja(true);
            Rottweiler.PalautaElaimenNimi();
            Rottweiler.PalautaElaimenIka();
            Rottweiler.PalautaOnLihanSyoja();
        }
    }
}
