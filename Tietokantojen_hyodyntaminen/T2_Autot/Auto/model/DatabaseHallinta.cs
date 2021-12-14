
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
           yhteysTiedot = "Leikkaa tähän oma connection string tietokannasta";
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;
            
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

        public List<> getAllAutoMakersFromDatabase()
        {
            List<> palaute=null;
            return palaute;

        }

        public List<> getAutoModelsByMakerId(int makerId) 
             
        {
            List<> palaute = null;
            return palaute;
        }

    }
}
