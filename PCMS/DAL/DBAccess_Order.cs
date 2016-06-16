using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Order : IDBAccess_Order 
    {
        public bool AddOrder(Order order)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentID", order.Payment),
                new SqlParameter("@SalespersonID", order.Salesperson),
                new SqlParameter("@Date", order.Date),
                new SqlParameter("@Time", order.Time),
                new SqlParameter("@Completed", order.Completed),
                new SqlParameter("@Collected", order.Collected),
                new SqlParameter("@CustomerID", order.Customer),
                new SqlParameter("@OrderTotal", order.Total)
            };
            return DBHelper.ExecuteNonQuery("sp_AddOrder", CommandType.StoredProcedure, parameters);
        }
    }
}
