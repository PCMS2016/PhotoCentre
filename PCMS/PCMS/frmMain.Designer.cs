﻿namespace PCMS
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxDateSearch = new System.Windows.Forms.GroupBox();
            this.dtpDateSearch = new MetroFramework.Controls.MetroDateTime();
            this.btnToday = new MetroFramework.Controls.MetroButton();
            this.gbxCustomerSearch = new System.Windows.Forms.GroupBox();
            this.btnCustomerSearch = new MetroFramework.Controls.MetroButton();
            this.tbxSurname = new MetroFramework.Controls.MetroTextBox();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnOrderSearch = new MetroFramework.Controls.MetroButton();
            this.tbxOrderNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btbCollected = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCompleted = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lblSalesperson = new MetroFramework.Controls.MetroLabel();
            this.lblCollection = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblCompletion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblOrderNumber = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvOrderLines = new MetroFramework.Controls.MetroGrid();
            this.dgvOrders = new MetroFramework.Controls.MetroGrid();
            this.lblSearchOrders = new System.Windows.Forms.Label();
            this.mstrpMain = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tileNewOrder = new MetroFramework.Controls.MetroTile();
            this.tileRefund = new MetroFramework.Controls.MetroTile();
            this.tileReports = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.tileSpecials = new MetroFramework.Controls.MetroTile();
            this.gbxDateSearch.SuspendLayout();
            this.gbxCustomerSearch.SuspendLayout();
            this.gbxOrderSearch.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.mstrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDateSearch
            // 
            this.gbxDateSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxDateSearch.Controls.Add(this.dtpDateSearch);
            this.gbxDateSearch.Controls.Add(this.btnToday);
            this.gbxDateSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbxDateSearch.Location = new System.Drawing.Point(13, 463);
            this.gbxDateSearch.Name = "gbxDateSearch";
            this.gbxDateSearch.Size = new System.Drawing.Size(153, 109);
            this.gbxDateSearch.TabIndex = 7;
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
            this.btnToday.Text = "Today";
            this.btnToday.UseSelectable = true;
            // 
            // gbxCustomerSearch
            // 
            this.gbxCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxCustomerSearch.Controls.Add(this.btnCustomerSearch);
            this.gbxCustomerSearch.Controls.Add(this.tbxSurname);
            this.gbxCustomerSearch.Controls.Add(this.tbxName);
            this.gbxCustomerSearch.Controls.Add(this.lblSurname);
            this.gbxCustomerSearch.Controls.Add(this.lblName);
            this.gbxCustomerSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbxCustomerSearch.Location = new System.Drawing.Point(13, 292);
            this.gbxCustomerSearch.Name = "gbxCustomerSearch";
            this.gbxCustomerSearch.Size = new System.Drawing.Size(153, 166);
            this.gbxCustomerSearch.TabIndex = 8;
            this.gbxCustomerSearch.TabStop = false;
            this.gbxCustomerSearch.Text = "Customer";
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Location = new System.Drawing.Point(39, 128);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerSearch.TabIndex = 3;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseSelectable = true;
            // 
            // tbxSurname
            // 
            // 
            // 
            // 
            this.tbxSurname.CustomButton.Image = null;
            this.tbxSurname.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tbxSurname.CustomButton.Name = "";
            this.tbxSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSurname.CustomButton.TabIndex = 1;
            this.tbxSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSurname.CustomButton.UseSelectable = true;
            this.tbxSurname.CustomButton.Visible = false;
            this.tbxSurname.Lines = new string[0];
            this.tbxSurname.Location = new System.Drawing.Point(7, 93);
            this.tbxSurname.MaxLength = 32767;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.PasswordChar = '\0';
            this.tbxSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSurname.SelectedText = "";
            this.tbxSurname.SelectionLength = 0;
            this.tbxSurname.SelectionStart = 0;
            this.tbxSurname.ShortcutsEnabled = true;
            this.tbxSurname.Size = new System.Drawing.Size(140, 23);
            this.tbxSurname.TabIndex = 2;
            this.tbxSurname.UseSelectable = true;
            this.tbxSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(7, 44);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(140, 23);
            this.tbxName.TabIndex = 2;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(8, 75);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // gbxOrderSearch
            // 
            this.gbxOrderSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxOrderSearch.Controls.Add(this.btnOrderSearch);
            this.gbxOrderSearch.Controls.Add(this.tbxOrderNumber);
            this.gbxOrderSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOrderSearch.Location = new System.Drawing.Point(13, 197);
            this.gbxOrderSearch.Name = "gbxOrderSearch";
            this.gbxOrderSearch.Size = new System.Drawing.Size(153, 93);
            this.gbxOrderSearch.TabIndex = 9;
            this.gbxOrderSearch.TabStop = false;
            this.gbxOrderSearch.Text = "Order#";
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
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.YellowGreen;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.btbCollected);
            this.metroPanel1.Controls.Add(this.btnCompleted);
            this.metroPanel1.Controls.Add(this.lblSalesperson);
            this.metroPanel1.Controls.Add(this.lblCollection);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.lblCompletion);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.lblTime);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lblDate);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.lblCustomer);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.lblOrderNumber);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dgvOrderLines);
            this.metroPanel1.Controls.Add(this.dgvOrders);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(172, 180);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(798, 554);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btbCollected
            // 
            this.btbCollected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btbCollected.Image = null;
            this.btbCollected.Location = new System.Drawing.Point(169, 494);
            this.btbCollected.Name = "btbCollected";
            this.btbCollected.Size = new System.Drawing.Size(101, 41);
            this.btbCollected.TabIndex = 6;
            this.btbCollected.Text = "Collected";
            this.btbCollected.UseSelectable = true;
            this.btbCollected.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCompleted.Image = null;
            this.btnCompleted.Location = new System.Drawing.Point(49, 494);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(101, 41);
            this.btnCompleted.TabIndex = 6;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseSelectable = true;
            this.btnCompleted.UseVisualStyleBackColor = true;
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Location = new System.Drawing.Point(150, 467);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(0, 0);
            this.lblSalesperson.TabIndex = 5;
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(150, 440);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(0, 0);
            this.lblCollection.TabIndex = 5;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(17, 467);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Salesperson:";
            // 
            // lblCompletion
            // 
            this.lblCompletion.AutoSize = true;
            this.lblCompletion.Location = new System.Drawing.Point(150, 413);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(0, 0);
            this.lblCompletion.TabIndex = 5;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 440);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Collection Status:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(150, 386);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 5;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 413);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Completion Status:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(150, 359);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 0);
            this.lblDate.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 386);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Time:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(150, 332);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 0);
            this.lblCustomer.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 359);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Date:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(150, 305);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(0, 0);
            this.lblOrderNumber.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 332);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Customer:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 305);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Order#:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(17, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "ORDERS";
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AllowUserToAddRows = false;
            this.dgvOrderLines.AllowUserToDeleteRows = false;
            this.dgvOrderLines.AllowUserToResizeRows = false;
            this.dgvOrderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderLines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrderLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderLines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderLines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderLines.EnableHeadersVisualStyles = false;
            this.dgvOrderLines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrderLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrderLines.Location = new System.Drawing.Point(320, 294);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.ReadOnly = true;
            this.dgvOrderLines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderLines.Size = new System.Drawing.Size(465, 241);
            this.dgvOrderLines.TabIndex = 3;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrders.Location = new System.Drawing.Point(6, 31);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(782, 245);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // lblSearchOrders
            // 
            this.lblSearchOrders.AutoSize = true;
            this.lblSearchOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrders.Location = new System.Drawing.Point(23, 166);
            this.lblSearchOrders.Name = "lblSearchOrders";
            this.lblSearchOrders.Size = new System.Drawing.Size(139, 21);
            this.lblSearchOrders.TabIndex = 11;
            this.lblSearchOrders.Text = "Search Orders By...";
            // 
            // mstrpMain
            // 
            this.mstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiTransactions,
            this.tsiAdmin,
            this.tsiAbout});
            this.mstrpMain.Location = new System.Drawing.Point(20, 60);
            this.mstrpMain.Name = "mstrpMain";
            this.mstrpMain.Size = new System.Drawing.Size(942, 24);
            this.mstrpMain.TabIndex = 12;
            this.mstrpMain.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(37, 20);
            this.tsiFile.Text = "File";
            // 
            // tsiTransactions
            // 
            this.tsiTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNewOrder,
            this.tsiRefund});
            this.tsiTransactions.Name = "tsiTransactions";
            this.tsiTransactions.Size = new System.Drawing.Size(85, 20);
            this.tsiTransactions.Text = "Transactions";
            // 
            // tsiNewOrder
            // 
            this.tsiNewOrder.Name = "tsiNewOrder";
            this.tsiNewOrder.Size = new System.Drawing.Size(131, 22);
            this.tsiNewOrder.Text = "New Order";
            // 
            // tsiRefund
            // 
            this.tsiRefund.Name = "tsiRefund";
            this.tsiRefund.Size = new System.Drawing.Size(131, 22);
            this.tsiRefund.Text = "Refund";
            // 
            // tsiAdmin
            // 
            this.tsiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiReports,
            this.tsiSettings});
            this.tsiAdmin.Name = "tsiAdmin";
            this.tsiAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsiAdmin.Text = "Admin";
            // 
            // tsiReports
            // 
            this.tsiReports.Name = "tsiReports";
            this.tsiReports.Size = new System.Drawing.Size(116, 22);
            this.tsiReports.Text = "Reports";
            // 
            // tsiSettings
            // 
            this.tsiSettings.Name = "tsiSettings";
            this.tsiSettings.Size = new System.Drawing.Size(116, 22);
            this.tsiSettings.Text = "Settings";
            // 
            // tsiAbout
            // 
            this.tsiAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsiAbout.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // tileNewOrder
            // 
            this.tileNewOrder.ActiveControl = null;
            this.tileNewOrder.Location = new System.Drawing.Point(20, 102);
            this.tileNewOrder.Name = "tileNewOrder";
            this.tileNewOrder.Size = new System.Drawing.Size(86, 58);
            this.tileNewOrder.TabIndex = 13;
            this.tileNewOrder.Text = "New Order";
            this.tileNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNewOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNewOrder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileNewOrder.UseSelectable = true;
            this.tileNewOrder.Click += new System.EventHandler(this.tileNewOrder_Click);
            // 
            // tileRefund
            // 
            this.tileRefund.ActiveControl = null;
            this.tileRefund.Location = new System.Drawing.Point(112, 102);
            this.tileRefund.Name = "tileRefund";
            this.tileRefund.Size = new System.Drawing.Size(86, 58);
            this.tileRefund.TabIndex = 13;
            this.tileRefund.Text = "Refund";
            this.tileRefund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRefund.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRefund.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileRefund.UseSelectable = true;
            this.tileRefund.Click += new System.EventHandler(this.tileRefund_Click);
            // 
            // tileReports
            // 
            this.tileReports.ActiveControl = null;
            this.tileReports.Location = new System.Drawing.Point(690, 102);
            this.tileReports.Name = "tileReports";
            this.tileReports.Size = new System.Drawing.Size(86, 58);
            this.tileReports.TabIndex = 13;
            this.tileReports.Text = "Reports";
            this.tileReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileReports.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileReports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileReports.UseSelectable = true;
            this.tileReports.Click += new System.EventHandler(this.tileReports_Click);
            // 
            // tileSettings
            // 
            this.tileSettings.ActiveControl = null;
            this.tileSettings.Location = new System.Drawing.Point(782, 102);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(86, 58);
            this.tileSettings.TabIndex = 13;
            this.tileSettings.Text = "Settings";
            this.tileSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSettings.UseSelectable = true;
            this.tileSettings.Click += new System.EventHandler(this.tileSettings_Click);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Location = new System.Drawing.Point(874, 102);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(86, 58);
            this.tileLogout.TabIndex = 13;
            this.tileLogout.Text = "Logout";
            this.tileLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            // 
            // tileSpecials
            // 
            this.tileSpecials.ActiveControl = null;
            this.tileSpecials.Location = new System.Drawing.Point(204, 102);
            this.tileSpecials.Name = "tileSpecials";
            this.tileSpecials.Size = new System.Drawing.Size(86, 58);
            this.tileSpecials.TabIndex = 14;
            this.tileSpecials.Text = "Specials";
            this.tileSpecials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSpecials.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSpecials.UseSelectable = true;
            this.tileSpecials.Click += new System.EventHandler(this.tileSpecials_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 755);
            this.Controls.Add(this.tileSpecials);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileReports);
            this.Controls.Add(this.tileRefund);
            this.Controls.Add(this.tileNewOrder);
            this.Controls.Add(this.lblSearchOrders);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gbxDateSearch);
            this.Controls.Add(this.gbxCustomerSearch);
            this.Controls.Add(this.gbxOrderSearch);
            this.Controls.Add(this.mstrpMain);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxDateSearch.ResumeLayout(false);
            this.gbxCustomerSearch.ResumeLayout(false);
            this.gbxCustomerSearch.PerformLayout();
            this.gbxOrderSearch.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.mstrpMain.ResumeLayout(false);
            this.mstrpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDateSearch;
        private System.Windows.Forms.GroupBox gbxCustomerSearch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxOrderSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvOrderLines;
        private MetroFramework.Controls.MetroGrid dgvOrders;
        private MetroFramework.Controls.MetroLabel lblSalesperson;
        private MetroFramework.Controls.MetroLabel lblCollection;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblCompletion;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblOrderNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btbCollected;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnCompleted;
        private MetroFramework.Controls.MetroDateTime dtpDateSearch;
        private MetroFramework.Controls.MetroButton btnToday;
        private MetroFramework.Controls.MetroButton btnCustomerSearch;
        private MetroFramework.Controls.MetroTextBox tbxSurname;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroButton btnOrderSearch;
        private MetroFramework.Controls.MetroTextBox tbxOrderNumber;
        private System.Windows.Forms.Label lblSearchOrders;
        private System.Windows.Forms.MenuStrip mstrpMain;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripMenuItem tsiTransactions;
        private MetroFramework.Controls.MetroTile tileNewOrder;
        private MetroFramework.Controls.MetroTile tileRefund;
        private MetroFramework.Controls.MetroTile tileReports;
        private MetroFramework.Controls.MetroTile tileSettings;
        private System.Windows.Forms.ToolStripMenuItem tsiNewOrder;
        private System.Windows.Forms.ToolStripMenuItem tsiRefund;
        private System.Windows.Forms.ToolStripMenuItem tsiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsiReports;
        private System.Windows.Forms.ToolStripMenuItem tsiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsiAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroTile tileSpecials;
    }
}