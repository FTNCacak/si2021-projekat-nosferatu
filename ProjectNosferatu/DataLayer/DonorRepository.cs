using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Models;

namespace DataLayer
{
    public class DonorRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Donor> VratiDonora()
        {
            List<Donor> listaDonora = new List<Donor>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Donator";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Donor d = new Donor();
                    d.Id = reader.GetInt32(0);
                    d.Ime = reader.GetString(1);
                    d.Prezime = reader.GetString(2);
                    d.Datum_rodjenja = reader.GetDateTime(3);
                    d.Pol = reader.GetString(4);
                    d.Telefon = reader.GetString(5);
                    d.Adresa = reader.GetString(6);
                    d.Krvna_grupa = reader.GetString(7);
                    listaDonora.Add(d);
                }

            }
            return listaDonora;
        }

        public int UnesiNovogDonora(Donor d)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Donator VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    d.Id, d.Ime, d.Prezime, d.Datum_rodjenja, d.Pol, d.Telefon, d.Adresa, d.Krvna_grupa);

                return command.ExecuteNonQuery();

            }
        }
            public int AzuriranjeDonora(Donor d)
             { 
                using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                string sqlCommand = "UPDATE Donator SET Id = @Id, Ime = @Ime, Prezime = @Prezime, Datum_rodjenja = @Datum_rodjenja, Pol = @Pol, Telefon = @Telefon, Adresa = @Adresa, Krvna_grupa = @Krvna_grupa WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", d.Id);
                command.Parameters.AddWithValue("@Ime", d.Ime);
                command.Parameters.AddWithValue("@Prezime", d.Prezime);
                command.Parameters.AddWithValue("@Datum_rodjenja", d.Datum_rodjenja);
                command.Parameters.AddWithValue("@Pol", d.Pol);
                command.Parameters.AddWithValue("@Telefon", d.Telefon);
                command.Parameters.AddWithValue("@Adresa", d.Adresa);
                command.Parameters.AddWithValue("@Krvna_grupa", d.Krvna_grupa);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int BrisanjeDonora(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Donator WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }

    }
}
