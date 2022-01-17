using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IRadnikRepository
    {
        List<Radnik> GetAllRadnikList();
        DataTable GetAllRadnik();
        int InsertRadnik(Radnik r);
        int UpdateRadnik(Radnik r);
        int DeleteRadnik(int id);

    }
}
