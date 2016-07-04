using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_OrderLine : IDBAccess_OrderLines 
    {
        //Get order lines for a specific orders...
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
                        orderline.ItemPrice = Convert.ToDouble((row["Item Price"].ToString()));
                        orderline.LineTotal = Convert.ToDouble(row["Total"].ToString());
                        orderline.Instructions = row["Instructions"].ToString();
                        list.Add(orderline);
                    }
                }
            }
            return list;
        }

        //Add Order Line...
        public bool AddOrderLine(OrderLine orderLine)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SizeMediumID", Convert.ToInt32(orderLine.Product)),
                new SqlParameter("@OrderID", orderLine.OrderNumber),
                new SqlParameter("@Quantity", orderLine.Quantity),
                new SqlParameter("@ItemPrice", orderLine.ItemPrice),
                new SqlParameter("@LineTotal", orderLine.LineTotal),
                new SqlParameter("@Instructions", orderLine.Instructions)
            };
            return DBHelper.ExecuteNonQuery("sp_AddOrderLine", CommandType.StoredProcedure, parameters);
        }

        //Update Order Line...
        public bool UpdateOrderLine(OrderLine orderLine)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderLineID", orderLine.OrderLineID),
                new SqlParameter("@SizeMediumID", orderLine.Product),
                new SqlParameter("@OrderID", orderLine.OrderNumber),
                new SqlParameter("@Quantity", orderLine.Quantity),
                new SqlParameter("@ItemPrice", orderLine.ItemPrice),
                new SqlParameter("@LineTotal", orderLine.LineTotal),
                new SqlParameter("@Instructions", orderLine.Instructions)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateOrderLine", CommandType.StoredProcedure, parameters);
        }

        //Remove Order Line...
        public bool RemoveOrderLine(int OrderLineID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderLineID", OrderLineID)
            };
            return DBHelper.ExecuteNonQuery("sp_RemoveOrderLine", CommandType.StoredProcedure, parameters);
        }
    }
}
