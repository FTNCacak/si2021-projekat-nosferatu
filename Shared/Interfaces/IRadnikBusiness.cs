using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
   public interface IRadnikBusiness
    {
        List<Radnik> GetAllRadnikList();
        DataTable GetAllRadnik();
        string InsertRadnik(Radnik r);
        string UpdateRadnik(Radnik r);
        string DeleteRadnik(int id);
    }
}
