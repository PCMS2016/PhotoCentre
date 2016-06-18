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
    public partial class frmLogin : MetroForm
    {
        private IHandler_Login handlerLogin = null;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            handlerLogin = new Handler_Login();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            Salesperson salesperson = new Salesperson();
            salesperson.Username = username;
            salesperson.Password = password;

            handlerLogin.Login(salesperson);

            if (salesperson.Name != null)
            {
                frmMain Main = new frmMain(salesperson.SalespersonID, salesperson.Name + " " + salesperson.Surname, salesperson.Privileges, salesperson.EmployeeType);
                Main.ShowDialog();
            }
            else
            {
                lblError.Text = "*Invalid Login Details";
            }
        }

        
    }
}
