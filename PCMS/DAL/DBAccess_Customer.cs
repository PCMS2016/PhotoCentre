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

        //Add Customer...
        public bool AddCustomer(Customer customer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Surname", customer.Surname),
                new SqlParameter("@Cellphone", customer.Cellphone),
                new SqlParameter("@Email", customer.Email),
                new SqlParameter("@NotificationType", customer.NotificationType),
                new SqlParameter("@CustomerType", customer.CustomerType),
                new SqlParameter("@DiscountID", Convert.ToInt32(customer.Discount))
            };
            return DBHelper.ExecuteNonQuery("sp_AddCustomer", CommandType.StoredProcedure, parameters);
        }

        //Update Customer...
        public bool UpdateCustomer(Customer customer)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customer.CustomerID),
                new SqlParameter("@Name",customer.Name),
                new SqlParameter("@Surname", customer.Surname),
                new SqlParameter("@Cellphone", customer.Cellphone),
                new SqlParameter("@Email", customer.Email),
                new SqlParameter("@NotificationType", customer.NotificationType),
                new SqlParameter("@CustomerType", customer.CustomerType),
                new SqlParameter("@DiscountID", Convert.ToInt32(customer.Discount))
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateCustomer", CommandType.StoredProcedure, parameters);
        }

        //Get Customer Email Address
        public string GetEmailAddress(int orderNumber)
        {
            string email = "";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@orderNumber", orderNumber)
            };
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetEmailAddress", CommandType.StoredProcedure, parameters)) 
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        email = row["Email"].ToString();
                    }
                }
                return email;
            }
        }
    }
}
