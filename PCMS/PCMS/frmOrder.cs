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
        private IHandler_OrderLine handlerOrderLine = null;
        private IHandler_Customer handlerCustomer = null;
        
        public frmOrder(int salespersonID)
        {
            InitializeComponent();
            this.salespersonID = salespersonID;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            handlerOrder = new Handler_Order();
            handlerOrderLine = new Handler_OrderLine();
            handlerCustomer = new Handler_Customer();
        }

        private void ClearCustomerFields()
        {
            tbxCustomerName.Clear();
            tbxSurname.Clear();
            tbxCellphone.Clear();
            tbxEmail.Clear();
            cmbNotificationType.SelectedIndex = 0;
            cmbCustomerType.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //Add Order to Database...
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
            
        }

        //Search Customer...
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string surname = tbxSurname.Text;

            if (name == "" && surname == "")
            {
                MessageBox.Show("Enter at least a name or surname.");
            }
            else
            {
                dgvCustomers.DataSource = handlerCustomer.SearchCustomer(name, surname);
            }
        }

        //Add new customer...
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ClearCustomerFields();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomers.SelectedRows[0].Index;

            tbxCustomerName.Text = dgvCustomers.Rows[index].Cells["Name"].Value.ToString();
            tbxCustomerSurname.Text = dgvCustomers.Rows[index].Cells["Surname"].Value.ToString();
            tbxCellphone.Text = dgvCustomers.Rows[index].Cells["Cellphone"].Value.ToString();
            tbxEmail.Text = dgvCustomers.Rows[index].Cells["Email"].Value.ToString();
            cmbNotificationType.Text = dgvCustomers.Rows[index].Cells[5].Value.ToString();
            cmbCustomerType.Text = dgvCustomers.Rows[index].Cells[6].Value.ToString();
            cmbDiscount.Text = dgvCustomers.Rows[index].Cells["Discount"].Value.ToString();
        }
    }
}
