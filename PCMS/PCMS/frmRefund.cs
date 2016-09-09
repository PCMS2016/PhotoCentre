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
        public string salesPFName = null;
        public string salesPLName = null;
        private int refundNum;
        private Refund[] rfnd;
        private RefundProduct[] rProd;

        public frmRefund()
        {
            InitializeComponent();
            handlerRefund = new Handler_Refund();
            rfnd = new Refund[100];
            rProd = new RefundProduct[100];
            refundNum = 0;
        }

        private void frmRefund_Load(object sender, EventArgs e)
        {
           
        }

        //search Refund
        private void btnRefundSearchOrder_Click(object sender, EventArgs e)
        {
            int OrderNum;
            if (int.TryParse(tbxOrderNumber.Text, out OrderNum))
            {
                Order order = new Order();
                order = handlerRefund.getOrderByNum(OrderNum);
                if (order != null)
                {
                    lblOrderNumber.Text = order.OrderNumber.ToString();
                    lblCustomer.Text = order.Customer.ToString();
                    lblDate.Text = order.Date.ToString();
                    lblTime.Text = order.Time.ToString();
                    lblSalesperson.Text = order.Salesperson.ToString();


                    dgvRefundOrderLines.DataSource = handlerRefund.GetOrderLines(OrderNum);

                    salesPFName = order.Salesperson.ToString();
                    string[] salesNames = salesPFName.Split(' ');
                    salesPFName = salesNames[0];
                    salesPLName = salesNames[1];

                    tableNames();
                }
                else
                {
                    lblOrderNumber.Text = "Order not found";
                    lblCustomer.Text = "Order not found";
                    lblDate.Text = "Order not found";
                    lblTime.Text = "Order not found";
                    lblSalesperson.Text = "Order not found";
                    dgvRefundOrderLines.DataSource = null;
                    tbxOrderNumber.Text = "Order not found";
                }
            }
            else
                tbxOrderNumber.Text = "Numbers Only";
                
        }

        //Populate info
        private void dgvRefundOrderLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvRefundOrderLines.CurrentCell.RowIndex;

            lblProduct.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[1].Value.ToString();
            lblQuantity.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[3].Value.ToString();
            lblPrice.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value.ToString();
            tbxInstructions.Text = dgvRefundOrderLines.Rows[rowIndex].Cells[6].Value.ToString();
            
            numRefundQuantity.Maximum = int.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[3].Value.ToString());
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            int i = 0;
            RefundTabControll.SelectedTab = RefundTabControll.TabPages[1];
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {           
            if (dgvRefundItems.Rows.Count > 0)
            {
                int rowIndex = dgvRefundItems.CurrentCell.RowIndex;
                dgvRefundItems.Rows.RemoveAt(rowIndex);
            }
        }

        //Set Table names
        private void tableNames()
        {
            dgvRefundOrderLines.Columns[0].HeaderText = "Orderline ID";
            dgvRefundOrderLines.Columns[1].HeaderText = "Product";
            dgvRefundOrderLines.Columns[3].HeaderText = "Quantity";
            dgvRefundOrderLines.Columns[4].HeaderText = "Item Price";
            dgvRefundOrderLines.Columns[5].HeaderText = "Total";
            dgvRefundOrderLines.Columns[6].HeaderText = "Instructions";
            dgvRefundOrderLines.Columns[4].DefaultCellStyle.Format = "c";
            dgvRefundOrderLines.Columns[5].DefaultCellStyle.Format = "c";

            dgvRefundOrderLines.Columns[2].Visible = false;
        }
                
        //Adds to Refund & RefundProduct tables
        private void btnRefund_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvRefundItems.CurrentCell.RowIndex;
            string prodName = dgvRefundItems.Rows[rowIndex].Cells[1].Value.ToString();
            int RProdID = int.Parse(dgvRefundItems.Rows[rowIndex].Cells[0].Value.ToString());
            if (int.TryParse(dgvRefundItems.Rows[rowIndex].Cells[0].Value.ToString(), out RProdID))
            {
                Refund refund = new Refund();
                refund = rfnd[RProdID-1];
                handlerRefund.AddRefund(refund);
                RefundProduct rfundProd = new RefundProduct();
                rfundProd = rProd[RProdID-1];
                handlerRefund.AddRefundProduct(rfundProd);

                MessageBox.Show("Product Refunded");
                dgvRefundItems.Rows.RemoveAt(rowIndex);
            }

        }

        private void numRefundQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        //Add to Refund -- Adds to dgvRefundItems -- Add to arrays
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (numRefundQuantity.Value > 0)
            {
                int rowIndex = dgvRefundOrderLines.CurrentCell.RowIndex;
                string prodName = dgvRefundOrderLines.Rows[rowIndex].Cells[1].Value.ToString();
                if(txtRefundReason.Text == null)
                {
                    txtRefundReason.Text = "N/A";
                }
                //Add Refund Array
                rfnd[refundNum] = new Refund();
                rfnd[refundNum].OrderNumber = int.Parse(lblOrderNumber.Text);
                rfnd[refundNum].SalespersonID = handlerRefund.GetSalesPersonID(salesPFName, salesPLName); ;
                rfnd[refundNum].Date = DateTime.Parse(lblDate.Text.ToString());
                rfnd[refundNum].Total = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value.ToString());

                //get productID == SM.SizeMediumID
                SizeMedium SM = new SizeMedium();
                SM = handlerRefund.GetProdByName(prodName);

                //Add RefundProduct Array
                rProd[refundNum] = new RefundProduct();
                rProd[refundNum].RefundProductID = dgvRefundItems.Rows.Count + 1;
                rProd[refundNum].RefundID = handlerRefund.GetRefundID(int.Parse(lblOrderNumber.Text));
                rProd[refundNum].OrderLineID = handlerRefund.GetOrderLineID(rfnd[refundNum].OrderNumber);
                rProd[refundNum].Reason = txtRefundReason.Text.ToString();
                rProd[refundNum].Quantity = int.Parse(numRefundQuantity.Value.ToString());
                rProd[refundNum].Price = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[4].Value.ToString()) * double.Parse(numRefundQuantity.Value.ToString());
                rProd[refundNum].LineTotal = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value.ToString());
                //handlerRefund.AddRefundProduct(rfndProd);

                
                
                int index = dgvRefundItems.Rows.Count;

                dgvRefundItems.Rows.Add();
                dgvRefundItems.Rows[index].Cells[0].Value = rProd[refundNum].RefundProductID;
                dgvRefundItems.Rows[index].Cells[1].Value = lblProduct.Text.ToString();
                dgvRefundItems.Rows[index].Cells[2].Value = rProd[refundNum].Quantity;
                dgvRefundItems.Rows[index].Cells[3].Value = rProd[refundNum].Reason;
                dgvRefundItems.Rows[index].Cells[4].Value = rProd[refundNum].Price;
                dgvRefundItems.Rows[index].Cells[5].Value = rfnd[refundNum].Date;
                
                
                refundNum++;
                lblCustomer.Text = "";
                lblDate.Text = "";
                tbxInstructions.Text = "";
                lblOrderNumber.Text = "";
                lblPrice.Text = "";
                lblProduct.Text = "";
                lblQuantity.Text = "";
                lblRefundTotal.Text = "";
                lblSalesperson.Text = "";
                lblTime.Text = "";
                txtRefundReason.Text = "";
                dgvRefundOrderLines.Columns.Clear();
                tbxOrderNumber.Text = "";
                numRefundQuantity.Value = 0;
            }
            else
                MessageBox.Show("Please select amount of products to be refunded");
        }

        //Removes refund from list
        private void btnVoid_Customer_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvRefundItems.CurrentCell.RowIndex;
            dgvRefundItems.Rows.RemoveAt(rowIndex);
        }

        private void dgvRefundItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }
    }
}
