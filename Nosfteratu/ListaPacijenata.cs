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
    public partial class ListaPacijenata : Form
    {
        private readonly IPacijentBusiness pacijentBusiness;
        public ListaPacijenata()
        {
            InitializeComponent();
            IPacijentRepository donorRepository = new PacijentRepository();
            this.pacijentBusiness = new PacijentBusiness(donorRepository);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Pacijent pacijent = new Pacijent();
                pacijent.Id = Convert.ToInt32(textBoxID.Text);
                pacijent.Ime = textBoxIme.Text;
                pacijent.Prezime = textBoxPrezime.Text;
                pacijent.Telefon = textBoxTelefon.Text;
                pacijent.Adresa = richTextBoxAdresa.Text;
                pacijent.Datum_rodjenja = dateTimePicker1.Value;
                pacijent.Pol = comboBoxPol.Text;
                pacijent.Krvna_grupa = comboBoxKrv.Text;

                this.pacijentBusiness.UpdatePacijent(pacijent);
                this.dataGridView1.DataSource = pacijentBusiness.GetAllPacijent();

                textBoxID.Clear();
                textBoxIme.Clear();
                textBoxPrezime.Clear();
                comboBoxPol.SelectedIndex = -1;
                comboBoxKrv.SelectedIndex = -1;
                textBoxTelefon.Text = "";
                richTextBoxAdresa.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
            catch
            {

              
            }
        }

        private void ListaPacijenata_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = pacijentBusiness.GetAllPacijent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBoxID.Text);

                string result = this.pacijentBusiness.DeletePacijent(Id);
                this.dataGridView1.DataSource = pacijentBusiness.GetAllPacijent();
                textBoxID.Clear();
                textBoxIme.Clear();
                textBoxPrezime.Clear();
                comboBoxPol.Text = "";
                comboBoxKrv.Text = "";
                textBoxTelefon.Text = "";
                richTextBoxAdresa.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
            catch { }
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

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferi cf = new Transferi();
            cf.Visible = true;
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient cf = new AddPatient();
            cf.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddPatient cf = new AddPatient();
            cf.Visible = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            AddPatient cf = new AddPatient();
            cf.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Transferi cf = new Transferi();
            cf.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Transferi cf = new Transferi();
            cf.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void donorsIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDonora cf = new ListaDonora();
            cf.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDonora cf = new ListaDonora();
            cf.Visible = true;
        }
    }
}
