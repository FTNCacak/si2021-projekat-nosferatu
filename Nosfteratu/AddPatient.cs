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
    public partial class AddPatient : Form
    {
        private readonly IPacijentBusiness pacijentBusiness;
        public AddPatient()
        {
            InitializeComponent();
            IPacijentRepository donorRepository = new PacijentRepository();
            this.pacijentBusiness = new PacijentBusiness(donorRepository);
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

            Pacijent pacijent = new Pacijent();

            pacijent.Ime = textBoxIme.Text;
            pacijent.Prezime = textBoxPrezime.Text;
            pacijent.Telefon = textBoxTelefon.Text;
            pacijent.Adresa = richTextBoxAdresa.Text;
            pacijent.Datum_rodjenja = dateTimePicker1.Value;
            pacijent.Pol = comboBoxPol.Text;
            pacijent.Krvna_grupa = comboBoxKrv.Text;

            this.pacijentBusiness.InsertPacijent(pacijent);
            pacijentBusiness.GetAllPacijent();
           // ListaPacijenata.refreshData();


            textBoxID.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            comboBoxPol.Text = "";
            comboBoxKrv.Text = "";
            textBoxTelefon.Text = "";
            richTextBoxAdresa.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ListaPacijenata cf = new ListaPacijenata();
            cf.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
