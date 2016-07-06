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
    public partial class frmRefund : MetroForm
    {
        private IHandler_Refund handlerRefund = null;

        public frmRefund()
        {
            InitializeComponent();
            handlerRefund = new Handler_Refund();
        }

        private void frmRefund_Load(object sender, EventArgs e)
        {
            
            /*dgvOrderLines.Rows.Add(3);
            dgvOrderLines.Rows[0].Cells[0].Value = "Jumbo Photo";
            dgvOrderLines.Rows[0].Cells[1].Value = "50";
            dgvOrderLines.Rows[0].Cells[2].Value = "R  5.00";
            dgvOrderLines.Rows[0].Cells[3].Value = "None";

            dgvOrderLines.Rows[1].Cells[0].Value = "A3 Canvas";
            dgvOrderLines.Rows[1].Cells[1].Value = "1";
            dgvOrderLines.Rows[1].Cells[2].Value = "R250.00";
            dgvOrderLines.Rows[1].Cells[3].Value = "Include Stretch";

            dgvOrderLines.Rows[2].Cells[0].Value = "Mug";
            dgvOrderLines.Rows[2].Cells[1].Value = "2";
            dgvOrderLines.Rows[2].Cells[2].Value = "R 70.00";
            dgvOrderLines.Rows[2].Cells[3].Value = "None";

            lblOrderNumber.Text = "000002";
            lblCustomer.Text = "Victor Maxwel";
            lblDate.Text = "2 May 2016";
            lblTime.Text = "10:30";
            lblSalesperson.Text = "Annette Deyzel";

            lblProduct2.Text = "Jumbo Photo";
            lblQuantity2.Text = "50";
            lblPrice2.Text = "R  5.00";
            tbxInstructions.Text = "None";

            dgvRefundItems.Rows.Add();
            dgvRefundItems.Rows[0].Cells[0].Value = "Jumbo Photo";
            dgvRefundItems.Rows[0].Cells[1].Value = "2";
            dgvRefundItems.Rows[0].Cells[2].Value = "R  5.00";
            dgvRefundItems.Rows[0].Cells[3].Value = "Corrupted file.";

            lblRefundTotal.Text += " R 10.00";
            */
        }

        private void btnRefundSearchOrder_Click(object sender, EventArgs e)
        {
            int OrderNum = Int32.Parse(tbxOrderNumber.Text);
            Order order = new Order();
            order = handlerRefund.getOrderByNum(OrderNum);

            lblOrderNumber.Text = order.OrderNumber.ToString();
            lblCustomer.Text = order.Customer.ToString();
            lblDate.Text = order.Date.ToString();
            lblTime.Text = order.Time.ToString();
            lblSalesperson.Text = order.Salesperson.ToString();
        }
    }
}
