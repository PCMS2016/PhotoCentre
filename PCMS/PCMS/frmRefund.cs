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
            RefundTabControll.SelectedTab = RefundTabControll.TabPages[1];
            dgvRefundItems.DataSource = handlerRefund.DisplayRefund();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvRefundItems.CurrentCell.RowIndex;
            int refundID = Convert.ToInt32(dgvRefundItems.Rows[rowIndex].Cells[0].Value.ToString());
            
            handlerRefund.VoidRefundProduct(refundID);
            handlerRefund.VoidRefund(refundID);
            dgvRefundItems.DataSource = handlerRefund.DisplayRefund();
        }

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

        private void btnRefreshDispRefund_Click(object sender, EventArgs e)
        {

            dgvRefundItems.DataSource = handlerRefund.DisplayRefund();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            RefundTabControll.SelectedTab = RefundTabControll.TabPages[0];
        }

        private void numRefundQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

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
                //Add Refund
                Refund rfnd = new Refund();
                rfnd.OrderNumber = int.Parse(lblOrderNumber.Text);
                rfnd.SalespersonID = handlerRefund.GetSalesPersonID(salesPFName, salesPLName); ;
                rfnd.Date = DateTime.Parse(lblDate.Text.ToString());
                rfnd.Total = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value.ToString());
                handlerRefund.AddRefund(rfnd);

                //get productID == SM.SizeMediumID
                SizeMedium SM = new SizeMedium();
                SM = handlerRefund.GetProdByName(prodName);

                //Add RefundProduct
                RefundProduct rfndProd = new RefundProduct();
                rfndProd.RefundProductID = SM.SizeMediumID;
                rfndProd.RefundID = handlerRefund.GetRefundID(rfnd.OrderNumber);
                rfndProd.OrderLineID = handlerRefund.GetOrderLineID(rfnd.OrderNumber);
                rfndProd.Reason = txtRefundReason.Text.ToString();
                rfndProd.Quantity = int.Parse(numRefundQuantity.Value.ToString());
                rfndProd.Price = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[4].Value.ToString()) * double.Parse(numRefundQuantity.Value.ToString());
                rfndProd.LineTotal = double.Parse(dgvRefundOrderLines.Rows[rowIndex].Cells[5].Value.ToString());
                handlerRefund.AddRefundProduct(rfndProd);

                MessageBox.Show("Refund Added");

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
                dgvRefundOrderLines.Columns.Clear();
                tbxOrderNumber.Text = "";
                numRefundQuantity.Value = 0;
            }
            else
                MessageBox.Show("Please select amount of products to be refunded");
        }
    }
}
