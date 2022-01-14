using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Musiikkikappale
{
    class Musiikkikappale
    {
        //attributes
        private string nimi;
        private int pituus_sekunteina;

        //parametric constructor
        public Musiikkikappale(string kappaleenNimi, int kappaleenPituus)
        {
            nimi = kappaleenNimi;
            pituus_sekunteina = kappaleenPituus;
        }

        //method returns object's name
        public string palautaNimi()
        {
            return nimi;
        }

        //method returns object's length
        public int palautaPituus()
        {
            return pituus_sekunteina;
        }
    }
}
