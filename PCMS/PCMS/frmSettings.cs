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

namespace PCMS
{
    public partial class frmSettings : MetroForm 
    {
        //BLL Access
        private IHandler_Salesperson handlerSalesperson = null;
        private IHandler_Payment handlerPayment = null;
        private IHandler_Company handlerCompany = null;
        private IHandler_Product handlerProduct = null;

        //Passed Variables


        //This Variables



        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            handlerSalesperson = new Handler_Salesperson();
            handlerPayment = new Handler_Payment();
            handlerCompany = new Handler_Company();
            handlerProduct = new Handler_Product();

            BindData_Payments();
        }

        #region Salesperson

        //Clear Fields for Salesperson
        private void ClearSalespersonFields()
        {
            tbxSalespersonName.Clear();
            tbxSalespersonSurname.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
            tbxPassword2.Clear();
            cmbPrivileges.SelectedIndex = 0;
            cmbEmployeeType.SelectedIndex = 0;
        }

        //Enable Fields for Salesperson
        private void EnableSalespersonFields()
        {
            tbxSalespersonName.Enabled = true;
            tbxSalespersonSurname.Enabled = true;
            tbxUsername.Enabled = true;
            tbxPassword.Enabled = true;
            tbxPassword2.Enabled = true;
            cmbPrivileges.Enabled = true;
            cmbEmployeeType.Enabled = true;
        }

        //Disable Fields for Salesperson
        private void DisableSalespersonFields()
        {
            tbxSalespersonName.Enabled = false;
            tbxSalespersonSurname.Enabled = false;
            tbxUsername.Enabled = false;
            tbxPassword.Enabled = false;
            tbxPassword2.Enabled = false;
            cmbPrivileges.Enabled = false;
            cmbEmployeeType.Enabled = false;
        }

        //Salesperson Grid Format
        private void FormatSalespersonGrid()
        {
            dgvSalesperson.Columns[0].Visible = false;
            dgvSalesperson.Columns[4].Visible = false;

            dgvSalesperson.Columns[1].HeaderText = "Name";
            dgvSalesperson.Columns[2].HeaderText = "Surname";
            dgvSalesperson.Columns[3].HeaderText = "Username";
            dgvSalesperson.Columns[5].HeaderText = "Privileges";
            dgvSalesperson.Columns[6].HeaderText = "Employee Type";
        }

        //Search Salesperson
        private void SearchSalesperson(string name, string surname)
        {
            try
            {
                dgvSalesperson.DataSource = handlerSalesperson.SearchSalesperson(name, surname);
                FormatSalespersonGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when searching for customer!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Salesperson Selected
        private void SelectSaleperson()
        {
            int index = dgvSalesperson.SelectedRows[0].Index;

            tbxSalespersonName.Text = dgvSalesperson.Rows[index].Cells[1].Value.ToString();
            tbxSalespersonSurname.Text = dgvSalesperson.Rows[index].Cells[2].Value.ToString();
            tbxUsername.Text = dgvSalesperson.Rows[index].Cells[3].Value.ToString();
            tbxPassword.Text = dgvSalesperson.Rows[index].Cells[4].Value.ToString();
            tbxPassword2.Text = dgvSalesperson.Rows[index].Cells[4].Value.ToString();
            cmbPrivileges.Text = dgvSalesperson.Rows[index].Cells[5].Value.ToString();
            cmbEmployeeType.Text = dgvSalesperson.Rows[index].Cells[6].Value.ToString();
        }

        //Add Salesperson to Database
        private void AddSalesperson()
        {
            Salesperson salesperson = new Salesperson();
            salesperson.Name = tbxSalespersonName.Text;
            salesperson.Surname = tbxSalespersonSurname.Text;
            salesperson.Username = tbxUsername.Text;
            salesperson.Password = tbxPassword.Text;
            salesperson.Privileges = cmbPrivileges.Text;
            salesperson.EmployeeType = cmbEmployeeType.Text;

            try
            {
                handlerSalesperson.AddSalesperson(salesperson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when adding salesperson!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Update Salesperson to Database
        private void UpdateSalesperson()
        {
            Salesperson salesperson = new Salesperson();
            salesperson.SalespersonID = Convert.ToInt32(dgvSalesperson.SelectedRows[0].Cells[0].Value.ToString());
            salesperson.Name = tbxSalespersonName.Text;
            salesperson.Surname = tbxSalespersonSurname.Text;
            salesperson.Username = tbxUsername.Text;
            salesperson.Password = tbxPassword.Text;
            salesperson.Privileges = cmbPrivileges.Text;
            salesperson.EmployeeType = cmbEmployeeType.Text;

            try
            {
                handlerSalesperson.UpdateSalesperson(salesperson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating salesperson!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Remvoe Salesperson
        private void RemoveSalesperson(int salespersonID)
        {
            if (MessageBox.Show("Are you sure you want to remove this salesperson?", "", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                try
                {
                    handlerSalesperson.RemoveSalesperson(salespersonID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured when trying to remove salesperson!" + Environment.NewLine +
                        Environment.NewLine + ex.Message);
                }
            }
        }

        //Validate Salesperson Fields
        private bool ValidateSalespersonFields()
        {
            bool valid = true;
            string errorMessage = "";

            if (tbxSalespersonName.Text == "" || tbxSalespersonSurname.Text == "" || tbxUsername.Text == "" ||
                tbxPassword.Text == "" || tbxPassword2.Text == "")
            {
                valid = false;
                errorMessage += "Please fill all the fields!" + Environment.NewLine;
            }

            if (tbxPassword.Text.Length < 6)
            {
                valid = false;
                errorMessage += "Password needs to be 6 characters or more!" + Environment.NewLine;
            }
            else if (tbxPassword.Text != tbxPassword2.Text)
            {
                valid = false;
                errorMessage += "Password fields does not match!" + Environment.NewLine;
            }

            if (valid == false)
            {
                MessageBox.Show(errorMessage);
            }

            return valid;
        }

        //Search Salesperson
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxSurname.Text == "")
            {
                MessageBox.Show("Please enter both the name and surname of the salesperson you are searching!");
            }
            else
            {
                SearchSalesperson(tbxName.Text, tbxSurname.Text);
            }
        }

        //Salesperson Selected
        private void dgvSalesperson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalesperson.SelectedRows.Count > 0)
                SelectSaleperson();
            
        }

        //Add Salesperson
        private void btnNewSalesperson_Click(object sender, EventArgs e)
        {
            if (btnNewSalesperson.Text == "New Salesperson")
            {
                btnUpdateSalesperson.Enabled = false;
                btnNewSalesperson.Text = "Save";
                ClearSalespersonFields();
                EnableSalespersonFields();

                tbxSalespersonName.Focus();
            }
            else
            {
                if (ValidateSalespersonFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to add this salesperson?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        AddSalesperson();

                        btnUpdateSalesperson.Enabled = true;
                        btnNewSalesperson.Text = "New Salesperson";
                        DisableSalespersonFields();                     
                    }
                }
            }
        }

        //Update Salesperson
        private void btnUpdateSalesperson_Click(object sender, EventArgs e)
        {
            if (btnUpdateSalesperson.Text == "Update Salesperson")
            {
                btnNewSalesperson.Enabled = false;
                btnUpdateSalesperson.Text = "Save";
                EnableSalespersonFields();

                tbxSalespersonName.Focus();
            }
            else
            {
                if (ValidateSalespersonFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to update this salesperson?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        UpdateSalesperson();

                        btnNewSalesperson.Enabled = true;
                        btnUpdateSalesperson.Text = "Update Salesperson";
                        DisableSalespersonFields();
                    }
                }
            }
        }

        //Remove Salesperson
        private void btnRemoveSalesperson_Click(object sender, EventArgs e)
        {
            if (dgvSalesperson.SelectedRows.Count > 0)
            {
                RemoveSalesperson(Convert.ToInt32(dgvSalesperson.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }
        #endregion

        #region Company

        #endregion

        #region Payments
        //Format Payments Grid
        private void FormatPaymentGrid()
        {
            dgvPayment.Columns[0].HeaderText = "ID";
            dgvPayment.Columns[1].HeaderText = "Description";
        }

        //Bind Payments
        private void BindData_Payments()
        {
            try
            {
                dgvPayment.DataSource = handlerPayment.GetAllPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured connecting to database!");
                this.Close();
            }
        }

        //Enable Payment Fields()
        private void EnablePaymentFields()
        {
            tbxDescription.Enabled = true;
        }

        //Disable Payment Fields()
        private void DisablePaymentFields()
        {
            tbxDescription.Enabled = false;
        }

        //Clear Payment Fields()
        private void ClearPaymentFields()
        {
            tbxDescription.Clear();
        }

        //Add Payment to Database
        private void AddPayment()
        {
            Payment payment = new Payment();
            payment.PaymentType = tbxDescription.Text;

            try
            {
                handlerPayment.AddPayment(payment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when adding payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Update Payment to Database
        private void UpdatePayment()
        {
            Payment payment = new Payment();
            payment.PaymentID = Convert.ToInt32(dgvPayment.SelectedRows[0].Cells[0].Value.ToString());
            payment.PaymentType = tbxDescription.Text;

            try
            {
                handlerPayment.UpdatePayment(payment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Remove Payment 
        private void RemovePayment(int paymentID)
        {
            try
            {
                handlerPayment.RemovePayment(paymentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when removing payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Add payment Method
        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            if (btnNewPayment.Text == "New Payment Method")
            {
                btnUpdatePayment.Enabled = false;
                btnNewPayment.Text = "Save";
                ClearPaymentFields();
                EnablePaymentFields();

                tbxDescription.Focus();
            }
            else
            {
                if (tbxDescription.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to update this payment method?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        AddPayment();

                        btnUpdatePayment.Enabled = true;
                        btnNewPayment.Text = "New Payment Method";
                        DisablePaymentFields();

                        BindData_Payments();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a description!");
                }
            }
        }

        //Update payment Method
        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                if (btnUpdatePayment. Text == "Update Payment Method")
                {
                    btnNewPayment.Enabled = false;
                    btnUpdatePayment.Text = "Save";
                    EnablePaymentFields();

                    tbxDescription.Focus();
                }
                else
                {
                    if (tbxDescription.Text != "")
                    {
                        if (MessageBox.Show("Are you sure you want to update this payment method?", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            UpdatePayment();

                            btnNewPayment.Enabled = true;
                            btnUpdatePayment.Text = "Update Payment Method";
                            DisablePaymentFields();

                            BindData_Payments();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a description!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No payment method selected!");
            }
        }

        //Remove Payment Method
        private void btnRemovePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this payment method", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    RemovePayment(Convert.ToInt32(dgvPayment.SelectedRows[0].Cells[0].Value.ToString()));

                    BindData_Payments();
                }
            }
        }

        //Payment Selected
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                tbxDescription.Text = dgvPayment.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        #endregion

        #region Products

        #endregion


    }
}
