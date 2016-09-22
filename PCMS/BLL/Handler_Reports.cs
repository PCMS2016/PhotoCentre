using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Reports : IHandler_Reports
    {
        IDBAccess_Reports db = null;

        public Handler_Reports()
        {
            db = new DBAccess_Reports();
        }

        public DataTable GetAllProducts(DateTime start, DateTime end)
        {
            return db.GetAllProducts(start, end);
        }

        public DataTable GetAllProductsRefunds(DateTime start, DateTime end)
        {
            return db.GetAllProductsRefunds(start, end);
        }
    }
}
