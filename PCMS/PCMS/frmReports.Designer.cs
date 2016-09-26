namespace PCMS
{
    partial class frmReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rpvProducts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.rpvSalespersons = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.rpvRefunds = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpEnd = new MetroFramework.Controls.MetroDateTime();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.tabTrends = new MetroFramework.Controls.MetroTabPage();
            this.rpvTrends = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalespersonsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReports = new PCMS.dsReports();
            this.RefundsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesTrendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTableBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.tabTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalespersonsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefundsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTrendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsTableBindingSource
            // 
            this.ProductsTableBindingSource.DataMember = "ProductsTable";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.tabTrends);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(172, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(840, 692);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.rpvProducts);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(832, 650);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Products";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // rpvProducts
            // 
            reportDataSource1.Name = "products";
            reportDataSource1.Value = this.ProductsTableBindingSource;
            this.rpvProducts.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvProducts.LocalReport.ReportEmbeddedResource = "PCMS.ReportProducts.rdlc";
            this.rpvProducts.Location = new System.Drawing.Point(3, 3);
            this.rpvProducts.Name = "rpvProducts";
            this.rpvProducts.Size = new System.Drawing.Size(822, 641);
            this.rpvProducts.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.rpvSalespersons);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(832, 650);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Salespersons";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // rpvSalespersons
            // 
            reportDataSource2.Name = "dsReports";
            reportDataSource2.Value = this.SalespersonsTableBindingSource;
            this.rpvSalespersons.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvSalespersons.LocalReport.ReportEmbeddedResource = "PCMS.ReportSalespersons.rdlc";
            this.rpvSalespersons.Location = new System.Drawing.Point(3, 3);
            this.rpvSalespersons.Name = "rpvSalespersons";
            this.rpvSalespersons.Size = new System.Drawing.Size(829, 647);
            this.rpvSalespersons.TabIndex = 3;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.rpvRefunds);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(832, 650);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Refunds";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // rpvRefunds
            // 
            reportDataSource3.Name = "dsReports";
            reportDataSource3.Value = this.RefundsTableBindingSource;
            this.rpvRefunds.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvRefunds.LocalReport.ReportEmbeddedResource = "PCMS.ReportRefunds.rdlc";
            this.rpvRefunds.Location = new System.Drawing.Point(3, 3);
            this.rpvRefunds.Name = "rpvRefunds";
            this.rpvRefunds.Size = new System.Drawing.Size(829, 647);
            this.rpvRefunds.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Start Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(15, 123);
            this.dtpStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(151, 29);
            this.dtpStart.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(59, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "End Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(15, 194);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(151, 29);
            this.dtpEnd.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(53, 242);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabTrends
            // 
            this.tabTrends.Controls.Add(this.rpvTrends);
            this.tabTrends.HorizontalScrollbarBarColor = true;
            this.tabTrends.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTrends.HorizontalScrollbarSize = 10;
            this.tabTrends.Location = new System.Drawing.Point(4, 38);
            this.tabTrends.Name = "tabTrends";
            this.tabTrends.Size = new System.Drawing.Size(832, 650);
            this.tabTrends.TabIndex = 3;
            this.tabTrends.Text = "Trends";
            this.tabTrends.VerticalScrollbarBarColor = true;
            this.tabTrends.VerticalScrollbarHighlightOnWheel = false;
            this.tabTrends.VerticalScrollbarSize = 10;
            // 
            // rpvTrends
            // 
            reportDataSource4.Name = "dsReports";
            reportDataSource4.Value = this.SalesTrendsBindingSource;
            this.rpvTrends.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvTrends.LocalReport.ReportEmbeddedResource = "PCMS.ReportTrends.rdlc";
            this.rpvTrends.Location = new System.Drawing.Point(2, 2);
            this.rpvTrends.Name = "rpvTrends";
            this.rpvTrends.Size = new System.Drawing.Size(829, 647);
            this.rpvTrends.TabIndex = 4;
            // 
            // SalespersonsTableBindingSource
            // 
            this.SalespersonsTableBindingSource.DataMember = "SalespersonsTable";
            this.SalespersonsTableBindingSource.DataSource = this.dsReports;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RefundsTableBindingSource
            // 
            this.RefundsTableBindingSource.DataMember = "RefundsTable";
            this.RefundsTableBindingSource.DataSource = this.dsReports;
            // 
            // SalesTrendsBindingSource
            // 
            this.SalesTrendsBindingSource.DataMember = "SalesTrends";
            this.SalesTrendsBindingSource.DataSource = this.dsReports;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmReports";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "PHOTO CENTRE ME - REPORTS";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTableBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.tabTrends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalespersonsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefundsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTrendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvProducts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpStart;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpEnd;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSalespersons;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRefunds;
        private System.Windows.Forms.BindingSource ProductsTableBindingSource;
        private System.Windows.Forms.BindingSource SalespersonsTableBindingSource;
        private dsReports dsReports;
        private System.Windows.Forms.BindingSource RefundsTableBindingSource;
        private MetroFramework.Controls.MetroTabPage tabTrends;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTrends;
        private System.Windows.Forms.BindingSource SalesTrendsBindingSource;
    }
}