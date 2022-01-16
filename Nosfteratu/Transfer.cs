using BusinessLayer;
using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nosfteratu
{
    public partial class Transfer : Form
    {
        private readonly IPacijentBusiness pacijentBusiness;
        private readonly IKrvnaGrupaBusiness krvnaGrupaBusiness;
        private readonly ITransferBusiness transferBusiness;
        public Transfer()
        {
            InitializeComponent();

            ITransferRepository transferRepository = new TransferRepository();
            this.transferBusiness = new TransferBusiness(transferRepository);
            IKrvnaGrupaRepository krvnaGrupaRepository = new KrvnaGrupaRepository();
            this.krvnaGrupaBusiness = new KrvnaGrupaBusiness(krvnaGrupaRepository);
            IPacijentRepository pacijentRepository = new PacijentRepository();
            this.pacijentBusiness = new PacijentBusiness(pacijentRepository);

        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            List<KrvnaGrupa> listOfKrv = this.krvnaGrupaBusiness.GetAllKrvnaGrupa();
            List<Pacijent> listOfPacijent = this.pacijentBusiness.GetAllPacijentList();

            foreach (KrvnaGrupa item in listOfKrv)
            {
                if (item.Krvna_grupa == textBoxKrvnaGrupa.Text)
                {
                    item.Zalihe--;
                    this.krvnaGrupaBusiness.UpdateKrv(item);
                }
            }
            
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxID.Text = "";
            textBoxKrvnaGrupa.Clear();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* int penis = Convert.ToInt32(comboBoxID.Text);
             List<Pacijent> listOfPacijent = this.pacijentBusiness.GetAllPacijentList();
             foreach (Pacijent itemp in listOfPacijent)
             {

                     textBoxIme.Text = itemp.Ime;
                     textBoxPrezime.Text = itemp.Prezime;
                     textBoxKrvnaGrupa.Text = itemp.Krvna_grupa;


             }
             label1.Text = Convert.ToString(penis);*/

            String ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConString);
            SqlCommand sc = new SqlCommand("Select * from Pacijent Where Id='" + comboBoxID.Text + "'", con);
            con.Open();
            sc.ExecuteNonQuery();
            SqlDataReader dr;
            dr = sc.ExecuteReader();
            while (dr.Read())
            {
                string ime = (string)dr["Ime"].ToString();
                textBoxIme.Text = ime;
                string prezime = (string)dr["Prezime"].ToString();
                textBoxPrezime.Text = prezime;
                string krv = (string)dr["Krvna_grupa"].ToString();
                textBoxKrvnaGrupa.Text = krv;

            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            List<Pacijent> listOfPacijent = this.pacijentBusiness.GetAllPacijentList();
            /* foreach (Pacijent itemp in listOfPacijent)
             {
                 comboBoxID.Items.Add(itemp.Id);
             }*/
            String ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConString);
            SqlCommand sc;
            SqlDataReader dr;

            String sql = "Select * From Pacijent";
            try
            {
                con.Open();
                sc = new SqlCommand(sql, con);
                dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxID.Items.Add(dr.GetValue(0).ToString());

                }

                sc.Dispose();
                con.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}