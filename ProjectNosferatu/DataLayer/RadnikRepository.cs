using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Models;

namespace DataLayer
{
    public class RadnikRepository
    {
        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Radnik> VratiRadnika()
        {
            List<Radnik> listaRadnika = new List<Radnik>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Radnik";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Radnik r = new Radnik();
                    r.Id  = reader.GetInt32(0);
                    r.Korisnicko_ime = reader.GetString(1);
                    r.Sifra = reader.GetString(2);
                    listaRadnika.Add(r);
                }

            }
            return listaRadnika;
        }

        public int UnesiNovogRadnika(Radnik r)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {

                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Radnik VALUES('{0}','{1}','{2}')", r.Id, r.Korisnicko_ime, r.Sifra);

                return command.ExecuteNonQuery();

            }
        }
            public int AzuriranjeRadnika(Radnik r)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                
                    string sqlCommand = "UPDATE Radnik SET Id = @Id, Korisnicko_ime = @Korisnicko_ime, Sifra = @Sifra WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                    command.Parameters.AddWithValue("@Id", r.Id);
                    command.Parameters.AddWithValue("@Korisnicko_ime", r.Korisnicko_ime);
                    command.Parameters.AddWithValue("@Sifra", r.Sifra);

                    sqlConnection.Open();

                    return command.ExecuteNonQuery();
                }
            }

            public int BrisanjeRadnika(int id)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "DELETE FROM Radnik WHERE Id = " + id;

                    return command.ExecuteNonQuery();
                }
            }

        }
}
