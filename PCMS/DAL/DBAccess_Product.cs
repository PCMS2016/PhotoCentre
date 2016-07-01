using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Product : IDBAccess_Product 
    {
        //Get all products...
        public List<SizeMedium> GetAllProducts()
        {
            List<SizeMedium> list = new List<SizeMedium>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSizeMedium", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        SizeMedium product = new SizeMedium();
                        product.SizeMediumID = Convert.ToInt32(row["SizeMediumID"].ToString());
                        product.Product = row["Product"].ToString() + " - " + (string.Format("{0:C}", Convert.ToDouble(row["Price"].ToString())));
                        list.Add(product);
                    }
                }
            }
            return list;
        }
    }
}
