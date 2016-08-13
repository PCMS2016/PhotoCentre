using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Salesperson : IHandler_Salesperson
    {
        private IDBAccess_Salesperson db = null;
        public Handler_Salesperson()
        {
            db = new DBAccess_Salesperson();
        }
        public bool AddSalesperson(Salesperson salesperson)
        {
            return db.AddSalesperson(salesperson);
        }

        public List<Salesperson> GetAllSalespersons()
        {
            return db.GetAllSalespersons();
        }

        public bool RemoveSalesperson(int SalespersonID)
        {
            return db.RemoveSalesperson(SalespersonID);
        }

        public List<Salesperson> SearchSalesperson(string Name, string Surname)
        {
            return db.SearchSalesperson(Name, Surname);
        }

        public bool UpdateSalesperson(Salesperson salesperson)
        {
            return db.UpdateSalesperson(salesperson);
        }
    }
}
