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
using System.Text.RegularExpressions;

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
                BindData_Size_Grid();
                BindData_Medium_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured connecting to the database!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            try
            {
                BindData_Email();
                BindData_VAT();
                BindData_SMS();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when retrieving settings!" + Environment.NewLine +
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
        private bool AddSalesperson()
        {
            bool added = true;

            Salesperson salesperson = new Salesperson();
            salesperson.Name = tbxSalespersonName.Text;
            salesperson.Surname = tbxSalespersonSurname.Text;
            salesperson.Username = tbxUsername.Text;
            salesperson.Password = EncryptionHelper.Encrypt(tbxPassword.Text);
            salesperson.Privileges = cmbPrivileges.Text;
            salesperson.EmployeeType = cmbEmployeeType.Text;

            try
            {
                handlerSalesperson.AddSalesperson(salesperson);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Error occured when adding salesperson!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return added;
        }

        //Update Salesperson to Database
        private bool UpdateSalesperson()
        {
            bool updated = true;

            Salesperson salesperson = new Salesperson();
            salesperson.SalespersonID = Convert.ToInt32(dgvSalesperson.SelectedRows[0].Cells[0].Value.ToString());
            salesperson.Name = tbxSalespersonName.Text;
            salesperson.Surname = tbxSalespersonSurname.Text;
            salesperson.Username = tbxUsername.Text;
            salesperson.Password = EncryptionHelper.Encrypt(tbxPassword.Text);
            salesperson.Privileges = cmbPrivileges.Text;
            salesperson.EmployeeType = cmbEmployeeType.Text;

            try
            {
                handlerSalesperson.UpdateSalesperson(salesperson);
            }
            catch (Exception ex)
            {
                updated = false;
                MessageBox.Show("Error occured when updating salesperson!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return updated;
        }

        //Remove Salesperson
        private bool RemoveSalesperson(int salespersonID)
        {
            bool removed = true;

            if (MessageBox.Show("Are you sure you want to remove this salesperson?", "", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                try
                {
                    handlerSalesperson.RemoveSalesperson(salespersonID);
                }
                catch (Exception ex)
                {
                    removed = false;
                    MessageBox.Show("Error occured when trying to remove salesperson!" + Environment.NewLine +
                        Environment.NewLine + ex.Message);
                }
            }

            return removed;
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

                btnCancel.Visible = true;

                tbxSalespersonName.Focus();
            }
            else
            {
                if (ValidateSalespersonFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to add this salesperson?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool added = AddSalesperson();

                        if (added == true)
                        {
                            btnUpdateSalesperson.Enabled = true;
                            btnNewSalesperson.Text = "New Salesperson";
                            DisableSalespersonFields();

                            btnCancel.Visible = false;

                            MessageBox.Show("SAVED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                        }
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

                btnCancel.Visible = true;

                tbxSalespersonName.Focus();
            }
            else
            {
                if (ValidateSalespersonFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to update this salesperson?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool updated = UpdateSalesperson();

                        if (updated == true)
                        {
                            btnNewSalesperson.Enabled = true;
                            btnUpdateSalesperson.Text = "Update Salesperson";
                            DisableSalespersonFields();

                            btnCancel.Visible = false;

                            MessageBox.Show("UPDATED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        //Remove Salesperson
        private void btnRemoveSalesperson_Click(object sender, EventArgs e)
        {
            if (dgvSalesperson.SelectedRows.Count > 0)
            {
                bool removed = RemoveSalesperson(Convert.ToInt32(dgvSalesperson.SelectedRows[0].Cells[0].Value.ToString()));

                if (removed == true)
                {
                    MessageBox.Show("REMOVED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            tbxPostalCode.Text = company.PostalCode;
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
            company.PostalCode = tbxPostalCode.Text;
            company.Phone = tbxPhone.Text;
            company.Fax = tbxFax.Text;
            company.Email = tbxEmail.Text;
            company.RefundPeriod = Convert.ToInt32(numRefundPeriod.Value);

            if (ValidateCompanyFields() == true)
            {
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
        }

        //Validate Company Fields
        private bool ValidateCompanyFields()
        {
            bool valid = true;

            if (tbxBusinessName.Text == "" || tbxAddress1.Text == "" || tbxSuburb.Text == "" ||
                tbxCity.Text == "")
            {
                valid = false;
                MessageBox.Show("Please enter all required fields for business details!");
            }

            if (numRefundPeriod.Value < 0)
            {
                valid = false;
                MessageBox.Show("Refund period can't have a negative value!");
            }

            if (tbxEmail.Text != "")
            {
                /************************************************************************
                 *                       Code for email validation                      *
                 *                                                                      *
                 * http://net-informations.com/csprj/communications/validate-email.htm  *
                 *                                                                      *
                 * **********************************************************************/

                string pattern = null;
                pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (Regex.IsMatch(tbxEmail.Text, pattern))
                {
                    
                }
                else
                {
                    valid = false;
                    MessageBox.Show("Email address is invalid!");
                }
            }

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
                dgvPayment.DataSource = handlerPayment.GetAllPayments();        
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
        private bool AddPayment()
        {
            bool added = true;

            Payment payment = new Payment();
            payment.PaymentType = tbxDescription.Text;

            try
            {
                handlerPayment.AddPayment(payment);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Error occured when adding payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return added;
        }

        //Update Payment to Database
        private bool UpdatePayment()
        {
            bool updated = true;

            Payment payment = new Payment();
            payment.PaymentID = Convert.ToInt32(dgvPayment.SelectedRows[0].Cells[0].Value.ToString());
            payment.PaymentType = tbxDescription.Text;

            try
            {
                handlerPayment.UpdatePayment(payment);
            }
            catch (Exception ex)
            {
                updated = false;
                MessageBox.Show("Error occured when updating payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return updated;
        }

        //Remove Payment 
        private bool RemovePayment(int paymentID)
        {
            bool removed = true;

            try
            {
                handlerPayment.RemovePayment(paymentID);
            }
            catch (Exception ex)
            {
                removed = false;
                MessageBox.Show("Error occured when removing payment method!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return removed;
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

                btnCancel_Payments.Visible = true;

                tbxDescription.Focus();
            }
            else
            {
                if (tbxDescription.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to update this payment method?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool added = AddPayment();

                        if (added == true)
                        {
                            btnUpdatePayment.Enabled = true;
                            btnNewPayment.Text = "New Payment Method";
                            DisablePaymentFields();

                            btnCancel_Payments.Visible = false;

                            BindData_Payments();
                        }
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

                    btnCancel_Payments.Visible = true;

                    tbxDescription.Focus();
                }
                else
                {
                    if (tbxDescription.Text != "")
                    {
                        if (MessageBox.Show("Are you sure you want to update this payment method?", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            bool updated = UpdatePayment();

                            if (updated == true)
                            {
                                btnNewPayment.Enabled = true;
                                btnUpdatePayment.Text = "Update Payment Method";
                                DisablePaymentFields();

                                btnCancel_Payments.Visible = false;

                                BindData_Payments();
                            }
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
                    bool removed = RemovePayment(Convert.ToInt32(dgvPayment.SelectedRows[0].Cells[0].Value.ToString()));

                    if (removed == true)
                    {
                        BindData_Payments();
                    }
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
            cmbProductSize.Text = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
            cmbProductMedium.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
            tbxProductPrice.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
        }

        //Add Product to Database
        private bool AddProduct()
        {
            bool added = true;

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
                added = false;
                MessageBox.Show("Error occured when adding product!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return added;
        }

        //Update Product to Database
        private bool UpdateProduct(int productID)
        {
            bool updated = true;

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
                updated = false;
                MessageBox.Show("Error occured when updating product!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return updated;
        }

        //Remove Product 
        private bool RemoveProduct(int productID)
        {
            bool removed = true;

            try
            {
                handlerProduct.RemoveProduct(productID);
            }
            catch (Exception ex)
            {
                removed = false;
                MessageBox.Show("Error occured when removing product!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

            return removed;
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

            if (valid == false)
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
                    bool removed = RemoveProduct(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value.ToString()));

                    if (removed == true)
                    {
                        BindData_Product();
                    }
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
                EnableProductFields();

                btnCancel_Products.Visible = true;

                cmbProductSize.Focus();
            }
            else
            {
                if (ValidateProductFields() == true)
                {
                    if (MessageBox.Show("Are you sure you want to add this product?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool added = AddProduct();

                        if (added == true)
                        {
                            btnUpdateProduct.Enabled = true;
                            btnNewProduct.Text = "New Product";
                            DisableProductFields();

                            btnCancel_Products.Visible = false;

                            BindData_Product();
                        }                      
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

                    btnCancel_Products.Visible = true;

                    cmbProductSize.Focus();
                }
                else
                {
                    if (ValidateProductFields() == true)
                    {
                        if (MessageBox.Show("Are you sure you want to update this product?", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            bool updated = UpdateProduct(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value.ToString()));

                            if (updated == true)
                            {
                                btnNewProduct.Enabled = true;
                                btnUpdateProduct.Text = "Update Product";
                                DisableProductFields();

                                btnCancel_Products.Visible = false;

                                BindData_Product();
                            }
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
            if (dgvProducts.SelectedRows.Count > 0)
            {
                SelectProduct();
            }
        }


        #endregion

        #region Size
        //Bind Size Data
        private void BindData_Size_Grid()
        {
            dgvSize.DataSource = handlerSize.GetAllSizes();

            dgvSize.Columns[0].Visible = false;
            dgvSize.Columns[1].HeaderText = "Description";

        }

        //Add Size to Database
        private bool AddSize()
        {
            bool added = true;

            DAL.Size size = new DAL.Size();
            size.SizeDescription = tbxSize.Text;

            try
            {
                handlerSize.AddSize(size);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Error occured when adding size!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            return added;
        }

        //Remove Size
        private bool RemoveSize(int sizeID)
        {
            bool removed = true;

            try
            {
                handlerSize.RemoveSize(sizeID);
            }
            catch (Exception ex)
            {
                removed = false;
                MessageBox.Show("Error occured when removing size!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            return removed;
        }

        //New Size
        private void btnNewSize_Click(object sender, EventArgs e)
        {
            if (btnNewSize.Text == "New Size")
            {
                btnNewSize.Text = "Save";
                tbxSize.Clear();
                tbxSize.Enabled = true;

                tbxSize.Focus();
            }
            else
            {
                if (tbxSize.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to add this size?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool added = AddSize();

                        if (added == true)
                        {
                            btnNewSize.Text = "New Size";
                            tbxSize.Enabled = false;

                            BindData_Size_Grid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a description!");
                }
            }
        }

        //Remove Size
        private void btnRemoveSize_Click(object sender, EventArgs e)
        {
            if (dgvSize.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this size?", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    bool removed = RemoveSize(Convert.ToInt32(dgvSize.SelectedRows[0].Cells[0].Value.ToString()));

                    if (removed == true)
                    {
                        BindData_Size_Grid();
                    }
                }
            }
            else
            {
                MessageBox.Show("No size selected!");
            }
        }

        //Size Selected
        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSize.SelectedRows.Count > 0)
            {
                tbxSize.Text = dgvSize.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        #endregion

        #region Medium
        //Bind Medium Data
        private void BindData_Medium_Grid()
        {
            dgvMedium.DataSource = handlerMedium.GetAllMediums();

            dgvMedium.Columns[0].Visible = false;
            dgvMedium.Columns[1].HeaderText = "Description";


        }

        //Add Medium to Database
        private bool AddMedium()
        {
            bool added = true;

            Medium medium = new Medium();
            medium.Description = tbxMedium.Text;

            try
            {
                handlerMedium.AddMedium(medium);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Error occured when adding medium!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            return added;
        }
        
        //Remove Medium
        private bool RemoveMedium(int mediumID)
        {
            bool removed = true;

            try
            {
                handlerMedium.RemoveMedium(mediumID);
            }
            catch (Exception ex)
            {
                removed = false;
                MessageBox.Show("Error occured when removing medium!" + Environment.NewLine + Environment.NewLine +
                    ex.Message);
            }

            return removed;
        }

        //New Medium
        private void btnNewMedium_Click(object sender, EventArgs e)
        {
            if (btnNewMedium.Text == "New Medium")
            {
                btnNewMedium.Text = "Save";
                tbxMedium.Enabled = true;

                btnCancel_Medium.Visible = true;

                tbxMedium.Focus();
            }
            else
            {
                if (tbxMedium.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to add this size?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        bool added = AddMedium();

                        if (added == true)
                        {
                            btnNewMedium.Text = "New Medium";
                            tbxSize.Enabled = false;

                            btnCancel_Medium.Visible = false;

                            BindData_Medium_Grid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a description!");
                }
            }
        }

        //Remove Medium
        private void btnRemoveMedium_Click(object sender, EventArgs e)
        {
            if (dgvMedium.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this medium?", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    bool removed = RemoveMedium(Convert.ToInt32(dgvMedium.SelectedRows[0].Cells[0].Value.ToString()));

                    if (removed == true)
                    {
                        BindData_Medium_Grid();
                    }
                }
            }
            else
            {
                MessageBox.Show("No medium selected!");
            }
        }

        //Medium Selected
        private void dgvMedium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedium.SelectedRows.Count > 0)
            {
                tbxMedium.Text = dgvMedium.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        #endregion

        #region SMS Notification
        //Bind SMS Data
        private void BindData_SMS()
        {
            tbxAccountID.Text = ConfigurationManager.AppSettings["AccountID"];
            tbxSMSUserID.Text = ConfigurationManager.AppSettings["UserID"];
            tbxSMSPassword.Text = EncryptionHelper.Decrypt(ConfigurationManager.AppSettings["SmsPassword"]);
        }

        //Save SMS Settings
        private void SaveSMS()
        {
            if (ValidateSmsDetails() == true)
            {
                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["AccountID"].Value = tbxAccountID.Text;
                    config.AppSettings.Settings["UserID"].Value = tbxSMSUserID.Text;
                    config.AppSettings.Settings["SmsPassword"].Value = EncryptionHelper.Encrypt(tbxSMSPassword.Text);
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured when saving SMS settings!" + Environment.NewLine +
                        Environment.NewLine + ex.Message);
                }
            }
        }

        //Validate SMS Fields
        private bool ValidateSmsDetails()
        {
            bool valid = true;

            if (tbxAccountID.Text == "" || tbxSMSUserID.Text == "" || tbxSMSPassword.Text == "")
            {
                valid = true;
                MessageBox.Show("Please enter fields for SMS settings!");
            }

            return valid;
        }
        #endregion

        #region Email Notifications
        //Bind Email Data
        private void BindData_Email()
        {
            tbxEmailUsername.Text = ConfigurationManager.AppSettings["username"];
            tbxEmailPassword.Text = EncryptionHelper.Decrypt(ConfigurationManager.AppSettings["password"]);
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
        private void SaveEmail()
        {
            try
            {
                if (ValidateEmailFields() == true)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["username"].Value = tbxEmailUsername.Text;
                    config.AppSettings.Settings["password"].Value = EncryptionHelper.Encrypt(tbxEmailPassword.Text);
                    config.AppSettings.Settings["smtpAddress"].Value = tbxSMTP.Text;
                    config.AppSettings.Settings["portNumber"].Value = tbxEmailPort.Text;
                    config.AppSettings.Settings["enableSSL"].Value = cbxSSL.Checked.ToString();
                    
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when updating Email Notification details!" + Environment.NewLine +
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
        private void SaveVAT()
        {
            try
            {
                if (ValidateVAT() == true)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["VAT"].Value = tbxVAT.Text;
                    
                    config.Save(ConfigurationSaveMode.Modified);

                    ConfigurationManager.RefreshSection("appSettings");

                }
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
            SaveCompanyDetails();
            SaveVAT();

            if (cbxSystemSettings.Checked == true)
            {
                if (MessageBox.Show("Saving incorrect system settings may result in the system not working properly." + 
                    Environment.NewLine + "Are you sure you want to save these settings?", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    SaveSMS();
                    SaveEmail();
                }
            }

            MessageBox.Show("SAVED","", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void cbxSystemSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSystemSettings.Checked == true)
            {
                gbxSMS.Enabled = true;
                gbxEmail.Enabled = true;
            }
            else
            {
                gbxSMS.Enabled = false;
                gbxEmail.Enabled = false;
            }
        }

        //Cancel New/Update Salesperson
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewSalesperson.Text = "New Salesperson";
            btnNewSalesperson.Enabled = true;

            btnUpdateSalesperson.Text = "Update Salesperson";
            btnUpdateSalesperson.Enabled = true;

            btnCancel.Visible = false;

            DisableSalespersonFields();
            ClearSalespersonFields();
        }

        //Cancel New/Update Products
        private void btnCancel_Products_Click(object sender, EventArgs e)
        {
            btnNewProduct.Text = "New Product";
            btnNewProduct.Enabled = true;

            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.Enabled = true;

            btnCancel_Products.Visible = false;

            DisableProductFields();
            ClearProductFields();
        }

        //Cancel New/Update Payment Methods
        private void btnCancel_Payments_Click(object sender, EventArgs e)
        {
            btnNewPayment.Text = "New Payment Method";
            btnNewPayment.Enabled = true;

            btnUpdatePayment.Text = "Update Payment Method";
            btnUpdatePayment.Enabled = true;

            btnCancel_Payments.Visible = false;

            DisablePaymentFields();
            ClearPaymentFields();
        }

        //Cancel New Medium
        private void btnCancel_Medium_Click(object sender, EventArgs e)
        {
            btnNewMedium.Text = "New Medium";
            btnNewMedium.Enabled = true;

            btnCancel_Medium.Visible = false;

            tbxMedium.Enabled = false;
            tbxMedium.Clear();
        }

        //Cancel New Size
        private void btnCancel_Size_Click(object sender, EventArgs e)
        {
            btnNewSize.Text = "New Size";
            btnNewSize.Enabled = true;

            btnCancel_Size.Visible = false;

            tbxSize.Enabled = false;
            tbxSize.Clear();
        }
    }
}
