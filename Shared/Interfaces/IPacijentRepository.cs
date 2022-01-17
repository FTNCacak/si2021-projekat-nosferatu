using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IPacijentRepository
    {
        List<Pacijent> GetAllPacijentList();
        DataTable GetAllPacijent();
        int InsertPacijent(Pacijent p);
        int UpdatePacijent(Pacijent p);
        int DeletePacijent(int id);
    }
}
