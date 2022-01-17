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
    public partial class Transferi : Form
    {
        private readonly ITransferBusiness transferBusiness;
        private readonly IPacijentBusiness pacijentBusiness;
        private readonly IKrvnaGrupaBusiness krvnaGrupaBusiness;
      
        public Transferi()
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
            if (comboBoxID.Text == "" || textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxKrvnaGrupa.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<KrvnaGrupa> listOfKrv = this.krvnaGrupaBusiness.GetAllKrvnaGrupa();
            List<Pacijent> listOfPacijent = this.pacijentBusiness.GetAllPacijentList();

            foreach (KrvnaGrupa item in listOfKrv)
            {
                if (item.Krvna_grupa == textBoxKrvnaGrupa.Text)
                {
                    if (item.Zalihe > 0)
                    {
                        item.Zalihe--;
                        this.krvnaGrupaBusiness.UpdateKrv(item);
                    }
                    else
                    {
                        MessageBox.Show("Nije moguc transfer");break;
                    }
                }
            }
               /*  if (textBoxKrvnaGrupa.Text=="AB-")
                {
                    foreach (KrvnaGrupa o in listOfKrv)
                    {
                    if (o.Krvna_grupa == textBoxKrvnaGrupa.Text)
                    {
                        if (o.Zalihe > 0)
                        {
                            o.Zalihe--;
                            this.krvnaGrupaBusiness.UpdateKrv(o);
                        }break;
                    }
                    else if (o.Krvna_grupa == "A-")
                    {
                        if (o.Zalihe > 0)
                        {
                            o.Zalihe--;
                            this.krvnaGrupaBusiness.UpdateKrv(o);
                        }
                    }
                    else if(o.Krvna_grupa == "B-")
                    {
                        if (o.Zalihe > 0)
                        {
                            o.Zalihe--;
                            this.krvnaGrupaBusiness.UpdateKrv(o);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nije moguc transfer");
                    }
                    }    
                   }*/

            Transfer t = new Transfer();

            t.Ime_pacijenta = textBoxIme.Text;
            t.Prezime_pacijenta = textBoxPrezime.Text;
            t.Krvna_grupa = textBoxKrvnaGrupa.Text;
            

            this.transferBusiness.InsertTransfer(t);

            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxID.Text = "";
            textBoxKrvnaGrupa.Clear();
        }
        
        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
    

            String ConString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
          //  List<Pacijent> listOfPacijent = this.pacijentBusiness.GetAllPacijentList();
            /* foreach (Pacijent itemp in listOfPacijent)
             {
                 comboBoxID.Items.Add(itemp.Id);
             }*/
            String ConString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Donacije_krviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            ListaPacijenata cf = new ListaPacijenata();
            cf.Visible = true;
        }
    }
}