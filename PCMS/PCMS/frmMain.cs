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

namespace PCMS
{
    public partial class frmMain : MetroForm 
    {
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

        private void tileNewOrder_Click(object sender, EventArgs e)
        {
            frmOrder Order = new frmOrder(salespersonID);
            Order.ShowDialog();
        }

        private void tileRefund_Click(object sender, EventArgs e)
        {
            frmRefund Refund = new frmRefund();
            Refund.ShowDialog();
        }

        private void tileReports_Click(object sender, EventArgs e)
        {
            frmReports Reports = new frmReports();
            Reports.ShowDialog();
        }

        private void tileSettings_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();
            Settings.ShowDialog();
        }

        private void tileSpecials_Click(object sender, EventArgs e)
        {
            frmSpecials Specials = new frmSpecials();
            Specials.ShowDialog();
        }

        private void tileLogout_Click_1(object sender, EventArgs e)
        {
            
        }
        public void BindData()
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
