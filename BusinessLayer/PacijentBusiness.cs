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
    public class PacijentBusiness : IPacijentBusiness
    {
        private readonly IPacijentRepository pacijentRepository;
        public PacijentBusiness(IPacijentRepository _pacijentRepository)
        {
            pacijentRepository = _pacijentRepository;
        }

        public string DeletePacijent(int id)
        {
            int rowsAffected = this.pacijentRepository.DeletePacijent(id);

            if (rowsAffected > 0)
            {
                return "Uspešno obrisan podatak iz baze podataka!";
            }
            else
            {
                return "Brisanje nije uspelo, došlo je do greške!";
            }
        }

        public DataTable GetAllPacijent()
        {
            return this.pacijentRepository.GetAllPacijent();
        }

        public List<Pacijent> GetAllPacijentList()
        {
            return this.pacijentRepository.GetAllPacijentList();
        }

        public string InsertPacijent(Pacijent pacijent)
        {
            int rowsAffected = this.pacijentRepository.InsertPacijent(pacijent);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }

        public string UpdatePacijent(Pacijent pacijent)
        {
            int rowsAffected = this.pacijentRepository.UpdatePacijent(pacijent);

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
