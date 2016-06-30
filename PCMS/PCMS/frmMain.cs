﻿using System;
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

namespace PCMS
{
    public partial class frmMain : MetroForm 
    {
        private IHandler_Order handlerOrder = null;
        private IHandler_OrderLine handlerOrderLines = null;

        int salespersonID;
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

        //Bind orders to orders grid...
        private void BindData_Orders()
        {
            dgvOrders.DataSource = handlerOrder.GetAllOrders();
        }

        //Bind order lines to order lines grid...
        private void BindData_OrderLines(int orderNumber)
        {
            dgvOrderLines.DataSource = handlerOrderLines.GetOrderLines(orderNumber);
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
            int rowIndex = dgvOrders.SelectedRows[0].Index;

            int orderNumber = Convert.ToInt32(dgvOrders.Rows[rowIndex].Cells[0].Value.ToString());

            //Display all items in the order
            handlerOrderLines = new Handler_OrderLine();
            BindData_OrderLines(orderNumber);

            //Display order details 
            lblOrderNumber.Text = dgvOrders.Rows[rowIndex].Cells[0].Value.ToString();
            lblCustomer.Text = dgvOrders.Rows[rowIndex].Cells[7].Value.ToString();
            lblDate.Text = dgvOrders.Rows[rowIndex].Cells[3].Value.ToString();
            lblTime.Text = dgvOrders.Rows[rowIndex].Cells[4].Value.ToString();
            lblCompletion.Text = dgvOrders.Rows[rowIndex].Cells[5].Value.ToString();
            lblCollection.Text = dgvOrders.Rows[rowIndex].Cells[6].Value.ToString();
            lblSalesperson.Text = dgvOrders.Rows[rowIndex].Cells[2].Value.ToString();
        }

        //Log out as the current user...
        private void tileLogout_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            IHandler_Main handlerMain = new Handler_Main();
            int OrderNum = int.Parse(tbxOrderNumber.ToString());
            dgvOrders.DataSource = handlerMain.getOrderList(OrderNum);
        }
    }
}
