using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Velka
{
    class Velka
    {
        //attributes
        private double _saldo;
        private double _korkoProsentti;

        //parametric constructor
        public Velka(double saldoAlussa, double korkoProsentti)
        {
            _saldo = saldoAlussa;
            _korkoProsentti = korkoProsentti;
        }

        //method prints _saldo
        public void TulostaSaldo()
        {
            Console.WriteLine(_saldo);
        }

        //method increase _saldo with one year interest rate
        public void OdotaVuosi()
        {
            _saldo = _saldo * (1 + _korkoProsentti);
        }
    }
}
