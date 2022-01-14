using System;
using System.Collections.Generic;
using System.Text;

namespace Elaimet
{
    public abstract class Nisakkaat : Elain
    {
        private bool imetyskyky;

        public bool Imetyskyky { get => imetyskyky; set => imetyskyky = value; }

        public void AsetaImetyskyky(bool KyllaImettaa)
        {
            imetyskyky = KyllaImettaa;
        }

        public bool PalautaImetysKyky()
        {
            Console.Write("Imetyskyky: ");
            return imetyskyky;
        }
    }
}
