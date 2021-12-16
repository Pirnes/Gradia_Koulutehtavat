
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;
        SqlCommand komento;

        public DatabaseHallinta()
        {
        }

        public bool connectDatabase()
        {
            yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbYhteys = new SqlConnection(yhteysTiedot);
            
            try
            { 
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;
        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            connectDatabase();

            List<AutonMerkki> autonMerkit = new List<AutonMerkki>();
            komento = new SqlCommand("SELECT * FROM AutonMerkki", dbYhteys);
            var reader = komento.ExecuteReader();
            while (reader.Read())
            {
                AutonMerkki autonMerkki = new AutonMerkki();
                autonMerkki.ID = reader.GetInt32(0);
                autonMerkki.Merkki = reader.GetString(1);
                autonMerkit.Add(autonMerkki);
            }
            disconnectDatabase();
            return autonMerkit;
        }

        public List<AutonMalli> getAutoModelsByMakerId(int AutonMerkkiID) 
        {
            List<AutonMalli> autonMallit = new List<AutonMalli>();
            //autonMallit.Add(autonMalli);
            List<AutonMalli> palaute = null;
            return palaute;
        }
    }
}
