using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
   public interface IDonorRepository
    {
        DataTable GetAllDonors();
        int InsertDonor(Donor d);
        int UpdateDonor(Donor d);
        int DeleteDonor(int id);
    }
}
