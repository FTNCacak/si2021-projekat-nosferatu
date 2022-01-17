using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RadnikRepository : IRadnikRepository
    {
        public string ConString = Constants.connString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public int DeleteRadnik(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Radnik WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllRadnik()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Radnik", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public List<Radnik> GetAllRadnikList()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Radnik";

            SqlDataReader dataReader = command.ExecuteReader();

            List<Radnik> lista = new List<Radnik>();

            while (dataReader.Read())
            {
                Radnik radnik = new Radnik();
                radnik.Id = dataReader.GetInt32(0);
                radnik.Korisnicko_ime = dataReader.GetString(1);
                radnik.Sifra = dataReader.GetString(2);


                lista.Add(radnik);
            }

            sqlConnection.Close();

            return lista;
        }
    

        public int InsertRadnik(Radnik r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Radnik VALUES('{0}','{1}')",
                    r.Korisnicko_ime, r.Sifra);

                return command.ExecuteNonQuery();
            }
        }

        public int UpdateRadnik(Radnik r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string sqlCommand = "UPDATE Radnik SET  Korisnicko_ime = @Korisnicko_ime, Sifra = @Sifra WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", r.Id);
                command.Parameters.AddWithValue("@Korisnicko_ime", r.Korisnicko_ime);
                command.Parameters.AddWithValue("@Sifra", r.Sifra);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
