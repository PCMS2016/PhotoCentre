﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Refund : IDBAccess_Refund
    {

        public Order getOrderByNum(int OrderNum)
        {
            Order order = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", OrderNum)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchOrdersByNumber", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    order = new Order();

                    foreach (DataRow row in table.Rows)
                    {


                        order.OrderNumber = Convert.ToInt32(row["Order#"].ToString());
                        order.Payment = row["Payment"].ToString();
                        order.Salesperson = row["Salesperson"].ToString();
                        order.Date = Convert.ToDateTime(row["Date"].ToString());
                        order.Time = Convert.ToDateTime(row["Time"].ToString());
                        order.Completed = Convert.ToBoolean(row["Completed"].ToString());
                        order.Collected = Convert.ToBoolean(row["Collected"].ToString());
                        order.Customer = row["Customer"].ToString();
                        order.Total = Convert.ToDouble(row["Total"].ToString());
                    }
                }
            }

            return order;
        }

        public List<OrderLine> GetOrderLines(int orderNumber)
        {
            List<OrderLine> list = new List<OrderLine>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderNumber)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetOrderLines", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        OrderLine orderline = new OrderLine();
                        orderline.OrderLineID = Convert.ToInt32(row["OrderLineID"].ToString());
                        orderline.Product = row["Product"].ToString();
                        orderline.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        orderline.ItemPrice = Convert.ToDouble(row["Item Price"].ToString());
                        orderline.LineTotal = Convert.ToDouble(row["Total"].ToString());
                        orderline.Instructions = row["Instructions"].ToString();

                        list.Add(orderline);
                    }
                }
            }
            return list;
        }
    }
}