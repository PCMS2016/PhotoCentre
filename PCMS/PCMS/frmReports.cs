using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using BLL;
using DAL;

namespace PCMS
{
    public partial class frmReports : MetroForm 
    {
        IHandler_Reports handlerReports;
        IHandler_Product handlerProducts;
        dsReports ds = new dsReports();
        public frmReports()
        {
            InitializeComponent();
        }


        private void frmReports_Load(object sender, EventArgs e)
        {
            handlerReports = new Handler_Reports();
            handlerProducts = new Handler_Product();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearDataSet();

            GenerateProductsData(dtpStart.Value, dtpEnd.Value);

            GenerateSalespersonData(dtpStart.Value, dtpEnd.Value);

            GenerateRefundData(dtpStart.Value, dtpEnd.Value);

            GenerateTrendsData(dtpStart.Value, dtpEnd.Value);
            
            this.rpvProducts.RefreshReport();

            this.rpvSalespersons.RefreshReport();

            this.rpvRefunds.RefreshReport();

            this.rpvTrends.RefreshReport();
        }

        private void ClearDataSet()
        {
            ds.Tables["ProductsTable"].Rows.Clear();
            ds.Tables["SalespersonsTable"].Rows.Clear();
            ds.Tables["RefundsTable"].Rows.Clear();
            ds.Tables["SalesTrends"].Rows.Clear();
        }

        private void GenerateProductsData(DateTime start, DateTime end)
        {
            DataTable products = handlerReports.GetAllProducts(start, end);
            DataTable refunds = handlerReports.GetAllProductsRefunds(start, end);


            DataTable temp = new DataTable();
            temp.Columns.Add("Product");
            temp.Columns.Add("QuantitySold");
            temp.Columns.Add("TotalSold");
            temp.Columns.Add("QuantityRefunded");
            temp.Columns.Add("TotalRefunded");

            foreach (DataRow pRows in products.Rows)
            {
                string product = pRows[0].ToString();
                int pQuantity = Convert.ToInt32(pRows[2].ToString());
                double pTotal = Convert.ToDouble(pRows[3].ToString());
                int rQuantity = 0;
                double rTotal = 0;

                foreach (DataRow rRows in refunds.Rows)
                {
                    if (rRows[0].ToString() == product)
                    {
                        rQuantity = Convert.ToInt32(rRows[2].ToString());
                        rTotal = Convert.ToDouble(rRows[3].ToString());
                    }
                }

                temp.Rows.Add(product, pQuantity, pTotal, rQuantity, rTotal);
            }

            
            foreach (DataRow row in temp.Rows)
            {
                DataRow dr = ds.Tables["ProductsTable"].NewRow();
                dr["Product"] = row["Product"].ToString();
                dr["SoldQuantity"] = row["QuantitySold"].ToString();
                dr["SoldTotal"] = Convert.ToDouble(row["TotalSold"].ToString());
                dr["RefundQuantity"] = row["QuantityRefunded"].ToString();
                dr["RefundTotal"] = row["TotalRefunded"].ToString();

                ds.Tables["ProductsTable"].Rows.Add(dr);
            }

            ReportDataSource rds = new ReportDataSource("dsReports", ds.Tables["ProductsTable"]);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("start", start.ToShortDateString());
            parameters[1] = new ReportParameter("end", end.ToShortDateString());
            rpvProducts.LocalReport.SetParameters(parameters);
            rpvProducts.LocalReport.DataSources.Clear();
            rpvProducts.LocalReport.DataSources.Add(rds);
            rpvProducts.LocalReport.Refresh();
        }

        private void GenerateSalespersonData(DateTime start, DateTime end)
        {
            foreach (DataRow row in handlerReports.GetAllSalesperson(start, end).Rows)
            {
                DataRow dr = ds.Tables["SalespersonsTable"].NewRow();
                dr["Salesperson"] = row["Salesperson"].ToString();
                dr["Date"] = Convert.ToDateTime(row["Date"].ToString()).ToShortDateString();
                dr["Sales"] = Convert.ToInt32(row["Sales"].ToString());
                dr["Total"] = Convert.ToDouble(row["SalesTotal"].ToString());

                ds.Tables["SalespersonsTable"].Rows.Add(dr);
            }

            ReportDataSource rds = new ReportDataSource("dsReports", ds.Tables["SalespersonsTable"]);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("start", start.ToShortDateString());
            parameters[1] = new ReportParameter("end", end.ToShortDateString());
            rpvSalespersons.LocalReport.SetParameters(parameters);
            rpvSalespersons.LocalReport.DataSources.Clear();
            rpvSalespersons.LocalReport.DataSources.Add(rds);
            rpvSalespersons.LocalReport.Refresh();
        }

        private void GenerateRefundData(DateTime start, DateTime end)
        {
            foreach (DataRow row in handlerReports.GetAllRefund(start, end).Rows)
            {
                DataRow dr = ds.Tables["RefundsTable"].NewRow();
                dr["Date"] = Convert.ToDateTime(row["Date"].ToString()).ToShortDateString();
                dr["Salesperson"] = row["Salesperson"].ToString();
                dr["OrderID"] = row["OrderID"].ToString();
                dr["Quantity"] = Convert.ToInt32(row["Quantity"].ToString());
                dr["Total"] = Convert.ToDouble(row["LineTotal"].ToString());
                dr["Reason"] = row["Reason"].ToString();

                ds.Tables["RefundsTable"].Rows.Add(dr);
            }

            ReportDataSource rds = new ReportDataSource("dsReports", ds.Tables["RefundsTable"]);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("start", start.ToShortDateString());
            parameters[1] = new ReportParameter("end", end.ToShortDateString());
            rpvRefunds.LocalReport.SetParameters(parameters);
            rpvRefunds.LocalReport.DataSources.Clear();
            rpvRefunds.LocalReport.DataSources.Add(rds);
            rpvRefunds.LocalReport.Refresh();
        }

        private void GenerateTrendsData(DateTime start, DateTime end)
        {
            DataTable sales = handlerReports.GetAllProducts(start, end);
            DataTable refunds = handlerReports.GetAllProductsRefunds(start, end);
            List<SizeMedium> products = handlerProducts.GetAllProducts();

            DataTable temp = new DataTable();
            temp.Columns.Add("Date");
            temp.Columns.Add("Product");
            temp.Columns.Add("Sold");
            temp.Columns.Add("Refunded");
            temp.Columns.Add("SoldTotal");
            temp.Columns.Add("RefundedTotal");

            for (DateTime x = start.Date; x.Date <= end; x = x.AddDays(1))
            {
                foreach (var item in products)
                {
                    DateTime date = x;
                    int index = item.Product.LastIndexOf('R');
                    string product = item.Product.Substring(0, index - 3);
                    int sold = 0;
                    double soldTotal = 0;
                    int refunded = 0;
                    double refundedTotal = 0;

                    //Add Trend for Sold
                    foreach(DataRow pRow in sales.Rows)
                    {
                        if ((Convert.ToDateTime(pRow["Date"].ToString()) == date) && (pRow["Product"].ToString() == product))
                        {
                            sold = Convert.ToInt32(pRow[2].ToString());
                            soldTotal = Convert.ToDouble(pRow[3].ToString());
                        }
                    }

                    //Add Trend for Refund
                    foreach(DataRow rRow in refunds.Rows)
                    {
                        if ((Convert.ToDateTime(rRow["Date"].ToString()) == date) && (rRow["Product"].ToString() == product))
                        {
                            refunded = Convert.ToInt32(rRow[2].ToString());
                            refundedTotal = Convert.ToDouble(rRow[3].ToString());
                        }
                    }

                    temp.Rows.Add(date, product, sold, refunded, soldTotal, refundedTotal);
                }
            }

            foreach (DataRow row in temp.Rows)
            {
                DataRow dr = ds.Tables["SalesTrends"].NewRow();
                dr["Date"] = Convert.ToDateTime(row["Date"].ToString()).ToShortDateString();
                dr["Product"] = row["Product"].ToString();
                dr["Sold"] = Convert.ToInt32(row["Sold"].ToString());
                dr["Refunded"] = Convert.ToInt32(row["Refunded"].ToString());
                dr["SoldTotal"] = Convert.ToDouble(row["SoldTotal"].ToString());
                dr["RefundedTotal"] = Convert.ToDouble(row["RefundedTotal"].ToString());

                ds.Tables["SalesTrends"].Rows.Add(dr);
            }

            ReportDataSource rds = new ReportDataSource("dsReports", ds.Tables["SalesTrends"]);
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("start", start.ToShortDateString());
            parameters[1] = new ReportParameter("end", end.ToShortDateString());
            rpvTrends.LocalReport.SetParameters(parameters);
            rpvTrends.LocalReport.DataSources.Clear();
            rpvTrends.LocalReport.DataSources.Add(rds);
            rpvTrends.LocalReport.Refresh();
        }
    }
}
