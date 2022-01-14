using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tuote
{
    class Tuote
    {
        //attributes
        private double hinta;
        private int lukumaara;
        private string nimi;

        //non parametric constructor
        public Tuote()
        {
        }

        //parametric constructor
        public Tuote(string nimiAlussa, double hintaAlussa, int lukumaaraAlussa)
        {
            nimi = nimiAlussa;
            hinta = hintaAlussa;
            lukumaara = lukumaaraAlussa;
        }

        //method prints values which is given in parametric contsructor
        public void tulostaTuote()
        {
            Console.WriteLine(nimi + ", " + "hinta " + hinta + ", " + lukumaara + " kpl");
        }
    }
}
