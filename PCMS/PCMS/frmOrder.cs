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
        //BLL Access
        private IHandler_Order handlerOrder = null;
        private IHandler_OrderLine handlerOrderLine = null;
        private IHandler_Customer handlerCustomer = null;
        private IHandler_Product handlerProduct = null;
        private IHandler_Payment handlerPayment = null;

        //Passed variables
        private int salespersonID;

        //This variables
        private List<OrderLine> orderItems = new List<OrderLine>();
        private int orderNumber;
        private double orderTotal = 0;

        public frmOrder(int salespersonID)
        {
            InitializeComponent();
            this.salespersonID = salespersonID;
        }

        //Bind products to ComboBox
        private void BindData_Product()
        {
            cmbProduct.DataSource = handlerProduct.GetAllProducts();
            cmbProduct.DisplayMember = "Product";
            cmbProduct.ValueMember = "SizeMediumID";
        }

        //Bind payments to ComboBox
        private void BindData_Payment()
        {
            cmbPayment.DataSource = handlerPayment.GetAllPayments();
            cmbPayment.DisplayMember = "PaymentType";
            cmbPayment.ValueMember = "PaymentID";
        }

        //Form loads...
        private void frmOrder_Load(object sender, EventArgs e)
        {
            //BLL Access
            handlerOrder = new Handler_Order();
            handlerOrderLine = new Handler_OrderLine();
            handlerCustomer = new Handler_Customer();
            handlerProduct = new Handler_Product();
            handlerPayment = new Handler_Payment();

            BindData_Product();
            BindData_Payment();
        }

        //Clear the fields for customer details...
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

        //Pay button clicked...
        private void btnPay_Click(object sender, EventArgs e)
        {
            StartOrder();
        }

        //Add order to database...
        private void StartOrder()
        {
            int customerIndex = dgvCustomers.CurrentRow.Index;

            //Create object for the order
            Order order = new Order();
            order.Payment = cmbPayment.SelectedValue.ToString();
            order.Salesperson = salespersonID.ToString();
            order.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            order.Time = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            order.Completed = false;
            order.Collected = false;
            order.Customer = dgvCustomers[0, customerIndex].Value.ToString();
            order.Total = orderTotal;

            //Add order to database
            handlerOrder.AddOrder(order);

            //Get the order number from database
            orderNumber = handlerOrder.GetOrderNumber();
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

        //Show details in labels when row is clicked in customer grid...
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

        //Add item to grids...
        private void AddLineToGrid(string product, int qty, string price, double total, string instructions)
        {
            int index = dgvProducts.Rows.Count;

            dgvProducts.Rows.Add();
            dgvProducts.Rows[index].Cells[0].Value = product;
            dgvProducts.Rows[index].Cells[1].Value = qty;
            dgvProducts.Rows[index].Cells[2].Value = price;
            dgvProducts.Rows[index].Cells[3].Value = string.Format("{0:C}", total);
            dgvProducts.Rows[index].Cells[4].Value = tbxInstructions.Text;

            dgvOrderLines.Rows.Add();
            dgvOrderLines.Rows[index].Cells[0].Value = product;
            dgvOrderLines.Rows[index].Cells[1].Value = qty;
            dgvOrderLines.Rows[index].Cells[2].Value = price;
            dgvOrderLines.Rows[index].Cells[3].Value = string.Format("{0:C}", total);
        }

        //Add item to List...
        private void AddLineToList(string product, int orderNumber, int qty, double price, double total, string instructions)
        {
            //Create object for item
            OrderLine orderLine = new OrderLine();
            orderLine.Product = product;
            orderLine.OrderNumber = orderNumber;
            orderLine.Quantity = qty;
            orderLine.ItemPrice = price;
            orderLine.LineTotal = total;
            orderLine.Instructions = instructions;

            //Add object to list
            orderItems.Add(orderLine);
        }
 
        //Add Button Clicked...
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numQty.Value);
            string temp = cmbProduct.Text;
            string sPrice = temp.Substring(temp.LastIndexOf("R"));
            string product = temp.Substring(0, temp.LastIndexOf("R") - 3);
            double price = Convert.ToDouble(sPrice.Substring(1));
            double total = price * quantity;

            AddLineToGrid(product, quantity, sPrice, total, tbxInstructions.Text);

            AddLineToList(cmbProduct.SelectedValue.ToString(), orderNumber, quantity, price, total, tbxInstructions.Text);
        }

        //Next button on customer details clicked...
        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            
            foreach (var item in orderItems)
            {
                orderTotal += item.LineTotal;
            }
            lblOrderTotal.Text = string.Format("Total: {0:c}", orderTotal);
        }
    }
}
