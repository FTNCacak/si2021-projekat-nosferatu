using BusinessLayer;
using DataLayer;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;

namespace Nosfteratu
{
    public partial class Doniranje : Form
    {
        private readonly IDonorBusiness donorBusiness;
        private readonly IKrvnaGrupaBusiness krvnaGrupaBusiness;
        
        public Doniranje()
        {
            InitializeComponent();

            IDonorRepository donorRepository = new DonorRepository();
            this.donorBusiness = new DonorBusiness(donorRepository);

            IKrvnaGrupaRepository krvnaGrupaRepository = new KrvnaGrupaRepository();
            this.krvnaGrupaBusiness = new KrvnaGrupaBusiness(krvnaGrupaRepository);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string ime = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string prezime = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string krv = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;

                textBoxIme.Text = ime;
                textBoxPrezime.Text = prezime;
                textBoxKrvnaGrupa.Text = krv;
            }
        }

        private void Doniranje_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = donorBusiness.GetAllDonors();
                this.dataGridView2.DataSource = krvnaGrupaBusiness.GetAllKrvnaGrupa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Doniraj_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "")
            {
                MessageBox.Show("Odaberite donora");
            }
            else
            {

                 List<KrvnaGrupa> listOfKrv = this.krvnaGrupaBusiness.GetAllKrvnaGrupa();

                 foreach (KrvnaGrupa item in listOfKrv)
                 {
                     if (item.Krvna_grupa == textBoxKrvnaGrupa.Text) { 
                         item.Zalihe++;
                         this.krvnaGrupaBusiness.UpdateKrv(item);
                        this.dataGridView2.DataSource = krvnaGrupaBusiness.GetAllKrvnaGrupa();
                    }
                 }
             
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ListaDonora cf = new ListaDonora();
            cf.Visible = true;
        }
    }
}
