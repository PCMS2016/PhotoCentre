using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Reports : IDBAccess_Reports    {
        public DataTable GetAllProducts(DateTime start, DateTime end)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", start),
                new SqlParameter("@endDate", end)
            };

            return DBHelper.ExecuteParamerizedSelectCommand("sp_ReportProducts", CommandType.StoredProcedure, parameters);
        }

        public DataTable GetAllProductsRefunds(DateTime start, DateTime end)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", start),
                new SqlParameter("@endDate", end)
            };

            return DBHelper.ExecuteParamerizedSelectCommand("sp_ReportProductsRefunds", CommandType.StoredProcedure, parameters);
        }

        public DataTable GetAllRefund(DateTime start, DateTime end)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", start),
                new SqlParameter("@endDate", end)
            };

            return DBHelper.ExecuteParamerizedSelectCommand("sp_ReportRefunds", CommandType.StoredProcedure, parameters);
        }

        public DataTable GetAllSalesperson(DateTime start, DateTime end)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@startDate", start),
                new SqlParameter("@endDate", end)
            };

            return DBHelper.ExecuteParamerizedSelectCommand("sp_ReportSalespersons", CommandType.StoredProcedure, parameters);
        }
    }
}
