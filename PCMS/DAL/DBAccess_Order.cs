﻿using System;
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
        //<=== Add New Order ===
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
        //===>

        //<=== Get All Orders ===
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
        //===>
    }
}
