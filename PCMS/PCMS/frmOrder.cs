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
using System.Globalization;

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
        private IHandler_Discount handlerDiscount = null;

        //Passed variables
        private int salespersonID;

        //This variables
        private List<OrderLine> orderItems = new List<OrderLine>();
        private int orderNumber;
        private double orderTotal = 0;
        private bool customerSelected = false;
        private Order order = null;

        public frmOrder(int salespersonID)
        {
            InitializeComponent();
            this.salespersonID = salespersonID;                       
        }

        //Bind products to ComboBox
        private void BindData_Product()
        {
            cmbProduct.Sorted = true;
            cmbProduct.DataSource = handlerProduct.GetAllProducts();
            cmbProduct.DisplayMember = "Product";
            cmbProduct.ValueMember = "SizeMediumID";
            
        }

        //Bind payments to ComboBox
        private void BindData_Payment()
        {
            cmbPayment.Sorted = true;
            cmbPayment.DataSource = handlerPayment.GetAllPayments();
            cmbPayment.DisplayMember = "PaymentType";
            cmbPayment.ValueMember = "PaymentID";
        }

        //Bind discount to ComboBox
        private void BindData_Discount()
        {
            cmbDiscount.Sorted = true;
            cmbDiscount.DataSource = handlerDiscount.GetAllDiscount();
            cmbDiscount.DisplayMember = "Percentage";
            cmbDiscount.ValueMember = "DiscountID";
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
            handlerDiscount = new Handler_Discount();

            //Bind Data
            try
            {
                BindData_Product();
                BindData_Payment();
                BindData_Discount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connection to the database!" + Environment.NewLine + Environment.NewLine + ex.Message);
                this.Close();
            }

            //Focus controls
            tabCtrlOrder.SelectedTab = tabCustomer;
            tbxName.Focus();
        }

        //Clear the fields for customer details...
        private void ClearCustomerFields()
        {
            tbxCustomerName.Clear();
            tbxCustomerSurname.Clear();
            tbxCellphone.Clear();
            tbxEmail.Clear();
            cmbNotificationType.SelectedIndex = 0;
            cmbCustomerType.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
        }

        //Enable customer fields...
        private void EnableCustomerEdit()
        {
            tbxCustomerName.Enabled = true;
            tbxCustomerSurname.Enabled = true;
            tbxCellphone.Enabled = true;
            tbxEmail.Enabled = true;
            cmbNotificationType.Enabled = true;
            cmbCustomerType.Enabled = true;
            cmbDiscount.Enabled = true;
        }

        //Disable customer fields...
        private void DisableCustomerEdit()
        {
            tbxCustomerName.Enabled = false;
            tbxCustomerSurname.Enabled = false;
            tbxCellphone.Enabled = false;
            tbxEmail.Enabled = false;
            cmbNotificationType.Enabled = false;
            cmbCustomerType.Enabled = false;
            cmbDiscount.Enabled = false;
        }

        //Pay button clicked...
        private void btnPay_Click(object sender, EventArgs e)
        {
            double change = 0;
            double cash;

            tbxCash.Text = tbxCash.Text.Replace(".", ",");
            
            if (cmbPayment.Text == "Cash" && tbxCash.Text == "")
            {
                MessageBox.Show("Please enter amount of cash recieved.");
                tbxCash.Focus();
            }
            else
            {
                if (double.TryParse(tbxCash.Text, out cash))
                {
                    if (cash >= orderTotal)
                    {
                        StartOrder();
                        AddOrderItems();

                        if (cmbPayment.Text == "Cash")
                        {
                            change = (Convert.ToDouble(tbxCash.Text)) - orderTotal;
                            MessageBox.Show(string.Format("Change: {0:C}", change));
                            this.Close();
                        }


                        //Generate list of products to be printed on the receipt
                        List<OrderLine> orderItemsPrint = new List<OrderLine>();
                        for (int i = 0; i < dgvOrderLines.Rows.Count; i++)
                        {
                            OrderLine item = new OrderLine();
                            item.Product = dgvOrderLines[0, i].Value.ToString();
                            item.Quantity = orderItems[i].Quantity;
                            item.ItemPrice = orderItems[i].ItemPrice;
                            item.LineTotal = orderItems[i].LineTotal;
                            orderItemsPrint.Add(item);
                        }

                        //Print the receipt

                        PrintReceipt print = new PrintReceipt(orderItemsPrint, order.Date.ToString(), order.Time.ToString(),
                            orderNumber.ToString(), orderTotal, Convert.ToDouble(tbxCash.Text), change,
                            Convert.ToDouble(cmbDiscount.Text), tbxCustomerName.Text + " " + tbxCustomerSurname.Text);
                        print.Print();
                    }
                    else
                        MessageBox.Show("Not enough cash!");
                }
                else
                    MessageBox.Show("Invalid Amount Entered!");
                
            }
        }

        //Add order items to database...
        private void AddOrderItems()
        {
            foreach (var item in orderItems)
            {
                item.OrderNumber = orderNumber;
                handlerOrderLine.AddOrderLine(item);
            }
        }
        //Add order to database...
        private void StartOrder()
        {
            int customerIndex = dgvCustomers.CurrentRow.Index;

            //Create object for the order
            order = new Order();
            order.Payment = cmbPayment.SelectedValue.ToString();
            order.Salesperson = salespersonID.ToString();
            order.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            order.Time = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            order.Completed = false;
            order.Collected = false;
            order.Customer = dgvCustomers[0, customerIndex].Value.ToString();
            order.Total = orderTotal;

            //Add order to database
            try
            {
                handlerOrder.AddOrder(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add the order!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }

            //Get the order number from database
            orderNumber = handlerOrder.GetOrderNumber();
        }

        //Search Customer...
        private void SearchCustomer(string name, string surname)
        {
            try
            {
                dgvCustomers.DataSource = handlerCustomer.SearchCustomer(name, surname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when searching for customer!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }

            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[5].Visible = false;
            dgvCustomers.Columns[6].Visible = false;
            dgvCustomers.Columns[7].Visible = false;

            dgvCustomers.Columns[0].HeaderText = "ID";
            dgvCustomers.Columns[1].HeaderText = "Name";
            dgvCustomers.Columns[2].HeaderText = "Surname";
            dgvCustomers.Columns[3].HeaderText = "Cellphone";
            dgvCustomers.Columns[4].HeaderText = "Email";
            dgvCustomers.Columns[5].HeaderText = "Notification";
            dgvCustomers.Columns[6].HeaderText = "Customer Type";
            dgvCustomers.Columns[7].HeaderText = "Discount";
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
                SearchCustomer(name, surname);
            }

            frmOrder.ActiveForm.AcceptButton = btnNext;
        }

        //Add Customer to database...
        private void AddCustomer()
        {
            Customer customer = new Customer();
            customer.Name = tbxCustomerName.Text;
            customer.Surname = tbxCustomerSurname.Text;
            customer.Cellphone = tbxCellphone.Text;
            customer.Email = tbxEmail.Text;
            customer.NotificationType = cmbNotificationType.Text;
            customer.CustomerType = cmbCustomerType.Text;
            customer.Discount = Convert.ToDouble(cmbDiscount.SelectedValue);

            try
            {
                handlerCustomer.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when adding customer!" + Environment.NewLine + Environment.NewLine+ ex.Message);
            }
        }

        //Update Customer to database...
        private void UpdateCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerID = Convert.ToInt32(dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Cells[0].Value.ToString());
            customer.Name = tbxCustomerName.Text;
            customer.Surname = tbxCustomerSurname.Text;
            customer.Cellphone = tbxCellphone.Text;
            customer.Email = tbxEmail.Text;
            customer.NotificationType = cmbNotificationType.Text;
            customer.CustomerType = cmbCustomerType.Text;
            customer.Discount = Convert.ToDouble(cmbDiscount.SelectedValue);

            try
            {
                handlerCustomer.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating customer!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        //Validate Customer Fields
        private bool ValidateCustomerFields()
        {
            bool valid = true;

            if (tbxCustomerName.Text == "" || tbxCustomerSurname.Text == "" || (tbxCellphone.Text).Length != 10)
                valid = false;

            if (cmbNotificationType.Text == "Email" && tbxEmail.Text == "")
            {
                MessageBox.Show("An email address needs to be supplied.");
                valid = false;
            }

            if (tbxEmail.Text == "")
                tbxEmail.Text = "N/A";

            return valid;
        }

        //Add new customer...
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            if (btnNewCustomer.Text == "New Customer")
            {
                btnUpdateCustomer.Enabled = false;
                btnNewCustomer.Text = "Save";
                ClearCustomerFields();
                EnableCustomerEdit();

                tbxCustomerName.Focus();
            }
            else
            {
                if (ValidateCustomerFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to add this customer?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AddCustomer();

                        btnUpdateCustomer.Enabled = true;
                        btnNewCustomer.Text = "New Customer";
                        DisableCustomerEdit();

                        SearchCustomer(tbxCustomerName.Text, tbxCustomerSurname.Text);
                        ClearCustomerFields();

                        customerSelected = false;
                    }
                    frmOrder.ActiveForm.AcceptButton = btnNext;
                }
                else
                {
                    MessageBox.Show("Please ensure all details are valid.");
                }

            }
        }

        //Update customer details...
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (customerSelected == true)
            {
                if (btnUpdateCustomer.Text == "Update Customer")
                {
                    btnNewCustomer.Enabled = false;
                    btnUpdateCustomer.Text = "Save";
                    EnableCustomerEdit();

                    tbxCustomerName.Focus();
                }
                else
                {
                    if (ValidateCustomerFields() == true)
                    {
                        if (MessageBox.Show("Are you sure you want to update this customer?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            UpdateCustomer();

                            btnNewCustomer.Enabled = true;
                            btnUpdateCustomer.Text = "Update Customer";
                            DisableCustomerEdit();
                            
                            SearchCustomer(tbxCustomerName.Text, tbxCustomerSurname.Text);

                            customerSelected = true;
                        }
                        frmOrder.ActiveForm.AcceptButton = btnNext;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected!");
            }
        }

        //Customer selected...
        private void SelectCustomer()
        {
            int index = dgvCustomers.SelectedRows[0].Index;

            tbxCustomerName.Text = dgvCustomers.Rows[index].Cells["Name"].Value.ToString();
            tbxCustomerSurname.Text = dgvCustomers.Rows[index].Cells["Surname"].Value.ToString();
            tbxCellphone.Text = dgvCustomers.Rows[index].Cells["Cellphone"].Value.ToString();
            tbxEmail.Text = dgvCustomers.Rows[index].Cells["Email"].Value.ToString();
            cmbNotificationType.Text = dgvCustomers.Rows[index].Cells[5].Value.ToString();
            cmbCustomerType.Text = dgvCustomers.Rows[index].Cells[6].Value.ToString();
            cmbDiscount.Text = dgvCustomers.Rows[index].Cells["Discount"].Value.ToString();

            customerSelected = true;
        }

        //Show details in labels when row is clicked in customer grid...
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.Rows.Count > 0)
            {
                SelectCustomer();
            }
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
            dgvProducts.Rows[index].Cells[4].Value = instructions;

            dgvOrderLines.Rows.Add();
            dgvOrderLines.Rows[index].Cells[0].Value = product;
            dgvOrderLines.Rows[index].Cells[1].Value = qty;
            dgvOrderLines.Rows[index].Cells[2].Value = price;
            dgvOrderLines.Rows[index].Cells[3].Value = string.Format("{0:C}", total);
            dgvOrderLines.Rows[index].Cells[4].Value = instructions;
        }

        //Add item to List...
        private void AddLineToList(string product, int qty, double price, double total, string instructions)
        {
            //Create object for item
            OrderLine orderLine = new OrderLine();
            orderLine.Product = product;
            orderLine.Quantity = qty;
            orderLine.ItemPrice = price;
            orderLine.LineTotal = total;
            orderLine.Instructions = instructions;

            //Add object to list
            orderItems.Add(orderLine);
        }
 
        //Add Button Clicked (Products)...
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string instructions = tbxInstructions.Text;
            int quantity = Convert.ToInt32(numQty.Value);
            string temp = cmbProduct.Text;
            string sPrice = temp.Substring(temp.LastIndexOf("R"));
            string product = temp.Substring(0, temp.LastIndexOf("R") - 3);
            double price = Convert.ToDouble(sPrice.Substring(1));
            double total = price * quantity;

            if (instructions == "")
            {
                instructions = "None";
            }

            if (numQty.Value == 0)
            {
                MessageBox.Show("Invalid Quantity!");
                numQty.Focus();
            }
            else
            {
                AddLineToGrid(product, quantity, sPrice, total, instructions);

                AddLineToList(cmbProduct.SelectedValue.ToString(), quantity, price, total, instructions);

                numQty.Value = 0;
                tbxInstructions.Clear();

                frmOrder.ActiveForm.AcceptButton = btnFinishTransaction;
            }
         
        }

        //Next button on customer details clicked...
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Switch tab
            if (customerSelected == true)
            {
                tabCtrlOrder.SelectedTab = tabProducts;
            }
            else
            {
                MessageBox.Show("No Customer Selected!");
            }

        }

        //Finish Transaction Button clicked...
        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            //Calculate order total
            foreach (var item in orderItems)
            {
                orderTotal += item.LineTotal;
            }
            lblOrderTotal.Text = string.Format("Total: {0:c}", orderTotal);

            //Switch tab
            if (dgvProducts.Rows.Count > 0)
            {
                tabCtrlOrder.SelectedTab = tabFinish;                
            }
            else
            {
                MessageBox.Show("No Products Added!");
            }

            tbxCash.Focus();
        }

        //Don't allow user to proceed if details are missing...
        private void tabCtrlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (customerSelected == false && (tabCtrlOrder.SelectedTab == tabProducts || tabCtrlOrder.SelectedTab == tabFinish))
            {
                tabCtrlOrder.SelectedTab = tabCustomer;
                MessageBox.Show("No Customer Selected!");
            }
            if (tabCtrlOrder.SelectedTab == tabFinish && dgvProducts.Rows.Count == 0)
            {
                tabCtrlOrder.SelectedTab = tabProducts;
                MessageBox.Show("No Products Added!");
            }
        }

        //Void Order...
        private void VoidOrder()
        {
            if (MessageBox.Show("Void this order?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                orderItems.Clear();
            }
        }

        private void btnVoid_Customer_Click(object sender, EventArgs e)
        {
            VoidOrder();
        }

        private void btnVoid_Products_Click(object sender, EventArgs e)
        {
            VoidOrder();            
        }

        private void btnVoid_Finish_Click(object sender, EventArgs e)
        {
            VoidOrder();
        }

        //Select customer when Enter button is pressed...
        private void dgvCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            SelectCustomer();
        }

        //Remove Item from order...
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int index = dgvProducts.SelectedRows[0].Index;

            dgvProducts.Rows.RemoveAt(index);
            dgvOrderLines.Rows.RemoveAt(index);

            orderItems.RemoveAt(index);
        }

        //Edit order item...
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit Item")
            {
                cmbProduct.Enabled = false;
                btnEdit.Text = "Save";
            }
            else
            {
                int index = dgvProducts.SelectedRows[0].Index;
                string instructions = tbxInstructions.Text;
                string temp = dgvProducts.Rows[index].Cells[2].Value.ToString();
                double price = Convert.ToDouble(temp.Substring(temp.LastIndexOf("R") + 1));
                double total = Convert.ToDouble(numQty.Value.ToString()) * price;

                if (instructions == "")
                {
                    instructions = "None";
                }

                orderItems[index].Quantity = Convert.ToInt32(numQty.Value);
                orderItems[index].Instructions = instructions;
                orderItems[index].LineTotal = total;

                dgvProducts.Rows[index].Cells[1].Value = numQty.Value.ToString();
                dgvProducts.Rows[index].Cells[3].Value = string.Format("{0:C}", total);
                dgvProducts.Rows[index].Cells[4].Value = instructions;

                cmbProduct.Enabled = true;
                btnEdit.Enabled = false;

                btnEdit.Text = "Edit Item";
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProducts.SelectedRows[0].Index;

            cmbProduct.Text = dgvProducts.Rows[index].Cells[0].Value.ToString() + " - " + dgvProducts.Rows[index].Cells[2].Value.ToString();
            numQty.Value = Convert.ToInt32(dgvProducts.Rows[index].Cells[1].Value.ToString());
            tbxInstructions.Text = dgvProducts.Rows[index].Cells[4].Value.ToString();

            btnEdit.Enabled = true;
        }

        //Reset fields when different product is selected...
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQty.Value = 0;
            tbxInstructions.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbxCash_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("Help\\Help_Orders.html");
            }

            if (e.KeyCode == Keys.Escape)
            {
                VoidOrder();
            }

            if (e.KeyCode == Keys.Enter && tabCtrlOrder.SelectedTab == tabFinish)
            {
                btnPay.PerformClick();
            }
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.Text != "Cash")
            {
                tbxCash.Text = orderTotal.ToString();
            }
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            frmOrder.ActiveForm.AcceptButton = btnCustomerSearch;
        }

        private void tbxSurname_Enter(object sender, EventArgs e)
        {
            frmOrder.ActiveForm.AcceptButton = btnCustomerSearch;
        }

        private void tbxCustomerName_Enter(object sender, EventArgs e)
        {
            if (btnUpdateCustomer.Text == "Save")
            {
                frmOrder.ActiveForm.AcceptButton = btnUpdateCustomer;
            }
            else if (btnNewCustomer.Text == "Save")
            {
                frmOrder.ActiveForm.AcceptButton = btnNewCustomer;
            }
        }

        private void tabFinish_Enter(object sender, EventArgs e)
        {
            frmOrder.ActiveForm.AcceptButton = btnPay;
        }

        private void cmbProduct_Enter(object sender, EventArgs e)
        {
            cmbProduct.Focus();
            frmOrder.ActiveForm.AcceptButton = btnAdd;
        }

    }
}
