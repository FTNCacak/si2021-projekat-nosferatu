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
    public class TransferBusiness : ITransferBusiness
    {
        private readonly ITransferRepository transferRepository;
        public TransferBusiness(ITransferRepository _transferRepository)
        {
            transferRepository = _transferRepository;
        }
        public DataTable GetAllTransfer()
        {
            try
            {
                TransferRepository obj = new TransferRepository();
                return obj.GetAllTransfer();
            }
            catch
            {
                throw;
            }
        }

        public string InsertTransfer(Transfer transfer)
        {
            int rowsAffected = this.transferRepository.InsertTransfer(transfer);

            if (rowsAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }
    }
}
