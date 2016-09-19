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
using BLL;
using DAL;

namespace PCMS
{
    public partial class frmReports : MetroForm 
    {
        private IHandler_Reports handlerReport = null;
        private Reports[] rep;

        public frmReports()
        {
            InitializeComponent();
            handlerReport = new Handler_Reports();
            rep = new Reports[100];
        }

        private void metroGrid6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReports_Load(object sender, EventArgs e)
        {


        }

        private void dtpReportDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime day;
            List<Reports> R;
            List<Reports> S;
            List<Reports> P;

            if (DateTime.TryParse(dtpReportDay.Text, out day))
            {
                R = handlerReport.GetDayRefund(day);

                if (R != null)
                {
                    dgvReportRefundDay.Columns.Clear();
                    dgvReportRefundDay.DataSource = R;
                    dgvReportRefundDay.Columns[0].HeaderText = "ID";
                    dgvReportRefundDay.Columns[1].HeaderText = "Date";
                    dgvReportRefundDay.Columns[2].HeaderText = "Order#";
                    dgvReportRefundDay.Columns[3].HeaderText = "Salesperson";
                    dgvReportRefundDay.Columns[4].HeaderText = "Product";
                    dgvReportRefundDay.Columns[5].HeaderText = "Reason";
                    dgvReportRefundDay.Columns.RemoveAt(7);
                    dgvReportRefundDay.Columns.RemoveAt(6);
                }
                else
                {
                    MessageBox.Show("not found");
                }

                S = handlerReport.GetDaySales(day);

                if(S != null)
                {
                    dgvReportSalesDay.Columns.Clear();
                    dgvReportSalesDay.DataSource = S;
                    dgvReportSalesDay.Columns[3].HeaderText = "Salesperson";
                    dgvReportSalesDay.Columns[4].HeaderText = "Products";
                    dgvReportSalesDay.Columns[7].HeaderText = "Total";
                    dgvReportSalesDay.Columns.RemoveAt(6);
                    dgvReportSalesDay.Columns.RemoveAt(5);
                    dgvReportSalesDay.Columns.RemoveAt(2);
                    dgvReportSalesDay.Columns.RemoveAt(1);
                    dgvReportSalesDay.Columns.RemoveAt(0);                    
                }

                P = handlerReport.GetDayProduct(day);
                
                if (P != null)
                {
                    dgvReportProductDay.Columns.Clear();
                    dgvReportProductDay.DataSource = P;

                    dgvReportProductDay.Columns[4].HeaderText = "Product";
                    dgvReportProductDay.Columns[6].HeaderText = "Quantity";
                    dgvReportProductDay.Columns[7].HeaderText = "Total";                    
                    dgvReportProductDay.Columns.RemoveAt(5);
                    dgvReportProductDay.Columns.RemoveAt(3);
                    dgvReportProductDay.Columns.RemoveAt(2);
                    dgvReportProductDay.Columns.RemoveAt(1);
                    dgvReportProductDay.Columns.RemoveAt(0);
                }
            }
        }
        

        private void dtpMonthReportMonth_ValueChanged(object sender, EventArgs e)
        {
            int month;
            int year;
            List<Reports> R;
            List<Reports> S;
            List<Reports> P;
            if (int.TryParse(dtpMonthReportMonth.Value.Month.ToString(), out month))
            {
                if (int.TryParse(dtpYearReportYear.Value.Year.ToString(), out year))
                {

                    R = handlerReport.GetMonthRefund(month, year);

                    if (R != null)
                    {
                        dgvReportRefunds.Columns.Clear();
                        dgvReportRefunds.DataSource = R;
                        dgvReportRefunds.Columns[0].HeaderText = "ID";
                        dgvReportRefunds.Columns[1].HeaderText = "Date";
                        dgvReportRefunds.Columns[2].HeaderText = "Order#";
                        dgvReportRefunds.Columns[3].HeaderText = "Salesperson";
                        dgvReportRefunds.Columns[4].HeaderText = "Product";
                        dgvReportRefunds.Columns[5].HeaderText = "Reason";
                        dgvReportRefunds.Columns.RemoveAt(7);
                        dgvReportRefunds.Columns.RemoveAt(6);
                    }
                    else
                    {
                        MessageBox.Show("not found");
                    }

                    S = handlerReport.GetMonthSales(month, year);

                    if (S != null)
                    {
                        dgvReportSales.Columns.Clear();
                        dgvReportSales.DataSource = S;
                        dgvReportSales.Columns[3].HeaderText = "Salesperson";
                        dgvReportSales.Columns[4].HeaderText = "Products";
                        dgvReportSales.Columns[7].HeaderText = "Total";
                        dgvReportSales.Columns.RemoveAt(6);
                        dgvReportSales.Columns.RemoveAt(5);
                        dgvReportSales.Columns.RemoveAt(2);
                        dgvReportSales.Columns.RemoveAt(1);
                        dgvReportSales.Columns.RemoveAt(0);
                    }

                    P = handlerReport.GetMonthProduct(month, year);

                    if (P != null)
                    {
                        dgvReportProducts.Columns.Clear();
                        dgvReportProducts.DataSource = P;
                        dgvReportProducts.Columns[4].HeaderText = "Product";
                        dgvReportProducts.Columns[6].HeaderText = "Quantity";
                        dgvReportProducts.Columns[7].HeaderText = "Total";
                        dgvReportProducts.Columns.RemoveAt(5);
                        dgvReportProducts.Columns.RemoveAt(3);
                        dgvReportProducts.Columns.RemoveAt(2);
                        dgvReportProducts.Columns.RemoveAt(1);
                        dgvReportProducts.Columns.RemoveAt(0);
                    }
                }
            }
        }

        private void dtpYearReportYear_ValueChanged(object sender, EventArgs e)
        {
            int month;
            int year;
            List<Reports> R;
            List<Reports> S;
            List<Reports> P;
            if (int.TryParse(dtpYearReportYear.Value.Year.ToString(), out year))
            {
                if (int.TryParse(dtpMonthReportMonth.Value.Month.ToString(), out month))
                {

                    R = handlerReport.GetMonthRefund(month, year);

                    if (R != null)
                    {
                        dgvReportRefunds.Columns.Clear();
                        dgvReportRefunds.DataSource = R;
                        dgvReportRefunds.Columns[0].HeaderText = "ID";
                        dgvReportRefunds.Columns[1].HeaderText = "Date";
                        dgvReportRefunds.Columns[2].HeaderText = "Order#";
                        dgvReportRefunds.Columns[3].HeaderText = "Salesperson";
                        dgvReportRefunds.Columns[4].HeaderText = "Product";
                        dgvReportRefunds.Columns[5].HeaderText = "Reason";
                        dgvReportRefunds.Columns.RemoveAt(7);
                        dgvReportRefunds.Columns.RemoveAt(6);
                    }
                    else
                    {
                        MessageBox.Show("not found");
                    }

                    S = handlerReport.GetMonthSales(month, year);

                    if (S != null)
                    {
                        dgvReportSales.Columns.Clear();
                        dgvReportSales.DataSource = S;
                        dgvReportSales.Columns[3].HeaderText = "Salesperson";
                        dgvReportSales.Columns[4].HeaderText = "Products";
                        dgvReportSales.Columns[7].HeaderText = "Total";
                        dgvReportSales.Columns.RemoveAt(6);
                        dgvReportSales.Columns.RemoveAt(5);
                        dgvReportSales.Columns.RemoveAt(2);
                        dgvReportSales.Columns.RemoveAt(1);
                        dgvReportSales.Columns.RemoveAt(0);
                    }

                    P = handlerReport.GetMonthProduct(month, year);

                    if (P != null)
                    {
                        dgvReportProducts.Columns.Clear();
                        dgvReportProducts.DataSource = P;
                        dgvReportProducts.Columns[4].HeaderText = "Product";
                        dgvReportProducts.Columns[6].HeaderText = "Quantity";
                        dgvReportProducts.Columns[7].HeaderText = "Total";
                        dgvReportProducts.Columns.RemoveAt(5);
                        dgvReportProducts.Columns.RemoveAt(3);
                        dgvReportProducts.Columns.RemoveAt(2);
                        dgvReportProducts.Columns.RemoveAt(1);
                        dgvReportProducts.Columns.RemoveAt(0);
                    }
                }
            }
        }

        private void dtpReportYear_ValueChanged(object sender, EventArgs e)
        {
            int year;
            List<Reports> S;
            List<Reports> P;

            if (int.TryParse(dtpReportYear.Value.Year.ToString(), out year))
            {
                S = handlerReport.GetYearSales(year);

                if (S != null)
                {
                    dgvReportSalesYear.Columns.Clear();
                    dgvReportSalesYear.DataSource = S;
                    dgvReportSalesYear.Columns[3].HeaderText = "Salesperson";
                    dgvReportSalesYear.Columns[4].HeaderText = "Products";
                    dgvReportSalesYear.Columns[7].HeaderText = "Total";
                    dgvReportSalesYear.Columns.RemoveAt(6);
                    dgvReportSalesYear.Columns.RemoveAt(5);
                    dgvReportSalesYear.Columns.RemoveAt(2);
                    dgvReportSalesYear.Columns.RemoveAt(1);
                    dgvReportSalesYear.Columns.RemoveAt(0);
                }
                else
                {
                    MessageBox.Show("not found");
                }

                P = handlerReport.GetYearProduct(year);

                if (P != null)
                {
                    dgvReportProductYear.Columns.Clear();
                    dgvReportProductYear.DataSource = P;
                    dgvReportProductYear.Columns[4].HeaderText = "Product";
                    dgvReportProductYear.Columns[6].HeaderText = "Quantity";
                    dgvReportProductYear.Columns[7].HeaderText = "Total";
                    dgvReportProductYear.Columns.RemoveAt(5);
                    dgvReportProductYear.Columns.RemoveAt(3);
                    dgvReportProductYear.Columns.RemoveAt(2);
                    dgvReportProductYear.Columns.RemoveAt(1);
                    dgvReportProductYear.Columns.RemoveAt(0);
                }

            }
        }

        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            SaveToExcel se = new SaveToExcel();
            se.ExportToExcel(dgvReportSalesYear);            
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            SaveToExcel se = new SaveToExcel();
            se.ExportToExcel(dgvReportProductYear);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            int year = int.Parse(dtpReportYear.Text.ToString());

            //ChartSalespersonSalesYear(year);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           /* int i = 0;
            rep = handlerReport.ChartProductSalesYear(int.Parse(dtpReportYear.Text.ToString()));
            while (rep[i] != null)
            {
                this.chrtProductsSoldMonth.Series["SalesTotal"].Points.AddXY(rep[i].Product, rep[i].Total);
                i++;
            }*/
        }

        private void ChartSalespersonSalesYear(int year)
        {
            int i = 0;
            rep = handlerReport.ChartSalespersonSalesYear(year);
            this.chrtReportYear.Series.Add("Sales Amount(R)");
            while (rep[i] != null)
            {
                this.chrtReportYear.Series["Sales Amount(R)"].Points.AddXY(rep[i].SalesPerson, rep[i].Total);
                i++;
            }
        }

        private void ChartProductSalesYear(int year)
        {
            int i = 0;
            rep = handlerReport.ChartProductSalesYear(year);
            this.chrtReportYear.Series.Add("Sales Amount(R)");
            while (rep[i] != null)
            {
                this.chrtReportYear.Series["Sales Amount(R)"].Points.AddXY(rep[i].Product, rep[i].Total);
                i++;
            }
        }

        private void ChartProductsSoldYear(int year)
        {
            int i = 0;
            rep = handlerReport.ChartProductsSoldYear(year);
            this.chrtReportYear.Series.Add("Units");

            while (rep[i] != null)
            {
                this.chrtReportYear.Series["SalesTotal"].Points.AddXY(rep[i].Product, rep[i].Quantity);
                i++;
            }
        }

        private void cmbChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chrtReportYear.Series[0].Points.Clear();
            this.chrtReportYear.Series.Clear();
            int year = int.Parse(dtpReportYear.Text.ToString());
            if (cmbChart.Text.ToString() == "Sales per Employee")
                ChartSalespersonSalesYear(year);
            if (cmbChart.Text.ToString() == "Sales per Product")
                ChartProductSalesYear(year);
            if (cmbChart.Text.ToString() == "Products Sold")
                ChartProductsSoldYear(year);

            
        }
    }
}
