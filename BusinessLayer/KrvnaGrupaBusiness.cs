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
   public class KrvnaGrupaBusiness : IKrvnaGrupaBusiness
    {
        private readonly IKrvnaGrupaRepository krvnaGrupaRepository;
        public KrvnaGrupaBusiness(IKrvnaGrupaRepository _krvnaGrupaRepository)
        {
            krvnaGrupaRepository = _krvnaGrupaRepository;
        }


        public DataTable GetAllKrv()
        {
            try
            {
                KrvnaGrupaRepository obj = new KrvnaGrupaRepository();
                return obj.GetAllKrv();
            }
            catch
            {
                throw;
            }
        }

        public List<KrvnaGrupa> GetAllKrvnaGrupa()
        {
            return this.krvnaGrupaRepository.GetAllKrvnaGrupa();
        }
        public string UpdateKrv(KrvnaGrupa krvnaGrupa)
        {
            int rowsAffected = this.krvnaGrupaRepository.UpdateKrv(krvnaGrupa);

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
