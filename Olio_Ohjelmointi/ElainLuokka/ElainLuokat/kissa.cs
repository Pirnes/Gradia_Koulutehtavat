using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    // class
    public class Kissa : Nisakkaat
    {
        private List<Kissa> pennut = new List<Kissa>();

        public List<Kissa> Pennut { get => pennut; set => pennut = value; }
        public Kissa Emo { get => emo; set => emo = value; }
        private Kissa emo;

        public Kissa(string nimi, int ika =0)
        {
            this.AsetaElaimenNimi(nimi);
            this.AsetaElaimenIka(ika);
        }

        public Kissa(string nimi, Kissa emo, int ika = 0)
        {
            this.AsetaElaimenNimi(nimi);
            this.AsetaElaimenIka(ika);
            this.emo = emo;
        }

        public int LisaaPentu(string nimi, int ika=0)
        {
            Kissa pentu = new Kissa(nimi, this, ika);
            Pennut.Add(pentu);
            return Pennut.Count;
        }
        public void Kehraa()
        {
            Console.WriteLine("Hrrrr...");
        }

        public override void Aantele()
        {
            Console.WriteLine("MeooWW!!");
        }

    }
}
