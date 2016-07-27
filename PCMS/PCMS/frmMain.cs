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
    public partial class frmMain : MetroForm 
    {
        private IHandler_Order handlerOrder = null;
        private IHandler_OrderLine handlerOrderLines = null;
        private IHandler_Customer handlerCustomer = null;

        int salespersonID;
        public int selectedOrderNum = 0;
        string privileges;
        string employeeType;

        public frmMain(int salespersonID, string user, string privileges, string employeeType)
        {
            InitializeComponent();
            this.Text += " " + user;
            this.salespersonID = salespersonID;
            this.privileges = privileges;
            this.employeeType = employeeType;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Limit access to features according to user rights...
            if (privileges == "Limited")
            {
                tileReports.Enabled = false;
                tsiAdmin.Enabled = false;
                tileSettings.Enabled = false;
            }
            if (employeeType == "Temp")
            {
                tileRefund.Enabled = false;
                tsiRefund.Enabled = false;
            }

            //Load orders of the current day...
            handlerOrder = new Handler_Order();
            BindData_Orders();
        }

        //Orders grid header text
        private void SetOrdersHeaders()
        {
            dgvOrders.Columns[0].HeaderText = "Order#";
            dgvOrders.Columns[1].HeaderText = "Payment";
            dgvOrders.Columns[2].HeaderText = "Salesperson";
            dgvOrders.Columns[3].HeaderText = "Date";
            dgvOrders.Columns[4].HeaderText = "Time";
            dgvOrders.Columns[5].HeaderText = "Completed";
            dgvOrders.Columns[6].HeaderText = "Collected";
            dgvOrders.Columns[7].HeaderText = "Customer";
            dgvOrders.Columns[8].HeaderText = "Total";

            dgvOrders.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrders.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrders.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrders.Columns[8].DefaultCellStyle.Format = "C";

            dgvOrders.Columns[1].Visible = false;
            dgvOrders.Columns[4].Visible = false;
        }
        //Bind orders to orders grid...
        private void BindData_Orders()
        {
            dgvOrders.DataSource = handlerOrder.GetAllOrders();

            SetOrdersHeaders();
        }

        //Bind order lines to order lines grid...
        private void BindData_OrderLines(int orderNumber)
        {
            dgvOrderLines.DataSource = handlerOrderLines.GetOrderLines(orderNumber);
            dgvOrderLines.Columns[0].HeaderText = "ID";
            dgvOrderLines.Columns[1].HeaderText = "Product";
            dgvOrderLines.Columns[3].HeaderText = "Qty";
            dgvOrderLines.Columns[4].HeaderText = "Price";
            dgvOrderLines.Columns[5].HeaderText = "Total";
            dgvOrderLines.Columns[6].HeaderText = "Instructions";
            

            dgvOrderLines.Columns[5].DefaultCellStyle.Format = "C";
            dgvOrderLines.Columns[4].DefaultCellStyle.Format = "C";

            dgvOrderLines.Columns[0].Visible = false;
            dgvOrderLines.Columns[2].Visible = false;
        }
        //Start a new order transaction...
        private void tileNewOrder_Click(object sender, EventArgs e)
        {
            frmOrder Order = new frmOrder(salespersonID);
            Order.ShowDialog();
        }

        //Start a new refund transaction...
        private void tileRefund_Click(object sender, EventArgs e)
        {
            frmRefund Refund = new frmRefund();
            Refund.ShowDialog();
        }

        //Generate reports...
        private void tileReports_Click(object sender, EventArgs e)
        {
            frmReports Reports = new frmReports();
            Reports.ShowDialog();
        }

        //Enter settins...
        private void tileSettings_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            Settings.ShowDialog();
        }

        //Go to specials...
        private void tileSpecials_Click(object sender, EventArgs e)
        {
            frmSpecials Specials = new frmSpecials();
            Specials.ShowDialog();
        }

        //Load details for a specific order...
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                int rowIndex = dgvOrders.CurrentCell.RowIndex;

                int orderNumber = Convert.ToInt32(dgvOrders.Rows[rowIndex].Cells[0].Value.ToString());

                selectedOrderNum = orderNumber;

                //Display all items in the order
                handlerOrderLines = new Handler_OrderLine();
                BindData_OrderLines(orderNumber);

                //Display order details 
                lblOrderNumber.Text = dgvOrders.Rows[rowIndex].Cells[0].Value.ToString();
                lblCustomer.Text = dgvOrders.Rows[rowIndex].Cells[7].Value.ToString();
                lblDate.Text = (dgvOrders.Rows[rowIndex].Cells[3].Value.ToString()).Substring(0,10);
                lblTime.Text = (dgvOrders.Rows[rowIndex].Cells[4].Value.ToString()).Substring(11);
                lblCompletion.Text = dgvOrders.Rows[rowIndex].Cells[5].Value.ToString();
                lblCollection.Text = dgvOrders.Rows[rowIndex].Cells[6].Value.ToString();
                lblSalesperson.Text = dgvOrders.Rows[rowIndex].Cells[2].Value.ToString();

                if (lblCompletion.Text == "False")
                {
                    btnCompleted.Enabled = true;
                }
                else
                {
                    btnCompleted.Enabled = false;
                }
                if (lblCollection.Text == "False")
                {
                    btbCollected.Enabled = true;
                }
                else
                {
                    btbCollected.Enabled = false;
                }
     
            }
        }

        //Log out as the current user...
        private void tileLogout_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
        }

        //Get Order based on order#
        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            int OrderNum;
            if (int.TryParse(tbxOrderNumber.Text, out OrderNum))
            {
                dgvOrders.DataSource = handlerOrder.getParaOrderList(OrderNum);
                SetOrdersHeaders();
                tbxOrderNumber.Clear();

            }
            else
                MessageBox.Show("Order Number Should Be Numeric!");
            

           
        }

        //Get Order based on customer name/surname
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" && tbxSurname.Text == "")
            {
                MessageBox.Show("Enter at least a name or surname to search orders!");
            }
            else
            {
                string custFirstName = tbxName.Text;
                string custLastName = tbxSurname.Text;
                dgvOrders.DataSource = handlerOrder.getParaCustList(custFirstName, custLastName);

                SetOrdersHeaders();

                tbxName.Clear();
                tbxSurname.Clear();
            }
        }

        //Get order by date -- dropdown list
        private void dtpDateSearch_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtpDateSearch.Text);
            dgvOrders.DataSource = handlerOrder.getOrderDateList(date);

            SetOrdersHeaders();
        }

        //Get order by date -- 'Today' button
        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            dgvOrders.DataSource = handlerOrder.getOrderDateList(date);

            SetOrdersHeaders();
        }

        //Notify Customer
        private void NotifyCustomer()
        {
            int orderNumber = int.Parse(dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells[0].Value.ToString());

            handlerCustomer = new Handler_Customer(); 
            List<string> to = new List<string>();

            to.Add(handlerCustomer.GetEmailAddress(orderNumber));

            string msg = "Your order (Order#: " + orderNumber.ToString() + ") is ready for collection at Photo Centre Uitenhage." + Environment.NewLine;

            EmailNotification email = new EmailNotification(to, "Order Collection", msg);
            email.SendMail();
        }

        //Complete Order
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            handlerOrder.CompleteOrder(selectedOrderNum);

            dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells["Completed"].Value = true;

            btnCompleted.Enabled = false;

            NotifyCustomer();
        }

        //Order has been collected
        private void btbCollected_Click(object sender, EventArgs e)
        {
            handlerOrder.CollectOrder(selectedOrderNum);

            dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells["Collected"].Value = true;

            btbCollected.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Refresh
        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            BindData_Orders();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("Help\\Help_Main.html");
            }
            if (e.KeyCode == Keys.F4)
            {
                tileNewOrder.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                tileRefund.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                tileSpecials.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                tileReports.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                tileSettings.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                tileLogout.PerformClick();
            }
        }

        private void tsiNewOrder_Click(object sender, EventArgs e)
        {
            tileNewOrder.PerformClick();
        }

        private void tsiRefund_Click(object sender, EventArgs e)
        {
            tileRefund.PerformClick();
        }

        private void tsiReports_Click(object sender, EventArgs e)
        {
            tileReports.PerformClick();
        }

        private void tsiSettings_Click(object sender, EventArgs e)
        {
            tileSettings.PerformClick();
        }

        private void tsiAbout_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help\\Help_Main.html");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCMS_About about = new PCMS_About();
            about.ShowDialog();
        }
    }
}
