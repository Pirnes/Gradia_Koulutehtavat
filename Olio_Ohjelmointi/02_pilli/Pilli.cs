using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_pilli
{
    class Pilli
    {
        //attribute
        private string aani;

        //constructor
        public Pilli(string pillinAani)
        {
            aani = pillinAani;
        }

        //method
        public void Soi()
        {
            Console.WriteLine(aani);
        }
    }
}
