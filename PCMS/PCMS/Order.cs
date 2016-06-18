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
using DAL;
using BLL;

namespace PCMS
{
    public partial class frmOrder : MetroForm 
    {
        int salespersonID;
        private IHandler_Order handlerOrder = null;

        public frmOrder(int salespersonID)
        {
            InitializeComponent();
            this.salespersonID = salespersonID;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            handlerOrder = new Handler_Order();
        }

        private void rtbxReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //Add Order to Database===>
            int customerIndex = dgvCustomers.CurrentRow.Index;

            Order order = new Order();
            order.Payment = cmbPayment.SelectedIndex.ToString();
            order.Salesperson = salespersonID.ToString();
            order.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            order.Time = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            order.Completed = false;
            order.Collected = false;
            order.Customer = dgvCustomers[0, customerIndex].Value.ToString();
            order.Total = Convert.ToDouble(lblTotal.Text);

            handlerOrder.AddOrder(order);
            //<===
        }
    }
}
