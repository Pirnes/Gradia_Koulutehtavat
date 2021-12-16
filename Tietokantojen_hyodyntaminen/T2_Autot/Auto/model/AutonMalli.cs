using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutonMalli
    {
        private int iD;
        private string auton_mallin_nimi;
        private int autonMerkkiID;

        public int ID { get => iD; set => iD = value; }
        public string Auton_mallin_nimi { get => auton_mallin_nimi; set => auton_mallin_nimi = value; }
        public int AutonMerkkiID { get => autonMerkkiID; set => autonMerkkiID = value; }
    }
}
