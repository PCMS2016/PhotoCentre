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
using System.Configuration;

namespace PCMS
{
    public partial class frmRefund : MetroForm
    {
        private IHandler_Refund handlerRefund = null;
        private IHandler_Company handlerCompany = null;
        private int salespersonID;
        private List<RefundProduct> refundItems = new List<RefundProduct>();
        private double refundTotal = 0;
        private int refundID;
        private DateTime minRefundDate;

        public frmRefund(int salespersonID)
        {
            InitializeComponent();
            handlerRefund = new Handler_Refund();
            handlerCompany = new Handler_Company();
            this.salespersonID = salespersonID;
        }

        private void frmRefund_Load(object sender, EventArgs e)
        {          
            int refund = GetRefundPeriod() * -1;

            minRefundDate = DateTime.Today.AddDays(refund);

            RefundTabControll.SelectedTab = tabDetails;

            tbxOrderNumber.Focus();
        }

        //Get Refund Period
        private int GetRefundPeriod()
        {
            int refund = 0;

            try
            {
                Company company = handlerCompany.GetCompanyDetails();
                refund = company.RefundPeriod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving refund period!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            return refund;
        }

        //Get Order By Number
        private void GetOrder(int orderNumber)
        {
            try
            {
                Order order = handlerRefund.getOrderByNum(orderNumber);
                if (order != null)
                {
                    lblOrderNumber.Text = order.OrderNumber.ToString();
                    lblCustomer.Text = order.Customer.ToString();
                    lblDate.Text = order.Date.ToString().Substring(0,10);
                    lblTime.Text = order.Time.ToString().Substring(11);
                    lblSalesperson.Text = order.Salesperson.ToString();

                    if (order.Completed == false)
                    {
                        MessageBox.Show("Refunds are not allowed for orders that have not been completed!");
                        this.Close();
                    }

                    GetOrderLines(orderNumber);
                }
                else
                {
                    MessageBox.Show("Order not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured searching for order!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }
        }

        //Get Order Lines
        private void GetOrderLines(int orderNumber)
        {
            try
            {
                dgvRefundOrderLines.DataSource = handlerRefund.GetOrderLines(orderNumber);
                SetGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when retrieving order items!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //search Refund
        private void btnRefundSearchOrder_Click(object sender, EventArgs e)
        {
            int OrderNum;
            if (int.TryParse(tbxOrderNumber.Text, out OrderNum))
            {
                GetOrder(OrderNum);
            }
            else
                MessageBox.Show("Order# incorrect!");
            
            if (lblDate.Text != "")
            {
                if (Convert.ToDateTime(lblDate.Text) < minRefundDate)
                {
                    MessageBox.Show("This order has exceeded the refund period!");
                    this.Close();
                }
            }

            tbxOrderNumber.Clear();              
        }

        //Populate info
        private void dgvRefundOrderLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefundOrderLines.Rows.Count > 0)
            {
                int rowIndex = dgvRefundOrderLines.CurrentCell.RowIndex;

                lblProduct.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[1].Value.ToString();
                lblQuantity.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[3].Value.ToString();
                lblPrice.Text = string.Format("{0:C}" ,dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value);
                tbxInstructions.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[6].Value.ToString();

                numRefundQuantity.Maximum = int.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[3].Value.ToString());
            }
        }

        //Set Table names
        private void SetGridHeaders()
        {
            dgvRefundOrderLines.Columns[0].Visible = false;
            dgvRefundOrderLines.Columns[1].HeaderText = "Product";
            dgvRefundOrderLines.Columns[3].HeaderText = "Quantity";
            dgvRefundOrderLines.Columns[4].HeaderText = "Item Price";
            dgvRefundOrderLines.Columns[5].HeaderText = "Total";
            dgvRefundOrderLines.Columns[6].HeaderText = "Instructions";
            dgvRefundOrderLines.Columns[4].DefaultCellStyle.Format = "c";
            dgvRefundOrderLines.Columns[5].DefaultCellStyle.Format = "c";

            dgvRefundOrderLines.Columns[2].Visible = false;
        }

        //Add item to grid
        private void AddLineToGrid(string product, int qty, double price, double total, string reason)
        {
            int index = dgvRefundItems.Rows.Count;

            dgvRefundItems.Rows.Add();
            dgvRefundItems.Rows[index].Cells[0].Value = product;
            dgvRefundItems.Rows[index].Cells[1].Value = qty;
            dgvRefundItems.Rows[index].Cells[2].Value = price;
            dgvRefundItems.Rows[index].Cells[3].Value = total;
            dgvRefundItems.Rows[index].Cells[4].Value = reason;
        }

        //Add items to list
        private void AddLineToList(int orderLineID, string reason, int qty, double price, double total)
        {
            RefundProduct line = new RefundProduct();
            line.OrderLineID = orderLineID;
            line.Reason = reason;
            line.Quantity = qty;
            line.Price = price;
            line.LineTotal = total;

            refundItems.Add(line);
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            int orderLineID = Convert.ToInt32(dgvRefundOrderLines.SelectedRows[0].Cells[0].Value.ToString());
            string reason = txtRefundReason.Text;
            string product = dgvRefundOrderLines.SelectedRows[0].Cells[1].Value.ToString();
            int qty = Convert.ToInt32(numRefundQuantity.Value);
            double price = Convert.ToDouble(dgvRefundOrderLines.SelectedRows[0].Cells[4].Value.ToString());
            double total = qty * price;

            if (txtRefundReason.Text == "")
            {
                MessageBox.Show("Please add a reason for the refund.");
            }
            else
            {
                AddLineToGrid(product, qty, price, total, reason);

                AddLineToList(orderLineID, reason, qty, price, total);

                refundTotal += total;

                lblTotal.Text = string.Format("{0:f2}", refundTotal);
            }
        }

        //
        private bool StartRefund()
        {
            bool added = true;

            Refund refund = new Refund();
            refund.OrderNumber = Convert.ToInt32(lblOrderNumber.Text);
            refund.SalespersonID = salespersonID;
            refund.Date = DateTime.Now;
            refund.Total = refundTotal;

            try
            {
                handlerRefund.AddRefund(refund);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Failed to add refund!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }

            try
            {
                refundID = handlerRefund.GetRefundID(Convert.ToInt32(lblOrderNumber.Text));
            }
            catch 
            {

            }

            return added;
        }

        //Add items to database
        private void AddRefundItems()
        {
            int temp = 0;
            foreach (var item in refundItems)
            {
                temp++;
                item.RefundID = refundID;
                try
                {
                    handlerRefund.AddRefundProduct(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not refund item on line " + temp + Environment.NewLine + Environment.NewLine +
                        ex.Message);
                }
            }
        }

        //Finish Transaction
        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (refundItems.Count > 0)
            {
                if (StartRefund() == true)
                    AddRefundItems();

                MessageBox.Show(string.Format("Refund Amount: {0:C}", refundTotal));

                this.Close();
            }
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            RefundTabControll.SelectedTab = tabFinish;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            refundItems.Clear();
            this.Close();
        }

        private void tbxOrderNumber_Enter(object sender, EventArgs e)
        {
            frmRefund.ActiveForm.AcceptButton = btnRefundSearchOrder;
        }

        private void tbxOrderNumber_Leave(object sender, EventArgs e)
        {
            frmRefund.ActiveForm.AcceptButton = btnAdd;
        }

        private void btnVoid_Customer_Click(object sender, EventArgs e)
        {
            refundItems.Clear();
            this.Close();
        }
    }
}
