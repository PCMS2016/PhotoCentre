using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Payment : IDBAccess_Payment 
    {
        public List<Payment> GetAllPayments()
        {
            List<Payment> list = new List<Payment>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetPayments", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Payment payment = new Payment();
                        payment.PaymentID = Convert.ToInt32(row["PaymentID"].ToString());
                        payment.PaymentType = row["Payment Type"].ToString();
                        list.Add(payment);
                    }
                }
            }
            return list;
        }
    }
}
