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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSpecialNotify = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmbEndDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbStartDate = new MetroFramework.Controls.MetroDateTime();
            this.btnSpecialNew = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnSpecialUpdate = new MetroFramework.Controls.MetroButton();
            this.cmbSize = new MetroFramework.Controls.MetroComboBox();
            this.cmbProduct = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.dgvSpecials = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchOrders = new System.Windows.Forms.Label();
            this.gbxDateSearch = new System.Windows.Forms.GroupBox();
            this.dtpDateSearch = new MetroFramework.Controls.MetroDateTime();
            this.btnToday = new MetroFramework.Controls.MetroButton();
            this.gbxOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnOrderSearch = new MetroFramework.Controls.MetroButton();
            this.tbxOrderNumber = new MetroFramework.Controls.MetroTextBox();
            this.tileDone = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).BeginInit();
            this.gbxDateSearch.SuspendLayout();
            this.gbxOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btnSpecialNotify);
            this.metroPanel1.Controls.Add(this.cmbEndDate);
            this.metroPanel1.Controls.Add(this.cmbStartDate);
            this.metroPanel1.Controls.Add(this.btnSpecialNew);
            this.metroPanel1.Controls.Add(this.btnSpecialUpdate);
            this.metroPanel1.Controls.Add(this.cmbSize);
            this.metroPanel1.Controls.Add(this.cmbProduct);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.tbxPrice);
            this.metroPanel1.Controls.Add(this.dgvSpecials);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(174, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(689, 499);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSpecialNotify
            // 
            this.btnSpecialNotify.Image = null;
            this.btnSpecialNotify.Location = new System.Drawing.Point(513, 263);
            this.btnSpecialNotify.Name = "btnSpecialNotify";
            this.btnSpecialNotify.Size = new System.Drawing.Size(151, 57);
            this.btnSpecialNotify.TabIndex = 29;
            this.btnSpecialNotify.Text = "NOTIFY CUSTOMERS";
            this.btnSpecialNotify.UseSelectable = true;
            this.btnSpecialNotify.UseVisualStyleBackColor = true;
            // 
            // cmbEndDate
            // 
            this.cmbEndDate.Location = new System.Drawing.Point(165, 369);
            this.cmbEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbEndDate.Name = "cmbEndDate";
            this.cmbEndDate.Size = new System.Drawing.Size(200, 29);
            this.cmbEndDate.TabIndex = 28;
            // 
            // cmbStartDate
            // 
            this.cmbStartDate.Location = new System.Drawing.Point(165, 334);
            this.cmbStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbStartDate.Name = "cmbStartDate";
            this.cmbStartDate.Size = new System.Drawing.Size(200, 29);
            this.cmbStartDate.TabIndex = 28;
            // 
            // btnSpecialNew
            // 
            this.btnSpecialNew.Image = null;
            this.btnSpecialNew.Location = new System.Drawing.Point(244, 451);
            this.btnSpecialNew.Name = "btnSpecialNew";
            this.btnSpecialNew.Size = new System.Drawing.Size(110, 32);
            this.btnSpecialNew.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSpecialNew.TabIndex = 27;
            this.btnSpecialNew.Text = "New Special";
            this.btnSpecialNew.UseSelectable = true;
            this.btnSpecialNew.UseStyleColors = true;
            this.btnSpecialNew.UseVisualStyleBackColor = true;
            // 
            // btnSpecialUpdate
            // 
            this.btnSpecialUpdate.Location = new System.Drawing.Point(105, 451);
            this.btnSpecialUpdate.Name = "btnSpecialUpdate";
            this.btnSpecialUpdate.Size = new System.Drawing.Size(110, 32);
            this.btnSpecialUpdate.TabIndex = 26;
            this.btnSpecialUpdate.Text = "Update Special";
            this.btnSpecialUpdate.UseSelectable = true;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.ItemHeight = 23;
            this.cmbSize.Items.AddRange(new object[] {
            "A4"});
            this.cmbSize.Location = new System.Drawing.Point(165, 299);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(200, 29);
            this.cmbSize.TabIndex = 24;
            this.cmbSize.UseSelectable = true;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.ItemHeight = 23;
            this.cmbProduct.Items.AddRange(new object[] {
            "Photo"});
            this.cmbProduct.Location = new System.Drawing.Point(165, 263);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 29);
            this.cmbProduct.TabIndex = 25;
            this.cmbProduct.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 410);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Special Price:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(46, 374);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "End Date:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 339);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Start Date:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 304);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Size:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 268);
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
            this.tbxPrice.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbxPrice.CustomButton.Name = "";
            this.tbxPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPrice.CustomButton.TabIndex = 1;
            this.tbxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPrice.CustomButton.UseSelectable = true;
            this.tbxPrice.CustomButton.Visible = false;
            this.tbxPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxPrice.Lines = new string[0];
            this.tbxPrice.Location = new System.Drawing.Point(165, 405);
            this.tbxPrice.MaxLength = 32767;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.SelectionLength = 0;
            this.tbxPrice.SelectionStart = 0;
            this.tbxPrice.ShortcutsEnabled = true;
            this.tbxPrice.Size = new System.Drawing.Size(200, 29);
            this.tbxPrice.TabIndex = 23;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSpecials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSpecials.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpecials.EnableHeadersVisualStyles = false;
            this.dgvSpecials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSpecials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSpecials.Location = new System.Drawing.Point(14, 13);
            this.dgvSpecials.Name = "dgvSpecials";
            this.dgvSpecials.ReadOnly = true;
            this.dgvSpecials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpecials.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSpecials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSpecials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecials.Size = new System.Drawing.Size(662, 232);
            this.dgvSpecials.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.gbxDateSearch.Controls.Add(this.btnToday);
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
            this.dtpDateSearch.TabIndex = 4;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(39, 69);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Search";
            this.btnToday.UseSelectable = true;
            // 
            // gbxOrderSearch
            // 
            this.gbxOrderSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxOrderSearch.Controls.Add(this.btnOrderSearch);
            this.gbxOrderSearch.Controls.Add(this.tbxOrderNumber);
            this.gbxOrderSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderSearch.Location = new System.Drawing.Point(13, 95);
            this.gbxOrderSearch.Name = "gbxOrderSearch";
            this.gbxOrderSearch.Size = new System.Drawing.Size(153, 93);
            this.gbxOrderSearch.TabIndex = 14;
            this.gbxOrderSearch.TabStop = false;
            this.gbxOrderSearch.Text = "Product";
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(39, 56);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSearch.TabIndex = 3;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseSelectable = true;
            // 
            // tbxOrderNumber
            // 
            // 
            // 
            // 
            this.tbxOrderNumber.CustomButton.Image = null;
            this.tbxOrderNumber.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tbxOrderNumber.CustomButton.Name = "";
            this.tbxOrderNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxOrderNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxOrderNumber.CustomButton.TabIndex = 1;
            this.tbxOrderNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxOrderNumber.CustomButton.UseSelectable = true;
            this.tbxOrderNumber.CustomButton.Visible = false;
            this.tbxOrderNumber.Lines = new string[0];
            this.tbxOrderNumber.Location = new System.Drawing.Point(7, 21);
            this.tbxOrderNumber.MaxLength = 32767;
            this.tbxOrderNumber.Name = "tbxOrderNumber";
            this.tbxOrderNumber.PasswordChar = '\0';
            this.tbxOrderNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxOrderNumber.SelectedText = "";
            this.tbxOrderNumber.SelectionLength = 0;
            this.tbxOrderNumber.SelectionStart = 0;
            this.tbxOrderNumber.ShortcutsEnabled = true;
            this.tbxOrderNumber.Size = new System.Drawing.Size(140, 23);
            this.tbxOrderNumber.TabIndex = 2;
            this.tbxOrderNumber.UseSelectable = true;
            this.tbxOrderNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxOrderNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileDone
            // 
            this.tileDone.ActiveControl = null;
            this.tileDone.Location = new System.Drawing.Point(766, 570);
            this.tileDone.Name = "tileDone";
            this.tileDone.Size = new System.Drawing.Size(86, 58);
            this.tileDone.TabIndex = 15;
            this.tileDone.Text = "Done";
            this.tileDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDone.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDone.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDone.UseSelectable = true;
            // 
            // frmSpecials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 653);
            this.Controls.Add(this.tileDone);
            this.Controls.Add(this.gbxDateSearch);
            this.Controls.Add(this.gbxOrderSearch);
            this.Controls.Add(this.lblSearchOrders);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmSpecials";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "PHOTO CENTRE MS - SPECIALS";
            this.Load += new System.EventHandler(this.frmSpecials_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecials)).EndInit();
            this.gbxDateSearch.ResumeLayout(false);
            this.gbxOrderSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvSpecials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroDateTime cmbEndDate;
        private MetroFramework.Controls.MetroDateTime cmbStartDate;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSpecialNew;
        private MetroFramework.Controls.MetroButton btnSpecialUpdate;
        private MetroFramework.Controls.MetroComboBox cmbSize;
        private MetroFramework.Controls.MetroComboBox cmbProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxPrice;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSpecialNotify;
        private System.Windows.Forms.Label lblSearchOrders;
        private System.Windows.Forms.GroupBox gbxDateSearch;
        private MetroFramework.Controls.MetroDateTime dtpDateSearch;
        private MetroFramework.Controls.MetroButton btnToday;
        private System.Windows.Forms.GroupBox gbxOrderSearch;
        private MetroFramework.Controls.MetroButton btnOrderSearch;
        private MetroFramework.Controls.MetroTextBox tbxOrderNumber;
        private MetroFramework.Controls.MetroTile tileDone;
    }
}