using System;
using Elaimet;

namespace Periytyminen3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kissa PyhaBirma = new Kissa();
            //PyhaBirma.AsetaElaimenNimi("Misse");
            //PyhaBirma.AsetaElaimenIka(13);
            //PyhaBirma.AsetaOnLihanSyoja(true);
            //PyhaBirma.PalautaElaimenNimi();
            //PyhaBirma.PalautaElaimenIka();
            //PyhaBirma.PalautaOnLihanSyoja();
            //PyhaBirma.Kehraa();

            //Koira Rottweiler = new Koira();
            //Rottweiler.AsetaElaimenNimi("Karu");
            //Rottweiler.AsetaElaimenIka(2);
            //Rottweiler.AsetaOnLihanSyoja(true);
            //Rottweiler.PalautaElaimenNimi();
            //Rottweiler.PalautaElaimenIka();
            //Rottweiler.PalautaOnLihanSyoja();
            //Rottweiler.Aantele();

            //Elain VilliElain = new Elain();
            //Nisakkaat SuperNisakas = new Nisakkaat();
            Kissa VilliKissa = new Kissa();
            Koira KulkuKoira = new Koira();
            //VilliElain.Aantele();
            //SuperNisakas.Aantele();
            VilliKissa.Aantele();
            KulkuKoira.Aantele();
        }
    }
}
