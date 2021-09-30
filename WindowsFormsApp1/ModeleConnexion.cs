using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public class ModeleConnexion
    {
        private MySqlConnection myConnection;
        public bool ConnOpen = false;
        public bool chargement = false;
        
        private List<DataTable> dT = new List<DataTable>();
        
        
        public bool Connopen { get => ConnOpen; set => ConnOpen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public List<DataTable> DT { get => dT; set => dT = value; }
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
        
        public ModeleConnexion()
        {
            for (int i = 0; i < 10; i++)
            {
                dT.Add(new DataTable());
            }
        }


    
        public void seconnecter()
        {
            string myConnectionString = "Database=opticiencorrection;Data Source=localhost;User Id=root; Password=;SslMode = none;";
            myConnection = new MySqlConnection(myConnectionString);
            try 
            {
                myConnection.Open();
                ConnOpen = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnOpen = false;
            }
        }


        public void sedeconnecter()
        {
            if (!ConnOpen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                ConnOpen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            chargement = false;

            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Clear();
                DT.Load(reader);
                chargement = true;


            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        
    }
}