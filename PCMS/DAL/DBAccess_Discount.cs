using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Discount : IDBAccess_Discount
    {
        public List<Discount> GetAllDiscount()
        {
            List<Discount> list = new List<Discount>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetDiscount", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Discount discount = new Discount();
                        discount.DiscountID = Convert.ToInt32(row["DiscountID"].ToString());
                        discount.Percentage = Convert.ToDouble(row["Percentage"].ToString());
                        list.Add(discount);
                    }
                }
            }
            return list;
        }
        public bool AddDiscount(Discount discount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Amount", discount.Percentage)
            };
            return DBHelper.ExecuteNonQuery("sp_AddDiscount", CommandType.StoredProcedure, parameters);
        }
        public bool UpdateDiscount(Discount discount)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DiscountID", discount.DiscountID),
                new SqlParameter("@Amount", discount.Percentage)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateDiscount", CommandType.StoredProcedure, parameters);
        }

    }
}
