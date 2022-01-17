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
    public partial class Login : Form
    {
        private readonly IRadnikBusiness radnikBusiness;
        public Login()
        {
            InitializeComponent();
            IRadnikRepository donorRepository = new RadnikRepository();
            this.radnikBusiness = new RadnikBusiness(donorRepository);
        }

        private void label3_Click(object sender, EventArgs e)
        {
               this.Hide();
             Admin cf = new Admin();
             cf.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<Radnik> lista = new List<Radnik>();
            lista = this.radnikBusiness.GetAllRadnikList();
            foreach (Radnik item in lista)
            {
                if (item.Korisnicko_ime.Equals(textBoxUserName.Text) && item.Sifra.Equals(textBoxPassword.Text))
                {
                    this.Hide();
                   ListaDonora  cf = new ListaDonora();
                    cf.Visible = true;
                }
                else
                {

                    MessageBox.Show("Pogresan unos");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
