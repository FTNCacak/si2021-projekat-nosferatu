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

namespace Nosfteratu
{
    public partial class ListaDonora : Form
    {
        private readonly IDonorBusiness donorBusiness;
        public ListaDonora()
        {
            InitializeComponent();
            IDonorRepository donorRepository = new DonorRepository();
            this.donorBusiness = new DonorBusiness(donorRepository);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            Donor donor = new Donor();
            donor.Id = Convert.ToInt32(textBoxID.Text);
            donor.Ime = textBoxIme.Text;
            donor.Prezime = textBoxPrezime.Text;
            donor.Telefon = textBoxTelefon.Text;
            donor.Adresa = richTextBoxAdresa.Text;
            donor.Datum_rodjenja = dateTimePicker1.Value;
            donor.Pol = comboBoxPol.Text;
            donor.Krvna_grupa = comboBoxKrv.Text;

            this.donorBusiness.UpdateDonor(donor);
            this.dataGridView1.DataSource = donorBusiness.GetAllDonors();

            textBoxID.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxPol.SelectedIndex=-1;
            comboBoxKrv.SelectedIndex = -1;
            textBoxTelefon.Text = "";
            richTextBoxAdresa.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textBoxID.Text);

            string result = this.donorBusiness.DeleteDonor(Id);
            this.dataGridView1.DataSource = donorBusiness.GetAllDonors();
            textBoxID.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxPol.Text = "";
            comboBoxKrv.Text = "";
            textBoxTelefon.Text = "";
            richTextBoxAdresa.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void ListaDonora_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = donorBusiness.GetAllDonors();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string ime = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string prezime = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string datum = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string pol = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string telefon = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                string adresa = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                string krv = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;

                textBoxID.Text = id;
                textBoxIme.Text = ime;
                textBoxPrezime.Text = prezime;
                dateTimePicker1.Text = datum;
                comboBoxPol.Text = pol;
                textBoxTelefon.Text = telefon;
                richTextBoxAdresa.Text = adresa;
                comboBoxKrv.Text = krv;

            }
        }

        private void buttonDonation_Click(object sender, EventArgs e)
        {
            this.Close();
            Doniranje cf = new Doniranje();
            cf.Visible = true;
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            this.Close();
            AddDonor cf = new AddDonor();
            cf.Visible = true;
        }

        private void DonorsButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDonorsButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddDonor cf = new AddDonor();
            cf.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            AddDonor cf = new AddDonor();
            cf.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Doniranje cf = new Doniranje();
            cf.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Doniranje cf = new Doniranje();
            cf.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaPacijenata cf = new ListaPacijenata();
            cf.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaPacijenata cf = new ListaPacijenata();
            cf.Visible = true;
        }

       
    }
}
