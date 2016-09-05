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
using BLL;
using DAL;

namespace PCMS
{
    public partial class frmReports : MetroForm 
    {
        private IHandler_Reports handlerReport = null;

        public frmReports()
        {
            InitializeComponent();
            handlerReport = new Handler_Reports();
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
            List<Reports> R;
            List<Reports> S;
            List<Reports> P;
            if (int.TryParse(dtpMonthReportMonth.Value.Month.ToString(), out month))
            {
                
                R = handlerReport.GetMonthRefund(month);

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

                S = handlerReport.GetMonthSales(month);

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

                P = handlerReport.GetMonthProduct(month);

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
}
