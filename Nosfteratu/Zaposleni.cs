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
    public partial class Zaposleni : Form
    {
        private readonly IRadnikBusiness radnikBusiness;
        public Zaposleni()
        {
            InitializeComponent();
            IRadnikRepository donorRepository = new RadnikRepository();
            this.radnikBusiness = new RadnikBusiness(donorRepository);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Radnik radnik = new Radnik();
            radnik.Id = Convert.ToInt32(textBoxID.Text);
            radnik.Korisnicko_ime = textBoxUserName.Text;
            radnik.Sifra = textBoxPassword.Text;
           

            this.radnikBusiness.UpdateRadnik(radnik);
            this.dataGridViewRadnik.DataSource = radnikBusiness.GetAllRadnik();

            textBoxID.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Id = int.Parse(textBoxID.Text);

            string result = this.radnikBusiness.DeleteRadnik(Id);
            this.dataGridViewRadnik.DataSource = radnikBusiness.GetAllRadnik();
            textBoxID.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" )
            {
                MessageBox.Show("Please fullfill whole form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Radnik radnik = new Radnik();

           // radnik.Id = Convert.ToInt32(textBoxID.Text);
            radnik.Korisnicko_ime = textBoxUserName.Text;
            radnik.Sifra = textBoxPassword.Text;

            this.radnikBusiness.InsertRadnik(radnik);
            this.dataGridViewRadnik.DataSource = radnikBusiness.GetAllRadnik();

            textBoxID.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

   
        private void Zaposleni_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridViewRadnik.DataSource = radnikBusiness.GetAllRadnik();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridViewRadnik_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRadnik.SelectedRows.Count > 0)
            {
                
                string a = dataGridViewRadnik.SelectedRows[0].Cells[0].Value + string.Empty;
                string b = dataGridViewRadnik.SelectedRows[0].Cells[1].Value + string.Empty;
                string c = dataGridViewRadnik.SelectedRows[0].Cells[2].Value + string.Empty;


                 textBoxID.Text = a;
                 textBoxUserName.Text = b;
                 textBoxPassword.Text = c;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login cf = new Login();
            cf.Visible = true;
        }
    }
}
