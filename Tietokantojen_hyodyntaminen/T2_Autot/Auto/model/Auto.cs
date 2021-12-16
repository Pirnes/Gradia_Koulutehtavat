using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{

    public class Auto
    {
        int id;
        decimal hinta;
        DateTime rekisteri_paivamaara;
        decimal moottorin_tilavuus;
        int mittarilukema;
        int autonMerkkiID;
        int autonMalliID;
        int variID;
        int polttoaineID;

        public int Id { get => id; set => id = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime Rekisteri_paivamaara { get => rekisteri_paivamaara; set => rekisteri_paivamaara = value; }
        public decimal Moottorin_tilavuus { get => moottorin_tilavuus; set => moottorin_tilavuus = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        public int AutonMerkkiID { get => autonMerkkiID; set => autonMerkkiID = value; }
        public int AutonMalliID { get => autonMalliID; set => autonMalliID = value; }
        public int VariID { get => variID; set => variID = value; }
        public int PolttoaineID { get => polttoaineID; set => polttoaineID = value; }
    }
}
