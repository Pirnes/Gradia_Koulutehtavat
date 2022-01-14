using System;
using System.Collections.Generic;
using System.Text;

namespace Elaimet
{
    public abstract class Elain
    {
        private int ika;
        private bool OnLihanSyoja;
        public string nimi;

        public void AsetaElaimenIka(int ika)
        {
            if (ika >= 0)
                this.ika = ika;
        }

        public void AsetaElaimenNimi(string nimi)
        {
            this.nimi = nimi;
        }

        public int PalautaElaimenIka()
        {
            return ika;
        }

        public string PalautaElaimenNimi()
        {
            return nimi;
        }

        public void AsetaOnLihanSyoja(bool LihaMaistuu)
        {
            OnLihanSyoja = LihaMaistuu; 
        }

        public bool PalautaOnLihanSyoja()
        {
            return OnLihanSyoja;
        }

        public virtual void Aantele()
        {
            Console.Write("Umph!");
        }
    }
}
