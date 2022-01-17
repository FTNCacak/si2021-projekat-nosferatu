using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
   public interface IDonorBusiness
    {
        DataTable GetAllDonors();
        string InsertDonor(Donor d);
        string UpdateDonor(Donor d);
        string DeleteDonor(int id);
    }
}
