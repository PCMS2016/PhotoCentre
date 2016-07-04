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
        //Add New Order...
        public bool AddOrder(Order order)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentID", Convert.ToInt32(order.Payment)),
                new SqlParameter("@SalespersonID", Convert.ToInt32(order.Salesperson)),
                new SqlParameter("@Date", order.Date),
                new SqlParameter("@Time", order.Time),
                new SqlParameter("@Completed", order.Completed),
                new SqlParameter("@Collected", order.Collected),
                new SqlParameter("@CustomerID", Convert.ToInt32(order.Customer)),
                new SqlParameter("@OrderTotal", order.Total)
            };
            return DBHelper.ExecuteNonQuery("sp_AddOrder", CommandType.StoredProcedure, parameters);
        }

        //Get All Orders...
        public List<Order> GetAllOrders()
        {
            List<Order> list = new List<Order>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllOrders", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Order order = new Order();
                        order.OrderNumber = Convert.ToInt32(row["Order#"].ToString());
                        order.Payment = row["Payment"].ToString();
                        order.Salesperson = row["Salesperson"].ToString();
                        order.Date = Convert.ToDateTime(row["Date"].ToString());
                        order.Time = Convert.ToDateTime(row["Time"].ToString());
                        order.Completed = Convert.ToBoolean(row["Completed"].ToString());
                        order.Collected = Convert.ToBoolean(row["Collected"].ToString());
                        order.Customer = row["Customer"].ToString();
                        order.Total = Convert.ToDouble(row["Total"].ToString());
                        list.Add(order);
                    }
                }
            }
            return list;
        }
        
        //Update Order...
        public bool UpdateOrder(Order order)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", order.OrderNumber),
                new SqlParameter("@PaymentID", order.Payment),
                new SqlParameter("@SalespersonID", order.Salesperson),
                new SqlParameter("@Date", order.Date),
                new SqlParameter("@Time", order.Time),
                new SqlParameter("@Completed", order.Completed),
                new SqlParameter("@Collected", order.Collected),
                new SqlParameter("@Customer", order.Customer),
                new SqlParameter("@OrderTotal", order.Total)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateOrder", CommandType.StoredProcedure, parameters);
        }

        //Remove Order...
        public bool RemoveOrder(int OrderNumber)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("OrderID", OrderNumber)
            };
            return DBHelper.ExecuteNonQuery("sp_RemoveOrder", CommandType.StoredProcedure, parameters);
        }

        //Get Order Number...
        public int GetOrderNumber()
        {
            int orderNumber = 0;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllOrders", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    /*===http://stackoverflow.com/questions/18528736/how-to-retrieve-values-from-the-last-row-in-a-datatable ===*/
                    
                    DataRow row = table.Rows[table.Rows.Count - 1];
                    orderNumber = Convert.ToInt32(row["Order#"].ToString());
                }
            }
            return orderNumber;
        }

        //Get order by order num
        public List<Order> GetOrderByNum(int OrderNumber)
        {
            List<Order> list = new List<Order>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", OrderNumber)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchOrdersByNumber", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Order order = new Order();
                        order.OrderNumber = Convert.ToInt32(row["Order#"].ToString());
                        order.Payment = row["Payment"].ToString();
                        order.Salesperson = row["Salesperson"].ToString();
                        order.Date = Convert.ToDateTime(row["Date"].ToString());
                        order.Time = Convert.ToDateTime(row["Time"].ToString());
                        order.Completed = Convert.ToBoolean(row["Completed"].ToString());
                        order.Collected = Convert.ToBoolean(row["Collected"].ToString());
                        order.Customer = row["Customer"].ToString();
                        order.Total = Convert.ToDouble(row["Total"].ToString());
                        list.Add(order);
                    }
                }
            }
            return list;
        }

        //Get order by customer name/surname
        public List<Order> getParaCustList(string firstName, string lastName)
        {
            List<Order> list =null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", firstName),
                new SqlParameter("@Surname", lastName)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchOrdersByCustomer", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    list = new List<Order>();

                    foreach (DataRow row in table.Rows)
                    {
                        Order order = new Order();
                        order.OrderNumber = Convert.ToInt32(row["Order#"].ToString());
                        order.Payment = row["Payment"].ToString();
                        order.Salesperson = row["Salesperson"].ToString();
                        order.Date = Convert.ToDateTime(row["Date"].ToString());
                        order.Time = Convert.ToDateTime(row["Time"].ToString());
                        order.Completed = Convert.ToBoolean(row["Completed"].ToString());
                        order.Collected = Convert.ToBoolean(row["Collected"].ToString());
                        order.Customer = row["Customer"].ToString();
                        order.Total = Convert.ToDouble(row["Total"].ToString());
                        list.Add(order);
                    }
                }
            }
            return list;
        }

        //Get order by order date
        public List<Order> getOrderDateList(DateTime date)
        {
            List<Order> list = new List<Order>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Date", date)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchOrdersByDate", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Order order = new Order();
                        order.OrderNumber = Convert.ToInt32(row["Order#"].ToString());
                        order.Payment = row["Payment"].ToString();
                        order.Salesperson = row["Salesperson"].ToString();
                        order.Date = Convert.ToDateTime(row["Date"].ToString());
                        order.Time = Convert.ToDateTime(row["Time"].ToString());
                        order.Completed = Convert.ToBoolean(row["Completed"].ToString());
                        order.Collected = Convert.ToBoolean(row["Collected"].ToString());
                        order.Customer = row["Customer"].ToString();
                        order.Total = Convert.ToDouble(row["Total"].ToString());
                        list.Add(order);
                    }
                }
            }

            return list;
        }
    }
}
