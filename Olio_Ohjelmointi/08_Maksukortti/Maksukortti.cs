using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Maksukortti
{
    class Maksukortti
    {
        //attribute
        private double saldo;

        //parametric constructor
        public Maksukortti(double alkuSaldo)
        {
            saldo = alkuSaldo;
        }

        //method overrides ToString method
        public override string ToString()
        {
            //return $"Kortilla on rahaa {saldo:N2} euroa"; Sama kuin alla mutta siistimmin
            return "Kortilla on rahaa " + string.Format("{0:0.00}", saldo) + " euroa";
        }

        //method decrease saldo 2,6 euros
        public void SyoEdullisesti()
        {
            if ((saldo - 2.6) < 0)
            {
                return;
            }

            else
            {
                saldo -= 2.6;
            }
        }

        //method decrease saldo 4,6 euros
        public void SyoMaukkaasti()
        {
            if ((saldo - 4.6) < 0)
            {
                return;
            }

            else
            {
                saldo -= 4.6;
            }
        }

        public void LataaRahaa(int saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            else
            {
                this.saldo += saldo;
            }
        }
    }
}
