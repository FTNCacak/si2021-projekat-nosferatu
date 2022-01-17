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
    public class PacijentRepository : IPacijentRepository 
    {
        public string ConString = Constants.connString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable GetAllPacijent()
        {
                con.ConnectionString = ConString;
           
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Pacijent", con);
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

        public int InsertPacijent(Pacijent pacijent)
        {
           
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Pacijent VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    pacijent.Ime, pacijent.Prezime, pacijent.Datum_rodjenja, pacijent.Pol, pacijent.Telefon, pacijent.Adresa, pacijent.Krvna_grupa);

                return command.ExecuteNonQuery();
            }


        }

        public int UpdatePacijent(Pacijent pacijent)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                string sqlCommand = "UPDATE Pacijent SET Ime = @Ime, Prezime = @Prezime, Datum_rodjenja = @Datum_rodjenja, Pol = @Pol, Telefon = @Telefon, Adresa = @Adresa, Krvna_grupa = @Krvna_grupa WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", pacijent.Id);
                command.Parameters.AddWithValue("@Ime", pacijent.Ime);
                command.Parameters.AddWithValue("@Prezime", pacijent.Prezime);
                command.Parameters.AddWithValue("@Datum_rodjenja", pacijent.Datum_rodjenja);
                command.Parameters.AddWithValue("@Pol", pacijent.Pol);
                command.Parameters.AddWithValue("@Telefon", pacijent.Telefon);
                command.Parameters.AddWithValue("@Adresa", pacijent.Adresa);
                command.Parameters.AddWithValue("@Krvna_grupa", pacijent.Krvna_grupa);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeletePacijent(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Pacijent WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }

        public List<Pacijent> GetAllPacijentList()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Pacijent";

            SqlDataReader dataReader = command.ExecuteReader();

            List<Pacijent> listOfPacijent = new List<Pacijent>();

            while (dataReader.Read())
            {
                Pacijent pacijent = new Pacijent();
                pacijent.Id = dataReader.GetInt32(0);
                pacijent.Ime = dataReader.GetString(1);
                pacijent.Prezime = dataReader.GetString(2);
                pacijent.Datum_rodjenja = dataReader.GetDateTime(3);
                pacijent.Pol = dataReader.GetString(4);
                pacijent.Telefon = dataReader.GetString(5);
                pacijent.Adresa = dataReader.GetString(6);
                pacijent.Krvna_grupa = dataReader.GetString(7);


                listOfPacijent.Add(pacijent);
            }

            sqlConnection.Close();

            return listOfPacijent;
        }
    }
}
