using System;

namespace _00_hevonen {
    class Hevonen : KavioElain {
        public string nimi;

        public override void KukaOlen() {
            System.Console.WriteLine("Olen hevonen!");
        }

        public void KukaOlenYliluokanMielesta() {
            base.KukaOlen();
        }
    }
}