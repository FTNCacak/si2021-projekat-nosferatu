using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
   public interface IPacijentBusiness
    {
        List<Pacijent> GetAllPacijentList();
        DataTable GetAllPacijent();
        string InsertPacijent(Pacijent p);
        string UpdatePacijent(Pacijent p);
        string DeletePacijent(int id);

    }
}
