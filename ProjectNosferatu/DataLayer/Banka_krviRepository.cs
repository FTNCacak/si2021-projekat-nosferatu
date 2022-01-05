using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Models;

namespace DataLayer
{
    public class Banka_krviRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Banka_krvi> VratiZaliheKrvi()
        {
            List<Banka_krvi> lista = new List<Banka_krvi>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Banka_krvi";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Banka_krvi bk = new Banka_krvi();
                    bk.Krvna_grupa = reader.GetString(0);
                    bk.Zalihe = reader.GetInt32(1);
                    lista.Add(bk);
                }

            }
            return lista;
        }

            public int AzuriranjeListeKrvi(Banka_krvi bk)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {

                    string sqlCommand = "UPDATE Banka_krvi SET Krvna_grupa = @Krvna_grupa, Zalihe = @Zalihe WHERE Krvna_grupa = @Krvna_grupa";
                    SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                    command.Parameters.AddWithValue("@Banka_krvi", bk.Krvna_grupa);
                    command.Parameters.AddWithValue("@Zalihe", bk.Zalihe);

                    sqlConnection.Open();

                    return command.ExecuteNonQuery();
                }
            }

        }
    }
