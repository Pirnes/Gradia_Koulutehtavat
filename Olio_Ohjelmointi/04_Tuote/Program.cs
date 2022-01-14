using System;

namespace _04_Tuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote ekatuote = new Tuote("banaani", 1.1, 13);
            ekatuote.tulostaTuote();
        }
    }
}
