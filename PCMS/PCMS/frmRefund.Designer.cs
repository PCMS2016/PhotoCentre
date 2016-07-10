namespace PCMS
{
    partial class frmRefund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RefundTabControll = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnFinishTransaction = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.numRefundQuantity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtRefundReason = new MetroFramework.Controls.MetroTextBox();
            this.tbxInstructions = new MetroFramework.Controls.MetroTextBox();
            this.dgvRefundOrderLines = new MetroFramework.Controls.MetroGrid();
            this.lblInstructions2 = new MetroFramework.Controls.MetroLabel();
            this.lblProduct = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblProduct2 = new MetroFramework.Controls.MetroLabel();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.lblPrice2 = new MetroFramework.Controls.MetroLabel();
            this.lblQuantity2 = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblSalesperson = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblOrderNumber = new MetroFramework.Controls.MetroLabel();
            this.tbxOrderNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnRefundSearchOrder = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnVoid = new MetroFramework.Controls.MetroButton();
            this.btnRefund = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblRefundTotal = new MetroFramework.Controls.MetroLabel();
            this.dgvRefundItems = new MetroFramework.Controls.MetroGrid();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshDispRefund = new MetroFramework.Controls.MetroButton();
            this.RefundTabControll.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefundQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundOrderLines)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundItems)).BeginInit();
            this.SuspendLayout();
            // 
            // RefundTabControll
            // 
            this.RefundTabControll.Controls.Add(this.metroTabPage1);
            this.RefundTabControll.Controls.Add(this.metroTabPage2);
            this.RefundTabControll.Location = new System.Drawing.Point(20, 51);
            this.RefundTabControll.Name = "RefundTabControll";
            this.RefundTabControll.SelectedIndex = 1;
            this.RefundTabControll.Size = new System.Drawing.Size(1093, 591);
            this.RefundTabControll.Style = MetroFramework.MetroColorStyle.Lime;
            this.RefundTabControll.TabIndex = 1;
            this.RefundTabControll.UseSelectable = true;
            this.RefundTabControll.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnFinishTransaction);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.lblDate);
            this.metroTabPage1.Controls.Add(this.lblSalesperson);
            this.metroTabPage1.Controls.Add(this.lblTime);
            this.metroTabPage1.Controls.Add(this.lblOrderNumber);
            this.metroTabPage1.Controls.Add(this.tbxOrderNumber);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.lblCustomer);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.btnRefundSearchOrder);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1085, 549);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Refund Details";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnFinishTransaction
            // 
            this.btnFinishTransaction.Image = null;
            this.btnFinishTransaction.Location = new System.Drawing.Point(906, 489);
            this.btnFinishTransaction.Name = "btnFinishTransaction";
            this.btnFinishTransaction.Size = new System.Drawing.Size(157, 57);
            this.btnFinishTransaction.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnFinishTransaction.TabIndex = 36;
            this.btnFinishTransaction.Text = "FINISH TRANSACTION";
            this.btnFinishTransaction.UseSelectable = true;
            this.btnFinishTransaction.UseVisualStyleBackColor = true;
            this.btnFinishTransaction.Click += new System.EventHandler(this.btnFinishTransaction_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(22, 217);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Salesperson:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.numRefundQuantity);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtRefundReason);
            this.metroPanel1.Controls.Add(this.tbxInstructions);
            this.metroPanel1.Controls.Add(this.dgvRefundOrderLines);
            this.metroPanel1.Controls.Add(this.lblInstructions2);
            this.metroPanel1.Controls.Add(this.lblProduct);
            this.metroPanel1.Controls.Add(this.lblPrice);
            this.metroPanel1.Controls.Add(this.lblProduct2);
            this.metroPanel1.Controls.Add(this.lblQuantity);
            this.metroPanel1.Controls.Add(this.lblPrice2);
            this.metroPanel1.Controls.Add(this.lblQuantity2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(261, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(817, 464);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // numRefundQuantity
            // 
            this.numRefundQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRefundQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRefundQuantity.Location = new System.Drawing.Point(180, 279);
            this.numRefundQuantity.Name = "numRefundQuantity";
            this.numRefundQuantity.Size = new System.Drawing.Size(100, 29);
            this.numRefundQuantity.TabIndex = 25;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 311);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Reason for refund:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 284);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Quantity to refund:";
            // 
            // txtRefundReason
            // 
            // 
            // 
            // 
            this.txtRefundReason.CustomButton.Image = null;
            this.txtRefundReason.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtRefundReason.CustomButton.Name = "";
            this.txtRefundReason.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtRefundReason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefundReason.CustomButton.TabIndex = 1;
            this.txtRefundReason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefundReason.CustomButton.UseSelectable = true;
            this.txtRefundReason.CustomButton.Visible = false;
            this.txtRefundReason.Lines = new string[0];
            this.txtRefundReason.Location = new System.Drawing.Point(180, 311);
            this.txtRefundReason.MaxLength = 32767;
            this.txtRefundReason.Multiline = true;
            this.txtRefundReason.Name = "txtRefundReason";
            this.txtRefundReason.PasswordChar = '\0';
            this.txtRefundReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRefundReason.SelectedText = "";
            this.txtRefundReason.SelectionLength = 0;
            this.txtRefundReason.SelectionStart = 0;
            this.txtRefundReason.ShortcutsEnabled = true;
            this.txtRefundReason.Size = new System.Drawing.Size(273, 90);
            this.txtRefundReason.TabIndex = 22;
            this.txtRefundReason.UseSelectable = true;
            this.txtRefundReason.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefundReason.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxInstructions
            // 
            // 
            // 
            // 
            this.tbxInstructions.CustomButton.Image = null;
            this.tbxInstructions.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.tbxInstructions.CustomButton.Name = "";
            this.tbxInstructions.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.tbxInstructions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxInstructions.CustomButton.TabIndex = 1;
            this.tbxInstructions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxInstructions.CustomButton.UseSelectable = true;
            this.tbxInstructions.CustomButton.Visible = false;
            this.tbxInstructions.Lines = new string[0];
            this.tbxInstructions.Location = new System.Drawing.Point(586, 104);
            this.tbxInstructions.MaxLength = 32767;
            this.tbxInstructions.Multiline = true;
            this.tbxInstructions.Name = "tbxInstructions";
            this.tbxInstructions.PasswordChar = '\0';
            this.tbxInstructions.ReadOnly = true;
            this.tbxInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInstructions.SelectedText = "";
            this.tbxInstructions.SelectionLength = 0;
            this.tbxInstructions.SelectionStart = 0;
            this.tbxInstructions.ShortcutsEnabled = true;
            this.tbxInstructions.Size = new System.Drawing.Size(214, 147);
            this.tbxInstructions.TabIndex = 22;
            this.tbxInstructions.UseSelectable = true;
            this.tbxInstructions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxInstructions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvRefundOrderLines
            // 
            this.dgvRefundOrderLines.AllowUserToAddRows = false;
            this.dgvRefundOrderLines.AllowUserToDeleteRows = false;
            this.dgvRefundOrderLines.AllowUserToResizeRows = false;
            this.dgvRefundOrderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefundOrderLines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRefundOrderLines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRefundOrderLines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRefundOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRefundOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRefundOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundOrderLines.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRefundOrderLines.EnableHeadersVisualStyles = false;
            this.dgvRefundOrderLines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRefundOrderLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRefundOrderLines.Location = new System.Drawing.Point(12, 10);
            this.dgvRefundOrderLines.Name = "dgvRefundOrderLines";
            this.dgvRefundOrderLines.ReadOnly = true;
            this.dgvRefundOrderLines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRefundOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRefundOrderLines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRefundOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundOrderLines.Size = new System.Drawing.Size(465, 241);
            this.dgvRefundOrderLines.TabIndex = 4;
            this.dgvRefundOrderLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefundOrderLines_CellContentClick);
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Location = new System.Drawing.Point(504, 104);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(76, 19);
            this.lblInstructions2.TabIndex = 18;
            this.lblInstructions2.Text = "Insturctions:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(599, 23);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(0, 0);
            this.lblProduct.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(599, 77);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 0);
            this.lblPrice.TabIndex = 19;
            // 
            // lblProduct2
            // 
            this.lblProduct2.AutoSize = true;
            this.lblProduct2.Location = new System.Drawing.Point(504, 23);
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.Size = new System.Drawing.Size(58, 19);
            this.lblProduct2.TabIndex = 21;
            this.lblProduct2.Text = "Product:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(599, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 0);
            this.lblQuantity.TabIndex = 20;
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(504, 77);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(41, 19);
            this.lblPrice2.TabIndex = 19;
            this.lblPrice2.Text = "Price:";
            // 
            // lblQuantity2
            // 
            this.lblQuantity2.AutoSize = true;
            this.lblQuantity2.Location = new System.Drawing.Point(504, 50);
            this.lblQuantity2.Name = "lblQuantity2";
            this.lblQuantity2.Size = new System.Drawing.Size(61, 19);
            this.lblQuantity2.TabIndex = 20;
            this.lblQuantity2.Text = "Quantity:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(122, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 0);
            this.lblDate.TabIndex = 30;
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Location = new System.Drawing.Point(122, 219);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(0, 0);
            this.lblSalesperson.TabIndex = 27;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(122, 192);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 28;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(122, 111);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(0, 0);
            this.lblOrderNumber.TabIndex = 34;
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
            this.tbxOrderNumber.Location = new System.Drawing.Point(19, 58);
            this.tbxOrderNumber.MaxLength = 32767;
            this.tbxOrderNumber.Name = "tbxOrderNumber";
            this.tbxOrderNumber.PasswordChar = '\0';
            this.tbxOrderNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxOrderNumber.SelectedText = "";
            this.tbxOrderNumber.SelectionLength = 0;
            this.tbxOrderNumber.SelectionStart = 0;
            this.tbxOrderNumber.ShortcutsEnabled = true;
            this.tbxOrderNumber.Size = new System.Drawing.Size(140, 23);
            this.tbxOrderNumber.TabIndex = 24;
            this.tbxOrderNumber.UseSelectable = true;
            this.tbxOrderNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxOrderNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Order#:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(19, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Enter Order Number";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 191);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Time:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Date:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(122, 138);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 0);
            this.lblCustomer.TabIndex = 32;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Customer:";
            // 
            // btnRefundSearchOrder
            // 
            this.btnRefundSearchOrder.Location = new System.Drawing.Point(171, 58);
            this.btnRefundSearchOrder.Name = "btnRefundSearchOrder";
            this.btnRefundSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRefundSearchOrder.TabIndex = 25;
            this.btnRefundSearchOrder.Text = "Search";
            this.btnRefundSearchOrder.UseSelectable = true;
            this.btnRefundSearchOrder.Click += new System.EventHandler(this.btnRefundSearchOrder_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnRefreshDispRefund);
            this.metroTabPage2.Controls.Add(this.btnVoid);
            this.metroTabPage2.Controls.Add(this.btnRefund);
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1085, 549);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Finish Refund";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(974, 477);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(88, 57);
            this.btnVoid.TabIndex = 14;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseSelectable = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Image = null;
            this.btnRefund.Location = new System.Drawing.Point(870, 477);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(88, 57);
            this.btnRefund.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRefund.TabIndex = 13;
            this.btnRefund.Text = "REFUND";
            this.btnRefund.UseSelectable = true;
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.lblRefundTotal);
            this.metroPanel2.Controls.Add(this.dgvRefundItems);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(-1, 12);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1079, 447);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblRefundTotal
            // 
            this.lblRefundTotal.AutoSize = true;
            this.lblRefundTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRefundTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRefundTotal.Location = new System.Drawing.Point(862, 387);
            this.lblRefundTotal.Name = "lblRefundTotal";
            this.lblRefundTotal.Size = new System.Drawing.Size(69, 25);
            this.lblRefundTotal.TabIndex = 4;
            this.lblRefundTotal.Text = "Total: R";
            // 
            // dgvRefundItems
            // 
            this.dgvRefundItems.AllowUserToAddRows = false;
            this.dgvRefundItems.AllowUserToDeleteRows = false;
            this.dgvRefundItems.AllowUserToResizeRows = false;
            this.dgvRefundItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefundItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRefundItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRefundItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRefundItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRefundItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRefundItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundItems.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRefundItems.EnableHeadersVisualStyles = false;
            this.dgvRefundItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRefundItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRefundItems.Location = new System.Drawing.Point(26, 13);
            this.dgvRefundItems.Name = "dgvRefundItems";
            this.dgvRefundItems.ReadOnly = true;
            this.dgvRefundItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRefundItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRefundItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRefundItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundItems.Size = new System.Drawing.Size(1035, 343);
            this.dgvRefundItems.TabIndex = 2;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Product";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Instructions";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnRefreshDispRefund
            // 
            this.btnRefreshDispRefund.Location = new System.Drawing.Point(13, 477);
            this.btnRefreshDispRefund.Name = "btnRefreshDispRefund";
            this.btnRefreshDispRefund.Size = new System.Drawing.Size(88, 57);
            this.btnRefreshDispRefund.TabIndex = 15;
            this.btnRefreshDispRefund.Text = "REFRESH";
            this.btnRefreshDispRefund.UseSelectable = true;
            this.btnRefreshDispRefund.Click += new System.EventHandler(this.btnRefreshDispRefund_Click);
            // 
            // frmRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 659);
            this.Controls.Add(this.RefundTabControll);
            this.Name = "frmRefund";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "PHOTO CENTRE MS - REFUNDS";
            this.Load += new System.EventHandler(this.frmRefund_Load);
            this.RefundTabControll.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefundQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundOrderLines)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl RefundTabControll;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.NumericUpDown numRefundQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtRefundReason;
        private MetroFramework.Controls.MetroTextBox tbxInstructions;
        private MetroFramework.Controls.MetroGrid dgvRefundOrderLines;
        private MetroFramework.Controls.MetroLabel lblInstructions2;
        private MetroFramework.Controls.MetroLabel lblProduct;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblProduct2;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroLabel lblPrice2;
        private MetroFramework.Controls.MetroLabel lblQuantity2;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblSalesperson;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblOrderNumber;
        private MetroFramework.Controls.MetroTextBox tbxOrderNumber;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnRefundSearchOrder;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvRefundItems;
        private MetroFramework.Controls.MetroLabel lblRefundTotal;
        private MetroFramework.Controls.MetroButton btnVoid;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnRefund;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnFinishTransaction;
        private MetroFramework.Controls.MetroButton btnRefreshDispRefund;
    }
}