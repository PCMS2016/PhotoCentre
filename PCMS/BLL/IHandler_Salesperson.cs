using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Salesperson
    {
        bool AddSalesperson(Salesperson salesperson);
        bool UpdateSalesperson(Salesperson salesperson);
        bool RemoveSalesperson(int SalesonID);
        List<Salesperson> GetAllSalespersons();
        List<Salesperson> SearchSalesperson(string Name, string Surname);
    }
}
