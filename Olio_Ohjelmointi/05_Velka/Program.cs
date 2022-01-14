using System;

namespace _05_Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka autolaina = new Velka(1500, 0.1);
            autolaina.TulostaSaldo();
            autolaina.OdotaVuosi();
            autolaina.TulostaSaldo();
        }
    }
}
