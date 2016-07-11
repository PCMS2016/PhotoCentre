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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string username = tbxUsername.Text;
            string password = handlerLogin.Encrypt(tbxPassword.Text);

            Salesperson salesperson = new Salesperson();
            salesperson.Username = username;
            salesperson.Password = password;

            //Retrieve details from database matching the username and password...

                handlerLogin.Login(salesperson);

                //Check if the login details are valid...
                if (salesperson.Name != null)
                {
                    frmMain Main = new frmMain(salesperson.SalespersonID, salesperson.Name + " " + salesperson.Surname, salesperson.Privileges, salesperson.EmployeeType);
                    Main.ShowDialog();

                    //Clear textboxes and set focus on username textbox...
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                    lblError.Text = "";
                    tbxUsername.Focus();
                }
                else
                {
                    //Display error message for invalid login details...
                    lblError.Text = "*Invalid Login Details";
                }

        }

        
    }
}
