using System;
using System.Collections.Generic;
using System.Text;

namespace Elaimet
{
    public abstract class Linnut : Elain
    {
        private bool lentokyky;

        public bool Lentokyky { get => lentokyky; set => lentokyky = value; }

        public void OnLentokyky(bool OsaaLentaa)
        {
            lentokyky = OsaaLentaa;
        }

        public bool PalautaOnLentokyky()
        {
            Console.Write("Lentokyky: ");
            return lentokyky;
        }
    }
}
