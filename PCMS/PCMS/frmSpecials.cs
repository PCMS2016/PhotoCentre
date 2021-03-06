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
using DAL;
using BLL;

namespace PCMS
{
    public partial class frmSpecials : MetroForm 
    {
        //BLL Access
        private IHandler_Special handlerSpecial = null;
        private IHandler_Product handlerProduct = null;

        //Passed Variables
        private string employeeType;
        
        //This Variables

        //Bind products to ComboBox
        private void BindData_Product()
        {
            cmbProduct.DataSource = handlerProduct.GetAllProducts();
            cmbProduct.DisplayMember = "Product";
            cmbProduct.ValueMember = "SizeMediumID";

            cmbProductSearch.DataSource = handlerProduct.GetAllProducts();
            cmbProductSearch.DisplayMember = "Product";
            cmbProductSearch.ValueMember = "SizeMediumID";
        }

        //Clear Fields for Editing
        private void ClearFields()
        {
            cmbProduct.SelectedIndex = 0;
            tbxPrice.Clear();
            numQuantity.Value = 0;

            DateTime date = DateTime.Now;
            dtpStartDate.Value = date;

            date = date.AddDays(1);
            dtpEndDate.Value = date;
        }

        //Enable Fields for Editing
        private void EnableFields()
        {
            cmbProduct.Enabled = true;
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            tbxPrice.Enabled = true;
            numQuantity.Enabled = true;
        }

        //Disable Fields for Editing
        private void DisableFields()
        {
            cmbProduct.Enabled = false;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            tbxPrice.Enabled = false;
            numQuantity.Enabled = false;
        }

        //Format DataGridView
        private void FormatGrid()
        {
            dgvSpecials.Columns[0].Visible = false;

            dgvSpecials.Columns[1].HeaderText = "Product";
            dgvSpecials.Columns[2].HeaderText = "Quantity";
            dgvSpecials.Columns[3].HeaderText = "Price";
            dgvSpecials.Columns[4].HeaderText = "Start Date";
            dgvSpecials.Columns[5].HeaderText = "End Date";

            dgvSpecials.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSpecials.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSpecials.Columns[3].DefaultCellStyle.Format = "C";
        }

        //Search Specials by Product
        private void SpecialSearchByProduct(int productID)
        {
            try
            {
                dgvSpecials.DataSource = handlerSpecial.GetSpecialsByProduct(productID);
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when searching specials!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        //Search Specials by Date
        private void SpecialSearchByDate(DateTime date)
        {
            try
            {
                dgvSpecials.DataSource = handlerSpecial.GetSpecialsByDate(date);
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when searching specials!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }

        }

        //Add Special to Database
        private bool AddSpecial()
        {
            bool added = true;

            Special special = new Special();
            special.Product = cmbProduct.SelectedValue.ToString();
            special.Price = Convert.ToDouble(tbxPrice.Text);
            special.StartDate = dtpStartDate.Value;
            special.EndDate = dtpEndDate.Value;
            special.Quantity = Convert.ToInt32(numQuantity.Value.ToString());

            try
            {
                handlerSpecial.AddSpecial(special);
            }
            catch (Exception ex)
            {
                added = false;
                MessageBox.Show("Error occured when saving special!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
            return added;
        }

        //Update Special to Database
        private bool UpdateSpecial()
        {
            bool updated = true;

            Special special = new Special();
            special.SpecialID = Convert.ToInt32(dgvSpecials.Rows[Convert.ToInt32(dgvSpecials.SelectedRows[0].Index.ToString())].Cells[0].ToString());
            special.Product = cmbProduct.SelectedValue.ToString();
            special.Price = Convert.ToDouble(tbxPrice.Text);
            special.StartDate = dtpStartDate.Value;
            special.EndDate = dtpEndDate.Value;
            special.Quantity = Convert.ToInt32(numQuantity.Value.ToString());

            try
            {
                handlerSpecial.UpdateSpecial(special);
            }
            catch (Exception ex)
            {
                updated = false;
                MessageBox.Show("Error occured when updating special!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
            return updated;
        }

        //Validate Fields
        private bool ValidateFields()
        {
            tbxPrice.Text = tbxPrice.Text.Replace('.', ',');

            string errorMessage = "";
            bool valid = true;
            double price;

            if (tbxPrice.Text == "" || double.TryParse(tbxPrice.Text, out price) == false)
            {
                valid = false;
                errorMessage += "Price is invalid" + Environment.NewLine;
            }

            if (numQuantity.Value < 1)
            {
                valid = false;
                errorMessage += "Quantity needs to be more than 0" + Environment.NewLine;
            }

            if (dtpStartDate.Value < DateTime.Now.AddDays(-1))
            {
                valid = false;
                errorMessage += "Start date can't be in the past" + Environment.NewLine;
            }

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                valid = false;
                errorMessage += "End date can't be befor the start date" + Environment.NewLine;
            }

            if (valid == false)
                MessageBox.Show(errorMessage);

            return valid;
        }

        //Select Special
        private void SelectSpecial()
        {
            int index = dgvSpecials.SelectedRows[0].Index;

            cmbProduct.Text = dgvSpecials.Rows[index].Cells[1].Value.ToString() + " - " + string.Format("{0:c}", double.Parse(dgvSpecials.Rows[index].Cells[3].Value.ToString()));
            cmbProductSearch.Text = dgvSpecials.Rows[index].Cells[1].Value.ToString() + " - " + string.Format("{0:c}", double.Parse(dgvSpecials.Rows[index].Cells[3].Value.ToString()));
            numQuantity.Value = Convert.ToInt32(dgvSpecials.Rows[index].Cells[2].Value.ToString());
            tbxPrice.Text = string.Format("{0:f2}", double.Parse(dgvSpecials.Rows[index].Cells[3].Value.ToString()));
            dtpStartDate.Text = dgvSpecials.Rows[index].Cells[4].Value.ToString();
            dtpEndDate.Text = dgvSpecials.Rows[index].Cells[5].Value.ToString();
        }

        public frmSpecials(string employeeType)
        {
            InitializeComponent();
            this.employeeType = employeeType;
        }

        //Form Loads...
        private void frmSpecials_Load(object sender, EventArgs e)
        {
            //BLL Access
            handlerSpecial = new Handler_Special();
            handlerProduct = new Handler_Product();

            //Bind Data
            try
            {
                BindData_Product();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when connecting to the database!" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
                this.Close();
            }

            SpecialSearchByDate(DateTime.Now);

            //Focus control
            cmbProduct.Focus();

            if (employeeType != "Admin")
            {
                btnSpecialNew.Enabled = false;
                btnSpecialUpdate.Enabled = false;
                btnSpecialNotify.Enabled = false;
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Add new special
        private void btnSpecialNew_Click(object sender, EventArgs e)
        {
            if (btnSpecialNew.Text == "New Special")
            {
                btnSpecialUpdate.Enabled = false;
                btnSpecialNew.Text = "Save";
                ClearFields();
                EnableFields();

                btnCancel.Visible = true;

                cmbProduct.Focus();
            }
            else
            {
                if (ValidateFields() == true)
                {
                    if (MessageBox.Show("Are you sure youwant to add this special?", "", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        if (AddSpecial() == true)
                        {
                            btnSpecialUpdate.Enabled = true;
                            btnSpecialNew.Text = "New Special";
                            DisableFields();

                            btnCancel.Visible = false;

                            MessageBox.Show("SAVED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        //Update a special
        private void btnSpecialUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSpecials.SelectedRows.Count > 0)
            {
                if (btnSpecialUpdate.Text == "Update Special")
                {
                    btnSpecialNew.Enabled = false;
                    btnSpecialUpdate.Text = "Save";
                    EnableFields();

                    btnCancel.Visible = true;

                    cmbProduct.Focus();
                }
                else
                {
                    if (ValidateFields() == true)
                    {
                        if (MessageBox.Show("Are you sure you want to update this special?", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            if (UpdateSpecial() == true)
                            {
                                btnSpecialNew.Enabled = true;
                                btnSpecialUpdate.Text = "Update Special";
                                DisableFields();

                                btnCancel.Visible = false;

                                MessageBox.Show("SAVED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        //Order Selected
        private void dgvSpecials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSpecials.Rows.Count > 0)
            {
                SelectSpecial();
            }
        }

        //Search specials by product
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(cmbProductSearch.SelectedValue.ToString());

            SpecialSearchByProduct(productID);
        }

        //Search Specials by date
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDateSearch.Value;

            SpecialSearchByDate(date);
        }

        //Notify customers about special
        private void btnSpecialNotify_Click(object sender, EventArgs e)
        {
            if (dgvSpecials.SelectedRows.Count > 0)
            {
                int index = dgvSpecials.SelectedRows[0].Index;

                string message = string.Format("Get {0} for {1:c}", dgvSpecials.Rows[index].Cells[1].Value.ToString(),
                     Convert.ToDouble(dgvSpecials.Rows[index].Cells[3].Value.ToString()));


                int qty = Convert.ToInt32(dgvSpecials.Rows[index].Cells[2].Value.ToString());
                if (qty > 1)
                {
                    message += " when you buy " + qty.ToString() + " or more.";
                }
                else
                {
                    message += ".";
                }

                message += Environment.NewLine + Environment.NewLine + "Special valid from: " +
                    dtpStartDate.Text + " to: " + dtpEndDate.Text + ".";

                MessageBox.Show(message);

                try
                {
                    NotifyCustomer(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not notify customers about the special!" + Environment.NewLine +
                        Environment.NewLine + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No special selected!");
            }
        }

        //Notify customers about special
        private void NotifyCustomer(string message)
        {
            List<string> to = handlerSpecial.GetAllEmailAddresses();

            EmailNotification email = new EmailNotification(to, "Special At Photo Centre", message);
            
            email.SendMail();

            MessageBox.Show("Customers Notified.");
        }

        private void tileDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cancel New/Update Special
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSpecialNew.Text = "New Special";
            btnSpecialNew.Enabled = true;

            btnSpecialUpdate.Text = "Update Special";
            btnSpecialUpdate.Enabled = true;

            btnCancel.Visible = false;

            DisableFields();
            ClearFields();
        }

        private void cmbProductSearch_Enter(object sender, EventArgs e)
        {
            frmSpecials.ActiveForm.AcceptButton = btnSearchProduct;
        }

        private void dtpDateSearch_Enter(object sender, EventArgs e)
        {
            frmSpecials.ActiveForm.AcceptButton = btnSearchDate;
        }

        private void cmbProduct_Enter(object sender, EventArgs e)
        {
            if (btnSpecialNew.Text == "Save")
                frmSpecials.ActiveForm.AcceptButton = btnSpecialNew;
            else if (btnSpecialUpdate.Text == "Save")
                frmSpecials.ActiveForm.AcceptButton = btnSpecialUpdate;
        }
    }
}
