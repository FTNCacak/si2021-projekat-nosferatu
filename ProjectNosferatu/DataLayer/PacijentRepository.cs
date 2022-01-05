using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Models;

namespace DataLayer
{
    public class PacijentRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Pacijent> VratiPacijenta()
        {
            List<Pacijent> listaPacijenata = new List<Pacijent>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Pacijent";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pacijent p = new Pacijent();
                    p.Id = reader.GetInt32(0);
                    p.Ime = reader.GetString(1);
                    p.Prezime = reader.GetString(2);
                    p.Datum_rodjenja = reader.GetDateTime(3);
                    p.Pol = reader.GetString(4);
                    p.Telefon = reader.GetString(5);
                    p.Adresa = reader.GetString(6);
                    p.Krvna_grupa = reader.GetString(7);
                    listaPacijenata.Add(p);
                }

            }
            return listaPacijenata;
        }

        public int UnesiNovogPacijenta(Pacijent p)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Pacijent VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    p.Id, p.Ime, p.Prezime, p.Datum_rodjenja, p.Pol, p.Telefon, p.Adresa, p.Krvna_grupa);

                return command.ExecuteNonQuery();

            }
        }

            public int AzuriranjePacijenta(Pacijent p)
            { 
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {

                    string sqlCommand = "UPDATE Pacijent SET Id = @Id, Ime = @Ime, Prezime = @Prezime, Datum_rodjenja = @Datum_rodjenja, Pol = @Pol, Telefon = @Telefon, Adresa = @Adresa, Krvna_grupa = @Krvna_grupa WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                    command.Parameters.AddWithValue("@Id", p.Id);
                    command.Parameters.AddWithValue("@Ime", p.Ime);
                    command.Parameters.AddWithValue("@Prezime", p.Prezime);
                    command.Parameters.AddWithValue("@Datum_rodjenja", p.Datum_rodjenja);
                    command.Parameters.AddWithValue("@Pol", p.Pol);
                    command.Parameters.AddWithValue("@Telefon", p.Telefon);
                    command.Parameters.AddWithValue("@Adresa", p.Adresa);
                    command.Parameters.AddWithValue("@Krvna_grupa", p.Krvna_grupa);

                sqlConnection.Open();

                    return command.ExecuteNonQuery();
                }
            }

            public int BrisanjePacijenta(int id)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "DELETE FROM Pacijent WHERE Id = " + id;

                    return command.ExecuteNonQuery();
                }
            }

        }
    }
