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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nosfteratu
{
    public partial class AddDonor : Form
    {
        private readonly IDonorBusiness donorBusiness;
        public AddDonor()
        {
            InitializeComponent();
            IDonorRepository donorRepository = new DonorRepository();
            this.donorBusiness = new DonorBusiness(donorRepository);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxTelefon.Text == "" || richTextBoxAdresa.Text == "" || comboBoxKrv.Text == "" || comboBoxPol.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(textBoxIme.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("First name input has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIme.Focus();
                return;
            }
            if (!Regex.Match(textBoxPrezime.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Last name input has an error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPrezime.Focus();
                return;
            }
            

            Donor don = new Donor();

            don.Ime = textBoxIme.Text;
            don.Prezime = textBoxPrezime.Text;
            don.Telefon = textBoxTelefon.Text;
            don.Adresa = richTextBoxAdresa.Text;
            don.Datum_rodjenja = dateTimePicker1.Value;
            don.Pol = comboBoxPol.Text;
            don.Krvna_grupa = comboBoxKrv.Text;

             this.donorBusiness.InsertDonor(don);



            textBoxID.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxPol.Text = "";
            comboBoxKrv.Text = "";
            textBoxTelefon.Text = "";
            richTextBoxAdresa.Text = "";
            dateTimePicker1.Value = DateTime.Now;


        }

        private void buttonPacijent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient cf = new AddPatient();
            cf.Visible = true;
        }

        private void buttonPacijentList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaPacijenata cf = new ListaPacijenata();
            cf.Visible = true;
        }

        private void buttonDonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDonora cf = new ListaDonora();
            cf.Visible = true;
        }

        private void buttonDoniranje_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doniranje cf = new Doniranje();
            cf.Visible = true;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferi cf = new Transferi();
            cf.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ListaDonora cf = new ListaDonora();
            cf.Visible = true;
        }
    }
}
