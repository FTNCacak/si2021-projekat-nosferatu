using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RadnikBusiness : IRadnikBusiness
    {
        private readonly IRadnikRepository radnikRepository;
        public RadnikBusiness(IRadnikRepository _radnikRepository)
        {
            radnikRepository = _radnikRepository;
        }
        public string DeleteRadnik(int id)
        {
            int rowsAffected = this.radnikRepository.DeleteRadnik(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak iz baze podataka!";
            }
            else
            {
                return "Brisanje nije uspelo, došlo je do greške!";
            }
        }

        public DataTable GetAllRadnik()
        {
            try
            {
                RadnikRepository obj = new RadnikRepository();
                return obj.GetAllRadnik();
            }
            catch
            {
                throw;
            }
        }

        public List<Radnik> GetAllRadnikList()
        {
            return this.radnikRepository.GetAllRadnikList();
        }

        public string InsertRadnik(Radnik r)
        {
            int rowsAffected = this.radnikRepository.InsertRadnik(r);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }

        public string UpdateRadnik(Radnik r)
        {
            int rowsAffected = this.radnikRepository.UpdateRadnik(r);

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
