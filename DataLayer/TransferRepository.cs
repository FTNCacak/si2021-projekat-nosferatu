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
    public class TransferRepository : ITransferRepository
    {
        public string ConString = Constants.connString;
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();
        public DataTable GetAllTransfer()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tranfer", con);
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
        public int InsertTransfer(Transfer transfer)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Transfer VALUES('{0}','{1}','{2}')",
                     transfer.Ime_pacijenta, transfer.Prezime_pacijenta, transfer.Krvna_grupa);

                return command.ExecuteNonQuery();
            }


        }


    }
}
