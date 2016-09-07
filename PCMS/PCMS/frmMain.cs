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
        bool completed = true;
        bool collected = false;

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
            handlerCustomer = new Handler_Customer();

            try
            {
                btnToday.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when retrieving orders data!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }

            cbxCompleted.Checked = true;
            cbxCollectedOrders.Checked = false;
        }

        //Orders grid header text
        private void SetOrdersHeaders()
        {
            dgvOrders.Columns[0].HeaderText = "Order#";
            dgvOrders.Columns[2].HeaderText = "Salesperson";
            dgvOrders.Columns[3].HeaderText = "Date";
            dgvOrders.Columns[5].HeaderText = "Completed";
            dgvOrders.Columns[6].HeaderText = "Collected";
            dgvOrders.Columns[7].HeaderText = "Customer";
            dgvOrders.Columns[8].HeaderText = "Total";

            dgvOrders.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrders.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrders.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrders.Columns[8].DefaultCellStyle.Format = "C";

            dgvOrders.Columns[1].Visible = false;
            dgvOrders.Columns[4].Visible = false;
        }
        //Bind orders to orders grid...
        private void BindData_Orders()
        {
            try
            {
                dgvOrders.DataSource = handlerOrder.GetAllOrders(completed, collected);

                SetOrdersHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured connecting to database!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
                this.Close();
            }
        }

        //Order Lines grid header text
        private void SetOrderLinesHeaders()
        {
            cbxCollected.Columns[1].HeaderText = "Product";
            cbxCollected.Columns[3].HeaderText = "Qty";
            cbxCollected.Columns[4].HeaderText = "Price";
            cbxCollected.Columns[5].HeaderText = "Total";
            cbxCollected.Columns[6].HeaderText = "Instructions";

            cbxCollected.Columns[5].DefaultCellStyle.Format = "C";
            cbxCollected.Columns[4].DefaultCellStyle.Format = "C";

            cbxCollected.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cbxCollected.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            cbxCollected.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cbxCollected.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            cbxCollected.Columns[0].Visible = false;
            cbxCollected.Columns[2].Visible = false;
        }

        //Bind order lines to order lines grid...
        private void BindData_OrderLines(int orderNumber)
        {
            try
            {
                cbxCollected.DataSource = handlerOrderLines.GetOrderLines(orderNumber);

                SetOrderLinesHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured terieving order lines!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }
        }

        #region Tile Click
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
            frmSpecials Specials = new frmSpecials(employeeType);
            Specials.ShowDialog();
        }

        //Log out as the current user...
        private void tileLogout_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
        }
        #endregion

        //Select Order
        private void SelectOrder()
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
            lblDate.Text = (dgvOrders.Rows[rowIndex].Cells[3].Value.ToString()).Substring(0, 10);
            lblTime.Text = (dgvOrders.Rows[rowIndex].Cells[4].Value.ToString()).Substring(11);

            if (Convert.ToBoolean(dgvOrders.Rows[rowIndex].Cells[5].Value.ToString()) == true)
                lblCompletion.Text = "Yes";
            else
                lblCompletion.Text = "No";

            if (Convert.ToBoolean(dgvOrders.Rows[rowIndex].Cells[6].Value.ToString()) == true)
                lblCollection.Text = "Yes";
            else
                lblCollection.Text = "No";

            lblSalesperson.Text = dgvOrders.Rows[rowIndex].Cells[2].Value.ToString();
        }

        //Load details for a specific order...
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                SelectOrder();

                //Enable/Disable Buttons For Completed and Collected
                if (lblCompletion.Text == "No")
                {
                    btnCompleted.Enabled = true;
                }
                else
                {
                    btnCompleted.Enabled = false;

                    if (lblCollection.Text == "No")
                    {
                        btbCollected.Enabled = true;
                    }
                    else
                    {
                        btbCollected.Enabled = false;
                    }
                }                
            }
        }

        //Get Order based on order#
        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            int OrderNum;
            if (int.TryParse(tbxOrderNumber.Text, out OrderNum))
            {
                try
                {
                    dgvOrders.DataSource = handlerOrder.getParaOrderList(OrderNum);
                    SetOrdersHeaders();
                    tbxOrderNumber.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured when searching for order!" + Environment.NewLine + Environment.NewLine +
                        ex.Message);
                }
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

                try
                {
                    dgvOrders.DataSource = handlerOrder.getParaCustList(custFirstName, custLastName, completed, collected);

                    SetOrdersHeaders();

                    tbxName.Clear();
                    tbxSurname.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured when searching for order!" + Environment.NewLine + Environment.NewLine +
                        ex.Message);
                }
            }
        }

        //Get order by date -- dropdown list
        private void dtpDateSearch_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtpDateSearch.Text);
            dgvOrders.DataSource = handlerOrder.getOrderDateList(date, completed, collected);

            SetOrdersHeaders();
        }

        //Get order by date -- 'Today' button
        private void btnToday_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;

            try
            {
                dgvOrders.DataSource = handlerOrder.getOrderDateList(date, completed, collected);

                SetOrdersHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when searching orders!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }
        }

        //Notify Customer via Email
        private void EmailNotifyCustomer(int orderNumber, string emailAddress, string message)
        {
            List<string> to = new List<string>();

            to.Add(emailAddress);

            EmailNotification email = new EmailNotification(to, "Order Collection", message);

            try
            {
                email.SendMail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when sending Email!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }
        }

        //Notify Customer via SMS
        private void SMSNotifyCustomer(string number, int orderNumber, string message)
        {
            string smsCode = "";
            try
            {
                smsCode = SmsNotificaton.SendSms(number, message).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when sending SMS!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            if (smsCode != "")
            {
                if (smsCode != "0")
                {
                    if (MessageBox.Show("Error: " + smsCode + Environment.NewLine + Environment.NewLine +
                        "Please refere to the Red Oxygen website for details on the error." + Environment.NewLine + Environment.NewLine +
                        "Do you want to visit the website now?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://www.redoxygen.com/support/wiki/doku.php?id=red_api:errors");
                    }
                }
            }
        }

        //Notify Customer
        private void NotifyCustomer()
        {
            if (lblOrderNumber.Text != "")
            {
                int orderNumber = Convert.ToInt32(lblOrderNumber.Text);

                string message = "Your order (Order#: " + orderNumber.ToString() + ") is ready for collection at Photo Centre Uitenhage.";

                string email = "";
                string cellphone = "";
                string type = "";

                Customer customer = null;

                try
                {
                    customer = handlerCustomer.GetNotificationDetails(orderNumber);
                    type = customer.NotificationType;
                    email = customer.Email;
                    cellphone = customer.Cellphone;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not retrieve details to notify customer!" + Environment.NewLine +
                        Environment.NewLine + ex.Message);
                }

                if (type != "")
                {
                    if (type == "Email")
                    {
                        EmailNotifyCustomer(orderNumber, email, message);
                    }
                    else if (type == "SMS")
                    {
                        SMSNotifyCustomer(cellphone, orderNumber, message);
                    }
                }
            }
        }

        //Complete Order
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            bool completed = true;
            try
            {
                handlerOrder.CompleteOrder(selectedOrderNum);              
            }
            catch (Exception ex)
            {
                completed = false;
                MessageBox.Show("Error occured!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }

            if (completed == true)
            {
                dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells["Completed"].Value = true;

                btnCompleted.Enabled = false;

                NotifyCustomer();
            }
        }

        //Order has been collected
        private void btbCollected_Click(object sender, EventArgs e)
        {
            try
            {
                handlerOrder.CollectOrder(selectedOrderNum);

                dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells["Collected"].Value = true;

                btbCollected.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
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
                System.Diagnostics.Process.Start("Help\\Main.html");
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
            System.Diagnostics.Process.Start("Help\\Main.html");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCMS_About about = new PCMS_About();
            about.ShowDialog();
        }

        private void tbxOrderNumber_Enter(object sender, EventArgs e)
        {
            frmMain.ActiveForm.AcceptButton = btnOrderSearch;
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            frmMain.ActiveForm.AcceptButton = btnCustomerSearch;
        }

        private void tbxSurname_Enter(object sender, EventArgs e)
        {
            frmMain.ActiveForm.AcceptButton = btnCustomerSearch;
        }

        private void cbxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCompleted.Checked == true)
                completed = true;
            else
                completed = false;         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCollectedOrders.Checked == true)
                collected = true;
            else
                collected = false;
        }
    }
}
