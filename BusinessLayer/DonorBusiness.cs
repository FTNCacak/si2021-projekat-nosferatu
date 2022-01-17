using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DonorBusiness : IDonorBusiness
    {
        private readonly IDonorRepository donorRepository;
        public DonorBusiness(IDonorRepository _donorRepository)
        {
            donorRepository = _donorRepository;
        }

        public string DeleteDonor(int id)
        {
            int rowsAffected = this.donorRepository.DeleteDonor(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak iz baze podataka!";
            }
            else
            {
                return "Brisanje nije uspelo, došlo je do greške!";
            }
        }

        public DataTable GetAllDonors()
        {
            try
            {
                 DonorRepository obj = new DonorRepository();
                return obj.GetAllDonors();
            }
            catch
            {
                throw;
            }
        }

        public string InsertDonor(Donor d)
        {
            int rowsAffected = this.donorRepository.InsertDonor(d);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }

        public string UpdateDonor(Donor d)
        {
            int rowsAffected = this.donorRepository.UpdateDonor(d);

            if (rowsAffected > 0)
            {
                return "Uspešna izmena u bazi podataka!";
            }
            else
            {
                return "Neuspešna izmena, došlo je do greške!";
            }
        }
    }
}
