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

        public SizeMedium GetProdByName(string prodName)
        {
            SizeMedium SM = null;
            
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSizeMedium", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    SM = new SizeMedium();

                    foreach (DataRow row in table.Rows)
                    {
                        if (row["Product"].ToString() == prodName)
                            SM.SizeMediumID = Convert.ToInt32(row["SizeMediumID"].ToString());
                    }
                }
            }

            return SM;
        }
        public bool AddRefund(Refund rfnd)
        {
            string date = DateTime.Today.ToString();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", Convert.ToInt32(rfnd.OrderNumber)),
                new SqlParameter("@SalespersonID", Convert.ToInt32(rfnd.SalespersonID)),
                new SqlParameter("@Date", Convert.ToDateTime(date)),
                new SqlParameter("@RefundTotal", Convert.ToDouble(rfnd.Total))
            };
            return DBHelper.ExecuteNonQuery("sp_AddRefund", CommandType.StoredProcedure, parameters);
        }

        public int GetSalesPersonID(string salesPFName, string salesPLName)
        {
            int salesID = 0;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", salesPFName),
                new SqlParameter("@Surname", salesPLName)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchSalesperson", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {

                    foreach (DataRow row in table.Rows)
                    {
                        Salesperson SP = new Salesperson();
                        SP.SalespersonID = Convert.ToInt32(row["SalespersonID"].ToString());
                        salesID = SP.SalespersonID;
                    }
                }
            }
            
            return salesID;
        }

        public int GetRefundID(int orderNumber)
        {
            int refundID = 0;
           

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllRefunds", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {

                    foreach (DataRow row in table.Rows)
                    {
                        Refund RF = new Refund();
                        RF.RefundID = Convert.ToInt32(row["RefundID"].ToString());
                        refundID = RF.RefundID;
                    }
                }
            }

            return refundID;
        }

        public int GetOrderLineID(int orderNumber)
        {
            int orderLineID = 0;

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
                        OrderLine OL = new OrderLine();
                        OL.OrderLineID = Convert.ToInt32(row["OrderLineID"].ToString());
                        orderLineID = OL.OrderLineID;
                    }
                }
            }

            return orderLineID;
        }

        public bool AddRefundProduct(RefundProduct refProd)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RefundID", Convert.ToInt32(refProd.RefundID)),
                new SqlParameter("@OrderLineID", Convert.ToInt32(refProd.OrderLineID)),
                new SqlParameter("@Reason", refProd.Reason.ToString()),
                new SqlParameter("@Quantity", Convert.ToInt32(refProd.Quantity)),
                new SqlParameter("@Price", Convert.ToDouble(refProd.Price)),
                new SqlParameter("@LineTotal", Convert.ToDouble(refProd.LineTotal))
            };
            return DBHelper.ExecuteNonQuery("sp_AddRefundProduct", CommandType.StoredProcedure, parameters);
        }

        public List<DisplayRefund> DisplayRefund()
        {
            List<DisplayRefund> list = new List<DisplayRefund>();
            

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_DisplayRefunds", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        DisplayRefund dRefund = new DisplayRefund();
                        dRefund.RefundID = Convert.ToInt32(row["RefundID"].ToString());
                        dRefund.Product = row["Product"].ToString();
                        dRefund.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        dRefund.Price = Convert.ToDouble(row["Price"].ToString());
                        dRefund.Reason = row["Reason"].ToString();
                        dRefund.Date = Convert.ToDateTime(row["Date"].ToString());
                        list.Add(dRefund);
                    }
                }
            }
            return list;
        }

        

        public bool VoidRefund(int refundID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RefundID", refundID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateRefund", CommandType.StoredProcedure, parameters);
        }

        public bool VoidRefundProduct(int refundProdID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RefundProductID", refundProdID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateRefundProduct", CommandType.StoredProcedure, parameters);
        }

      
    }
}
