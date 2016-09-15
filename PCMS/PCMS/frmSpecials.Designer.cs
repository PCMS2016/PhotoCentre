namespace PCMS
{
    partial class frmSpecials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSpecialNotify = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dtpEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtpStartDate = new MetroFramework.Controls.MetroDateTime();
            this.btnSpecialNew = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSpecialUpdate = new MetroFramework.Controls.MetroButton();
            this.cmbProduct = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.dgvSpecials = new MetroFramework.Controls.MetroGrid();
            this.lblSearchOrders = new System.Windows.Forms.Label();
            this.gbxDateSearch = new System.Windows.Forms.GroupBox();
            this.dtpDateSearch = new MetroFramework.Controls.MetroDateTime();
            this.btnSearchDate = new MetroFramework.Controls.MetroButton();
            this.gbxOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchProduct = new MetroFramework.Controls.MetroButton();
            this.cmbProductSearch = new MetroFramework.Controls.MetroComboBox();
            this.tileDone = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).BeginInit();
            this.gbxDateSearch.SuspendLayout();
            this.gbxOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.numQuantity);
            this.metroPanel1.Controls.Add(this.btnSpecialNotify);
            this.metroPanel1.Controls.Add(this.dtpEndDate);
            this.metroPanel1.Controls.Add(this.dtpStartDate);
            this.metroPanel1.Controls.Add(this.btnSpecialNew);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btnSpecialUpdate);
            this.metroPanel1.Controls.Add(this.cmbProduct);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.tbxPrice);
            this.metroPanel1.Controls.Add(this.dgvSpecials);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(174, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(689, 499);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // numQuantity
            // 
            this.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQuantity.Enabled = false;
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(165, 295);
            this.numQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(177, 29);
            this.numQuantity.TabIndex = 4;
            // 
            // btnSpecialNotify
            // 
            this.btnSpecialNotify.Image = null;
            this.btnSpecialNotify.Location = new System.Drawing.Point(513, 263);
            this.btnSpecialNotify.Name = "btnSpecialNotify";
            this.btnSpecialNotify.Size = new System.Drawing.Size(151, 57);
            this.btnSpecialNotify.TabIndex = 9;
            this.btnSpecialNotify.Text = "NOTIFY CUSTOMERS";
            this.btnSpecialNotify.UseSelectable = true;
            this.btnSpecialNotify.UseVisualStyleBackColor = true;
            this.btnSpecialNotify.Click += new System.EventHandler(this.btnSpecialNotify_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(165, 397);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(177, 29);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(165, 363);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(177, 29);
            this.dtpStartDate.TabIndex = 6;
            // 
            // btnSpecialNew
            // 
            this.btnSpecialNew.Image = null;
            this.btnSpecialNew.Location = new System.Drawing.Point(260, 447);
            this.btnSpecialNew.Name = "btnSpecialNew";
            this.btnSpecialNew.Size = new System.Drawing.Size(110, 32);
            this.btnSpecialNew.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSpecialNew.TabIndex = 2;
            this.btnSpecialNew.Text = "New Special";
            this.btnSpecialNew.UseSelectable = true;
            this.btnSpecialNew.UseStyleColors = true;
            this.btnSpecialNew.UseVisualStyleBackColor = true;
            this.btnSpecialNew.Click += new System.EventHandler(this.btnSpecialNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSpecialUpdate
            // 
            this.btnSpecialUpdate.Location = new System.Drawing.Point(140, 447);
            this.btnSpecialUpdate.Name = "btnSpecialUpdate";
            this.btnSpecialUpdate.Size = new System.Drawing.Size(110, 32);
            this.btnSpecialUpdate.TabIndex = 1;
            this.btnSpecialUpdate.Text = "Update Special";
            this.btnSpecialUpdate.UseSelectable = true;
            this.btnSpecialUpdate.Click += new System.EventHandler(this.btnSpecialUpdate_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Enabled = false;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.ItemHeight = 23;
            this.cmbProduct.Items.AddRange(new object[] {
            "Photo"});
            this.cmbProduct.Location = new System.Drawing.Point(165, 261);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(177, 29);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.UseSelectable = true;
            this.cmbProduct.Enter += new System.EventHandler(this.cmbProduct_Enter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.Location = new System.Drawing.Point(46, 299);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Qty To Qualify:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.Location = new System.Drawing.Point(165, 334);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(17, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "R";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(46, 334);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Special Price:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.Location = new System.Drawing.Point(46, 403);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "End Date:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.Location = new System.Drawing.Point(46, 368);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Start Date:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(46, 266);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Product:";
            // 
            // tbxPrice
            // 
            // 
            // 
            // 
            this.tbxPrice.CustomButton.Image = null;
            this.tbxPrice.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbxPrice.CustomButton.Name = "";
            this.tbxPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPrice.CustomButton.TabIndex = 1;
            this.tbxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPrice.CustomButton.UseSelectable = true;
            this.tbxPrice.CustomButton.Visible = false;
            this.tbxPrice.Enabled = false;
            this.tbxPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxPrice.Lines = new string[0];
            this.tbxPrice.Location = new System.Drawing.Point(188, 329);
            this.tbxPrice.MaxLength = 32767;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.SelectionLength = 0;
            this.tbxPrice.SelectionStart = 0;
            this.tbxPrice.ShortcutsEnabled = true;
            this.tbxPrice.Size = new System.Drawing.Size(154, 29);
            this.tbxPrice.TabIndex = 5;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxPrice.UseSelectable = true;
            this.tbxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvSpecials
            // 
            this.dgvSpecials.AllowUserToAddRows = false;
            this.dgvSpecials.AllowUserToDeleteRows = false;
            this.dgvSpecials.AllowUserToResizeRows = false;
            this.dgvSpecials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSpecials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSpecials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSpecials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSpecials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSpecials.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSpecials.EnableHeadersVisualStyles = false;
            this.dgvSpecials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSpecials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSpecials.Location = new System.Drawing.Point(14, 13);
            this.dgvSpecials.Name = "dgvSpecials";
            this.dgvSpecials.ReadOnly = true;
            this.dgvSpecials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecials.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSpecials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSpecials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecials.Size = new System.Drawing.Size(662, 232);
            this.dgvSpecials.TabIndex = 0;
            this.dgvSpecials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpecials_CellClick);
            // 
            // lblSearchOrders
            // 
            this.lblSearchOrders.AutoSize = true;
            this.lblSearchOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrders.Location = new System.Drawing.Point(21, 63);
            this.lblSearchOrders.Name = "lblSearchOrders";
            this.lblSearchOrders.Size = new System.Drawing.Size(147, 21);
            this.lblSearchOrders.TabIndex = 12;
            this.lblSearchOrders.Text = "Search Specials By...";
            // 
            // gbxDateSearch
            // 
            this.gbxDateSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxDateSearch.Controls.Add(this.dtpDateSearch);
            this.gbxDateSearch.Controls.Add(this.btnSearchDate);
            this.gbxDateSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbxDateSearch.Location = new System.Drawing.Point(13, 203);
            this.gbxDateSearch.Name = "gbxDateSearch";
            this.gbxDateSearch.Size = new System.Drawing.Size(153, 109);
            this.gbxDateSearch.TabIndex = 13;
            this.gbxDateSearch.TabStop = false;
            this.gbxDateSearch.Text = "Date";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.CustomFormat = "dd/MM/yyyy";
            this.dtpDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateSearch.Location = new System.Drawing.Point(7, 26);
            this.dtpDateSearch.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(140, 29);
            this.dtpDateSearch.TabIndex = 13;
            this.dtpDateSearch.Enter += new System.EventHandler(this.dtpDateSearch_Enter);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(39, 69);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDate.TabIndex = 14;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseSelectable = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // gbxOrderSearch
            // 
            this.gbxOrderSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxOrderSearch.Controls.Add(this.btnSearchProduct);
            this.gbxOrderSearch.Controls.Add(this.cmbProductSearch);
            this.gbxOrderSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderSearch.Location = new System.Drawing.Point(13, 95);
            this.gbxOrderSearch.Name = "gbxOrderSearch";
            this.gbxOrderSearch.Size = new System.Drawing.Size(153, 93);
            this.gbxOrderSearch.TabIndex = 14;
            this.gbxOrderSearch.TabStop = false;
            this.gbxOrderSearch.Text = "Product";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(39, 59);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 12;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseSelectable = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // cmbProductSearch
            // 
            this.cmbProductSearch.FormattingEnabled = true;
            this.cmbProductSearch.ItemHeight = 23;
            this.cmbProductSearch.Items.AddRange(new object[] {
            "Photo"});
            this.cmbProductSearch.Location = new System.Drawing.Point(7, 20);
            this.cmbProductSearch.Name = "cmbProductSearch";
            this.cmbProductSearch.Size = new System.Drawing.Size(140, 29);
            this.cmbProductSearch.TabIndex = 11;
            this.cmbProductSearch.UseSelectable = true;
            this.cmbProductSearch.Enter += new System.EventHandler(this.cmbProductSearch_Enter);
            // 
            // tileDone
            // 
            this.tileDone.ActiveControl = null;
            this.tileDone.Location = new System.Drawing.Point(766, 570);
            this.tileDone.Name = "tileDone";
            this.tileDone.Size = new System.Drawing.Size(86, 58);
            this.tileDone.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDone.TabIndex = 10;
            this.tileDone.Text = "Done";
            this.tileDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDone.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDone.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDone.UseSelectable = true;
            this.tileDone.UseStyleColors = true;
            this.tileDone.Click += new System.EventHandler(this.tileDone_Click);
            // 
            // frmSpecials
            // 
            this.AcceptButton = this.tileDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 653);
            this.Controls.Add(this.tileDone);
            this.Controls.Add(this.gbxDateSearch);
            this.Controls.Add(this.gbxOrderSearch);
            this.Controls.Add(this.lblSearchOrders);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmSpecials";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "PHOTO CENTRE MS - SPECIALS";
            this.Load += new System.EventHandler(this.frmSpecials_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).EndInit();
            this.gbxDateSearch.ResumeLayout(false);
            this.gbxOrderSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvSpecials;
        private MetroFramework.Controls.MetroDateTime dtpEndDate;
        private MetroFramework.Controls.MetroDateTime dtpStartDate;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSpecialNew;
        private MetroFramework.Controls.MetroButton btnSpecialUpdate;
        private MetroFramework.Controls.MetroComboBox cmbProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxPrice;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSpecialNotify;
        private System.Windows.Forms.Label lblSearchOrders;
        private System.Windows.Forms.GroupBox gbxDateSearch;
        private MetroFramework.Controls.MetroDateTime dtpDateSearch;
        private MetroFramework.Controls.MetroButton btnSearchDate;
        private System.Windows.Forms.GroupBox gbxOrderSearch;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
        private MetroFramework.Controls.MetroTile tileDone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private MetroFramework.Controls.MetroComboBox cmbProductSearch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}