using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Mitta
{
    class Mittari
    {
        //attribute
        private int _mitta;

        //non parametric constructor
        public Mittari()
        {
        }

        //method increase _mitta's value
        public void Lisaa()
        {
            if (_mitta ==5)
            {
                return;
            }
            _mitta++;
        }

        //method decrease _mitta's value
        public void Vahenna()
        {
            if (_mitta ==0)
            {
                return;
            }
            _mitta--;
        }

        //method returns _mitta's value
        public int Mitta()
        {
            return _mitta;
        }

        //method tests is _mitta's value full
        public bool Taynna()
        {
            if (_mitta ==5)
            {
                return true;
            }
            return false;
        }
    }
}
