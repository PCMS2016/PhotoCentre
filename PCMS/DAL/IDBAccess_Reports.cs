using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public interface IDBAccess_Reports
    {
        DataTable GetAllProducts(DateTime start, DateTime end);

        DataTable GetAllProductsRefunds(DateTime start, DateTime end);

        DataTable GetAllSalesperson(DateTime start, DateTime end);

        DataTable GetAllRefund(DateTime start, DateTime end);
    }
}
