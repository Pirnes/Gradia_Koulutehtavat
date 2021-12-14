using System;

namespace _00_hevonen {
    public class KavioElain : Nisakas {

        public KavioElain() {
            paino=1;
            System.Console.WriteLine("Kavioelain konstruktori!");
        }

        public KavioElain(float paino) {
            this.paino=paino;
            System.Console.WriteLine("Kavioelain parametrillinen konstruktori!");
        }
        public float paino;

        public virtual void KukaOlen() {
            System.Console.WriteLine("Olen kavioelain!");
        }

        public override void MiltaNaytan() {
            System.Console.WriteLine("Minulla on kaviot!");
        }


    }

}