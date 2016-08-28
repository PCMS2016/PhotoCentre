using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Salesperson
    {
        bool AddSalesperson(Salesperson salesperson);
        bool UpdateSalesperson(Salesperson salesperson);
        bool RemoveSalesperson(int SalespersonID);
        List<Salesperson> GetAllSalespersons();
        List<Salesperson> SearchSalesperson(string Name, string Surname);
    }
}
