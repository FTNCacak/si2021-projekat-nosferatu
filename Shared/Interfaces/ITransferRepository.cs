using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
   public interface ITransferRepository
    {
        DataTable GetAllTransfer();
         int InsertTransfer(Transfer t);

    }
}
