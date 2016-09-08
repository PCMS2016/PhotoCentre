using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Reports : IDBAccess_Reports
    {

        public List<Reports> GetDayRefund(DateTime day)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@date", day)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportRefund", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.RefundID = Convert.ToInt32(row["RefundProductID"].ToString());
                        report.Date = Convert.ToDateTime(row["Date"].ToString());
                        report.OrderNo = Convert.ToInt32(row["OrderID"].ToString());
                        report.SalesPerson = row["Salesperson"].ToString();
                        report.Product = row["Product"].ToString();
                        report.Reason = row["Reason"].ToString();

                        list.Add(report);
                    }
                }
            }
            return list;

        }

        public List<Reports> GetDaySales(DateTime day)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@date", day)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportSales", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.SalesPerson = row["Salesperson"].ToString();
                        report.Product = row["Product"].ToString();
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;

        }

        public List<Reports> GetDayProduct(DateTime day)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@date", day)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportProducts", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.Product = row["Product"].ToString();
                        report.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;
        }

        public List<Reports> GetMonthRefund(int month, int year)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dateMonth", month),
                new SqlParameter("@dateYear", year)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportRefundMonth", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.RefundID = Convert.ToInt32(row["RefundProductID"].ToString());
                        report.Date = Convert.ToDateTime(row["Date"].ToString());
                        report.OrderNo = Convert.ToInt32(row["OrderID"].ToString());
                        report.SalesPerson = row["Salesperson"].ToString();
                        report.Product = row["Product"].ToString();
                        report.Reason = row["Reason"].ToString();

                        list.Add(report);                        
                    }
                }
            }
            return list;
        }

        public List<Reports> GetMonthSales(int month, int year)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dateMonth", month),
                new SqlParameter("@dateYear", year)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportSalesMonth", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.SalesPerson = row["Salesperson"].ToString();
                        report.Product = row["Product"].ToString();
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;
        }

        public List<Reports> GetMonthProduct(int month, int year)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dateMonth", month),
                new SqlParameter("@dateYear", year)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportSalesMonth", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.Product = row["Product"].ToString();
                        report.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;
        }

        public List<Reports> GetYearSales(int year)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dateYear", year)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportSalesYear", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.SalesPerson = row["Salesperson"].ToString();
                        report.Product = row["Product"].ToString();
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;
        }

        public List<Reports> GetYearProduct(int year)
        {
            List<Reports> list = new List<Reports>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@dateYear", year)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_ReportProductsYear", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Reports report = new Reports();
                        report.Product = row["Product"].ToString();
                        report.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        report.Total = Convert.ToDouble(row["Total"].ToString());

                        list.Add(report);
                    }
                }
            }
            return list;
        }
    }
}
