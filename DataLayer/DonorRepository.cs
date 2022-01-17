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
    public class DonorRepository : IDonorRepository
    {
        public string ConString = Constants.connString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable GetAllDonors()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Donator", con);
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

        public int InsertDonor(Donor donor)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Donator VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    donor.Ime, donor.Prezime, donor.Datum_rodjenja, donor.Pol, donor.Telefon, donor.Adresa, donor.Krvna_grupa);

                return command.ExecuteNonQuery();
            }


        }

        public int UpdateDonor(Donor donor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                string sqlCommand = "UPDATE Donator SET Ime = @Ime, Prezime = @Prezime, Datum_rodjenja = @Datum_rodjenja, Pol = @Pol, Telefon = @Telefon, Adresa = @Adresa, Krvna_grupa = @Krvna_grupa WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                command.Parameters.AddWithValue("@Id", donor.Id);
                command.Parameters.AddWithValue("@Ime", donor.Ime);
                command.Parameters.AddWithValue("@Prezime", donor.Prezime);
                command.Parameters.AddWithValue("@Datum_rodjenja", donor.Datum_rodjenja);
                command.Parameters.AddWithValue("@Pol", donor.Pol);
                command.Parameters.AddWithValue("@Telefon", donor.Telefon);
                command.Parameters.AddWithValue("@Adresa", donor.Adresa);
                command.Parameters.AddWithValue("@Krvna_grupa", donor.Krvna_grupa);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteDonor(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
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
