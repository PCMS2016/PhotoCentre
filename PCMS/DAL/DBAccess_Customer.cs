using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Customer : IDBAccess_Customer 
    {
        //Search for customer via Name Surname...
        public List<Customer> SearchCustomer(string Name, string Surname)
        {
            List<Customer> list = new List<Customer>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@Surname", Surname)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchCustomers", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = Convert.ToInt32(row["CustomerID"].ToString());
                        customer.Name = row["Name"].ToString();
                        customer.Surname = row["Surname"].ToString();
                        customer.Cellphone = row["Cellphone"].ToString();
                        customer.Email = row["Email"].ToString();
                        customer.NotificationType = row[5].ToString();
                        customer.CustomerType = row["Customer Type"].ToString();
                        customer.Discount = Convert.ToDouble(row["Percentage"].ToString());
                        list.Add(customer);
                    }
                }
            }
            return list;
        }
    }
}
