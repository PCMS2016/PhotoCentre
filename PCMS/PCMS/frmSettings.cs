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
using System.Configuration;

namespace PCMS
{
    public partial class frmSettings : MetroForm
    {
        //BLL Access
        private IHandler_Salesperson handlerSalesperson = null;
        private IHandler_Payment handlerPayment = null;
        private IHandler_Company handlerCompany = null;
        private IHandler_Product handlerProduct = null;
        private IHandler_Size handlerSize = null;
        private IHandler_Medium handlerMedium = null;

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
            handlerSize = new Handler_Size();
            handlerMedium = new Handler_Medium();

            try
            {
                BindData_Payments();
                BindData_Size();
                BindData_Medium();
                BindData_Product();
                BindData_Company();
                BindData_Database();
                BindData_Email();
                BindData_VAT();
                BindData_SMS();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured connecting to the database!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
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
        //Bind Company Details
        private void BindData_Company()
        {
            Company company = handlerCompany.GetCompanyDetails();
            tbxBusinessName.Text = company.Name;
            tbxAddress1.Text = company.Address1;
            tbxAddress2.Text = company.Address2;
            tbxSuburb.Text = company.Suburb;
            tbxCity.Text = company.City;
            tbxPhone.Text = company.Phone;
            tbxFax.Text = company.Fax;
            tbxEmail.Text = company.Email;
            numRefundPeriod.Value = Convert.ToInt32(company.RefundPeriod.ToString());
        }

        //Save Company Details
        private void SaveCompanyDetails()
        {
            Company company = new Company();
            company.Name = tbxBusinessName.Text;
            company.Address1 = tbxAddress1.Text;
            company.Address2 = tbxAddress2.Text;
            company.Suburb = tbxSuburb.Text;
            company.City = tbxCity.Text;
            company.Phone = tbxPhone.Text;
            company.Fax = tbxFax.Text;
            company.Email = tbxEmail.Text;
            company.RefundPeriod = Convert.ToInt32(numRefundPeriod.Value);

            try
            {
                handlerCompany.UpdateCompany(company);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when saving business settings!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Validate Company Fields
        private bool ValidateCompanyFields()
        {
            bool valid = true;

            return valid;
        }

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
                if (btnUpdatePayment.Text == "Update Payment Method")
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

        //Bind Size
        private void BindData_Size()
        {
            cmbProductSize.DataSource = handlerSize.GetAllSizes();
            cmbProductSize.DisplayMember = "SizeDescription";
            cmbProductSize.ValueMember = "SizeID";
        }

        //Bind Medium
        private void BindData_Medium()
        {
            cmbProductMedium.DataSource = handlerMedium.GetAllMediums();
            cmbProductMedium.DisplayMember = "Description";
            cmbProductMedium.ValueMember = "MediumID";
        }

        //Bind Products
        private void BindData_Product()
        {
            dgvProducts.DataSource = handlerProduct.GetAllProductsIndividualFields();

            FormatProductsGrid();
        }

        //Format Products Grid
        private void FormatProductsGrid()
        {
            dgvProducts.Columns[0].Visible = false;
            dgvProducts.Columns[1].Visible = false;

            dgvProducts.Columns[2].HeaderText = "Size";
            dgvProducts.Columns[3].HeaderText = "Medium";
            dgvProducts.Columns[4].HeaderText = "Price";

            dgvProducts.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[4].DefaultCellStyle.Format = "C";
        }

        //Clear Product Fields
        private void ClearProductFields()
        {
            cmbProductSize.SelectedIndex = 0;
            cmbProductMedium.SelectedIndex = 0;
            tbxProductPrice.Clear();
        }

        //Enable Product Fields
        private void EnableProductFields()
        {
            cmbProductSize.Enabled = true;
            cmbProductMedium.Enabled = true;
            tbxProductPrice.Enabled = true;
        }

        //Disable Product Fields
        private void DisableProductFields()
        {
            cmbProductSize.Enabled = false;
            cmbProductMedium.Enabled = false;
            tbxProductPrice.Enabled = false;
        }

        //Select Product
        private void SelectProduct()
        {

        }

        //Add Product to Database
        private void AddProduct()
        {
            SizeMedium product = new SizeMedium();
            product.Size = cmbProductSize.SelectedValue.ToString();
            product.Medium = cmbProductMedium.SelectedValue.ToString();
            product.Price = Convert.ToDouble(tbxProductPrice.Text);

            try
            {
                handlerProduct.AddProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when adding product!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Update Product to Database
        private void UpdateProduct(int productID)
        {
            SizeMedium product = new SizeMedium();
            product.SizeMediumID = productID;
            product.Size = cmbProductSize.SelectedValue.ToString();
            product.Medium = cmbProductMedium.SelectedValue.ToString();

            try
            {
                handlerProduct.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating product!" + Environment.NewLine +
                    Environment.NewLine);
            }
        }

        //Remove Product 
        private void RemoveProduct(int productID)
        {
            try
            {
                handlerProduct.RemoveProduct(productID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when removing product!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Validate Product Fields
        private bool ValidateProductFields()
        {
            bool valid = true;
            double price;

            if (double.TryParse(tbxProductPrice.Text, out price) == false || tbxProductPrice.Text == "")
            {
                valid = false;
            }

            if (valid = false)
            {
                MessageBox.Show("Price is invalid!");
            }

            return valid;
        }

        //Remove Product
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this product?", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    RemoveProduct(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value.ToString()));
                }
            }
            else
            {
                MessageBox.Show("No product selected!");
            }
        }

        //Add product
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if (btnNewProduct.Text == "New Product")
            {
                btnUpdateProduct.Enabled = false;
                btnNewProduct.Text = "Save";
                ClearPaymentFields();
                EnablePaymentFields();

                cmbProductSize.Focus();
            }
            else
            {
                if (ValidateProductFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to add this product?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        AddProduct();

                        btnUpdateProduct.Enabled = true;
                        btnNewProduct.Text = "New Product";
                        DisableProductFields();                        
                    }
                }
            }
        }

        //Update Product
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                if (btnUpdateProduct.Text == "Update Product") 
                {
                    btnNewProduct.Enabled = false;
                    btnUpdateProduct.Text = "Save";
                    EnableProductFields();

                    cmbProductSize.Focus();
                }
                else
                {
                    if (ValidateProductFields() == true)
                    {
                        if (MessageBox.Show("Are you sure you want to update this product?", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            UpdateProduct(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value.ToString()));

                            btnNewProduct.Enabled = true;
                            btnUpdateProduct.Text = "Update Product";
                            DisableProductFields();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No product selected!");
            }
        }

        //Product Selected
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        #endregion

        #region SMS Notification
        //Bind SMS Data
        private void BindData_SMS()
        {
            tbxAccountID.Text = ConfigurationManager.AppSettings["AccountID"];
            tbxSMSUserID.Text = ConfigurationManager.AppSettings["UserID"];
            tbxSMSPassword.Text = ConfigurationManager.AppSettings["SmsPassword"];
        }
        #endregion

        #region Email Notifications
        //Bind Email Data
        private void BindData_Email()
        {
            tbxEmailUsername.Text = ConfigurationManager.AppSettings["username"];
            tbxEmailPassword.Text = ConfigurationManager.AppSettings["password"];
            tbxSMTP.Text = ConfigurationManager.AppSettings["smtpAddress"];
            tbxEmailPort.Text = ConfigurationManager.AppSettings["portNumber"];
            cbxSSL.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSSL"]);
        }

        //Validate Email Fields
        private bool ValidateEmailFields()
        {
            bool valid = true;

            if (tbxEmailUsername.Text == "" || tbxEmailPassword.Text == "" || tbxSMTP.Text == "" || tbxEmailPort.Text == "")
            {
                valid = false;
                MessageBox.Show("Please enter all the details for email notification");
            }

            return valid;
        }

        //Update Email Data
        private void UpdateEmail()
        {
            try
            {
                if (ValidateEmailFields() == true)
                {
                    ConfigurationManager.AppSettings["username"] = tbxEmailUsername.Text;
                    ConfigurationManager.AppSettings["password"] = tbxEmailPassword.Text;
                    ConfigurationManager.AppSettings["smtpAddress"] = tbxSMTP.Text;
                    ConfigurationManager.AppSettings["portNumber"] = tbxEmailPort.Text;
                    ConfigurationManager.AppSettings["enableSSL"] = cbxSSL.Checked.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating Email Notification details!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region Database
        //Bind Database Data
        private void BindData_Database()
        {
            string conString = ConfigurationManager.ConnectionStrings["PCMS_Server"].ConnectionString;

            string[] temp = conString.Split(';');

            tbxServer.Text = temp[0].Substring(12);

            tbxDatabase.Text = temp[1].Substring(17);

            tbxUserID.Text = temp[2].Substring(9);

            tbxDatabasePassword.Text = temp[3].Substring(10);
        }

        //Validate Database Fields
        private bool ValidateDatabaseFields()
        {
            bool valid = true;

            if (tbxServer.Text == "" || tbxDatabase.Text == "" || tbxUserID.Text == "" || tbxDatabasePassword.Text == "")
            {
                valid = false;
                MessageBox.Show("Please enter all details for the database connection!");
            }

            return valid;
        }

        //Update Database String
        private void UpdateDatabaseString()
        {
            try
            {
                if (ValidateDatabaseFields() == true)
                {
                    string conString = "Data Source=" + tbxServer.Text + "; Initial Catalog=" + tbxDatabase.Text +
                        "; User ID=" + tbxUserID.Text + "; Password=" + tbxDatabasePassword.Text;
                    MessageBox.Show(conString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating database connection details!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region VAT
        //Bind VAT value
        private void BindData_VAT()
        {
            tbxVAT.Text = ConfigurationManager.AppSettings["VAT"];
        }

        //Validate VAT
        private bool ValidateVAT()
        {
            bool valid = true;
            double vat;

            if (tbxVAT.Text == "")
            {
                valid = false;
                MessageBox.Show("Please enter a VAT %!");
            }
            else if (double.TryParse(tbxVAT.Text, out vat) == false)
            {
                valid = false;
                MessageBox.Show("VAT amount entered is invalid!");
            }

            return valid;
        }

        //Update VAT
        private void UpdateVAT()
        {
            try
            {
                if (ValidateVAT() == true)
                    ConfigurationManager.AppSettings["VAT"] = tbxVAT.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured updating VAT %" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }
        }
        #endregion

        private void btnBusinessSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(SmsNotificaton.SendSms("0832842708", "Second test message").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending sms" + Environment.NewLine + ex.Message);
            }
        }
    }
}
