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
    public class KrvnaGrupaRepository : IKrvnaGrupaRepository
    {
        public string ConString = Constants.connString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable GetAllKrv()
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
        public List<KrvnaGrupa> GetAllKrvnaGrupa()
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = Constants.connString;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "SELECT * FROM Banka_krvi";

            SqlDataReader dataReader = command.ExecuteReader();

            List<KrvnaGrupa> listOfKrvnaGrupa = new List<KrvnaGrupa>();

            while (dataReader.Read())
            {
                KrvnaGrupa krvnaGrupa = new KrvnaGrupa();
                krvnaGrupa.Krvna_grupa = dataReader.GetString(0);
                krvnaGrupa.Zalihe = dataReader.GetInt32(1);


                listOfKrvnaGrupa.Add(krvnaGrupa);
            }

            sqlConnection.Close();

            return listOfKrvnaGrupa;
        }

        public int UpdateKrv(KrvnaGrupa kg)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                string sqlCommand = "UPDATE Banka_krvi SET Krvna_grupa = @Krvna_grupa, Zalihe = @Zalihe WHERE Krvna_grupa = @Krvna_grupa";
            SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
            command.Parameters.AddWithValue("@Krvna_grupa", kg.Krvna_grupa);
            command.Parameters.AddWithValue("@Zalihe", kg.Zalihe);

            sqlConnection.Open();

            return command.ExecuteNonQuery();
            }
        }
    }
}
