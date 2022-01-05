using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Models;

namespace DataLayer
{
    public class TransferRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Transfer> VratiTransfere()
        {
            List<Transfer> listaTransfera = new List<Transfer>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Transfer";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Transfer t = new Transfer();
                    t.Sifra = reader.GetInt32(0);
                    t.Datum_transfera = reader.GetDateTime(1);
                    t.Ime_pacijenta = reader.GetString(2);
                    t.Krvna_grupa = reader.GetString(3);
                    listaTransfera.Add(t);
                }

            }
            return listaTransfera;
        }

        public int UnesNovogTransfera(Transfer t)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Transfer VALUES('{0}','{1}','{2}','{3}')", t.Sifra, t.Datum_transfera, t.Ime_pacijenta, t.Krvna_grupa);

                return command.ExecuteNonQuery();

            }



        }
    }
}
