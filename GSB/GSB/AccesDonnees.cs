using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GSB
{
    public class AccesDonnees
    {

        public MySqlConnection connectdb;


        public void connectionMysQl()
        {

            try
            {
                string cnnStr = @"server= localhost; user=root;database =gsb_frais;
        port=3306;password=root;";

                connectdb = new MySqlConnection(cnnStr);
                connectdb.Open();
                Console.WriteLine("Vous êtes connectées à la base de donné");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getInfosVisiteur(string login, string mdp)
        {
            connectionMysQl();
            string maRequete = @"SELECT visiteur.id AS id, visiteur.nom AS nom, visiteur.prenom AS prenom FROM visiteur  WHERE visiteur.login = @unLogin AND visiteur.mdp = @unMdp";
            MySqlCommand comm = new MySqlCommand(maRequete, connectdb);
            comm.Parameters.Add("@unLogin", login);
            var unReader = comm.ExecuteReader();
            while (unReader.Read()) {
                string id = unReader.GetString(0);
                string nom = unReader.GetString(1);
                string prenom = unReader.GetString(2);
                Console.WriteLine(id," ",nom," ", prenom);
            }
        }

        public void getEtatById(int id)
        {
            string maRequete = @"SELECT * FROM etat WHERE etat.id = @id";
            MySqlCommand comm = new MySqlCommand(maRequete, connectdb);
            comm.Parameters.Add("@id", (MySqlDbType) id);
            var unReader = comm.ExecuteScalar();
            Console.WriteLine(unReader);
            
        }
        //public void selectC()
        //{
        //    connectionMysQl();
        //    string maRequete = @"Select nom,prenom from comptable";
        //    MySqlCommand comm = new MySqlCommand(maRequete, connectdb);

        //    var unReader = comm.ExecuteReader();
        //    while (unReader.Read())
        //    {
        //        string nom = unReader.GetString(0);
        //        string prenom = unReader.GetString(1);
        //        Console.WriteLine("{0} {1}", nom, prenom);
        //    }
        //    Console.ReadLine();
        //    connectdb.Close();
        //}

        //public void selectV()
        //{
        //    connectionMysQl();
        //    string maRequete = @"Select nom,prenom from visiteur";
        //    MySqlCommand comm = new MySqlCommand(maRequete, connectdb);

        //    var unReader = comm.ExecuteReader();
        //    while (unReader.Read())
        //    {
        //        string nom = unReader.GetString(0);
        //        string prenom = unReader.GetString(1);
        //        Console.WriteLine("{0} {1}", nom, prenom);
        //    }
        //    Console.ReadLine();
        //    connectdb.Close();
        //}

        public void getTableauEtat()
        {
            connectionMysQl();
            string maRequete = @"SELECT * FROM etat WHERE id IN ('VA','MP','RB')";
            var SqlCom = new MySqlCommand(maRequete, connectdb);
            var unReader = SqlCom.ExecuteReader();
            while (unReader.Read())
            {
                string etat = unReader.GetString(0);
                Console.WriteLine(etat);
            }
            Console.ReadLine();
            connectdb.Close();
        }

    }


}
