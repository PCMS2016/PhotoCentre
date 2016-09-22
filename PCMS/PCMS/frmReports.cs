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
        public frmReports()
        {
            InitializeComponent();
        }


        private void frmReports_Load(object sender, EventArgs e)
        {
            handlerReports = new Handler_Reports();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateProductsData(dtpStart.Value, dtpEnd.Value);
            
            this.rpvProducts.RefreshReport();
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
                int pQuantity = Convert.ToInt32(pRows[1].ToString());
                double pTotal = Convert.ToDouble(pRows[2].ToString());
                int rQuantity = 0;
                double rTotal = 0;

                foreach (DataRow rRows in refunds.Rows)
                {
                    if (rRows[0].ToString() == product)
                    {
                        rQuantity = Convert.ToInt32(rRows[1].ToString());
                        rTotal = Convert.ToDouble(rRows[2].ToString());
                    }
                }

                temp.Rows.Add(product, pQuantity, pTotal, rQuantity, rTotal);
            }

            products ds = new PCMS.products();
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

            ReportDataSource rds = new ReportDataSource("products", ds.Tables["ProductsTable"]);
            rpvProducts.LocalReport.DataSources.Clear();
            rpvProducts.LocalReport.DataSources.Add(rds);
            rpvProducts.LocalReport.Refresh();
        }
    }
}
