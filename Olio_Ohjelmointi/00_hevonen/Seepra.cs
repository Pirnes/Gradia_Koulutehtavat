using System;

namespace _00_hevonen {
    class Seepra : KavioElain {
        public Seepra() : base(100) {
            System.Console.WriteLine("Seepran konstruktori!");
        }

        public override void MiltaNaytan() {
            System.Console.WriteLine("Naytan raidalliselta!");
        }

    }
}