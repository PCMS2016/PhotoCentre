namespace PCMS
{
    partial class DBConnection
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
            this.btnSave = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tbxServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxDatabase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(220, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxServer
            // 
            // 
            // 
            // 
            this.tbxServer.CustomButton.Image = null;
            this.tbxServer.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbxServer.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbxServer.CustomButton.Name = "";
            this.tbxServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxServer.CustomButton.TabIndex = 1;
            this.tbxServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxServer.CustomButton.UseSelectable = true;
            this.tbxServer.CustomButton.Visible = false;
            this.tbxServer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxServer.Lines = new string[0];
            this.tbxServer.Location = new System.Drawing.Point(142, 33);
            this.tbxServer.MaxLength = 32767;
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.PasswordChar = '\0';
            this.tbxServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxServer.SelectedText = "";
            this.tbxServer.SelectionLength = 0;
            this.tbxServer.SelectionStart = 0;
            this.tbxServer.ShortcutsEnabled = true;
            this.tbxServer.Size = new System.Drawing.Size(166, 23);
            this.tbxServer.TabIndex = 13;
            this.tbxServer.UseSelectable = true;
            this.tbxServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(35, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Server:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(35, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Database:";
            // 
            // tbxDatabase
            // 
            // 
            // 
            // 
            this.tbxDatabase.CustomButton.Image = null;
            this.tbxDatabase.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbxDatabase.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDatabase.CustomButton.Name = "";
            this.tbxDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxDatabase.CustomButton.TabIndex = 1;
            this.tbxDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxDatabase.CustomButton.UseSelectable = true;
            this.tbxDatabase.CustomButton.Visible = false;
            this.tbxDatabase.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxDatabase.Lines = new string[0];
            this.tbxDatabase.Location = new System.Drawing.Point(142, 62);
            this.tbxDatabase.MaxLength = 32767;
            this.tbxDatabase.Name = "tbxDatabase";
            this.tbxDatabase.PasswordChar = '\0';
            this.tbxDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxDatabase.SelectedText = "";
            this.tbxDatabase.SelectionLength = 0;
            this.tbxDatabase.SelectionStart = 0;
            this.tbxDatabase.ShortcutsEnabled = true;
            this.tbxDatabase.Size = new System.Drawing.Size(166, 23);
            this.tbxDatabase.TabIndex = 13;
            this.tbxDatabase.UseSelectable = true;
            this.tbxDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(35, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Login:";
            // 
            // tbxLogin
            // 
            // 
            // 
            // 
            this.tbxLogin.CustomButton.Image = null;
            this.tbxLogin.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbxLogin.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLogin.CustomButton.Name = "";
            this.tbxLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxLogin.CustomButton.TabIndex = 1;
            this.tbxLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxLogin.CustomButton.UseSelectable = true;
            this.tbxLogin.CustomButton.Visible = false;
            this.tbxLogin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxLogin.Lines = new string[0];
            this.tbxLogin.Location = new System.Drawing.Point(142, 91);
            this.tbxLogin.MaxLength = 32767;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.PasswordChar = '\0';
            this.tbxLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxLogin.SelectedText = "";
            this.tbxLogin.SelectionLength = 0;
            this.tbxLogin.SelectionStart = 0;
            this.tbxLogin.ShortcutsEnabled = true;
            this.tbxLogin.Size = new System.Drawing.Size(166, 23);
            this.tbxLogin.TabIndex = 13;
            this.tbxLogin.UseSelectable = true;
            this.tbxLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(35, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Password:";
            // 
            // tbxPassword
            // 
            // 
            // 
            // 
            this.tbxPassword.CustomButton.Image = null;
            this.tbxPassword.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbxPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.CustomButton.Name = "";
            this.tbxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPassword.CustomButton.TabIndex = 1;
            this.tbxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPassword.CustomButton.UseSelectable = true;
            this.tbxPassword.CustomButton.Visible = false;
            this.tbxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbxPassword.Lines = new string[0];
            this.tbxPassword.Location = new System.Drawing.Point(142, 120);
            this.tbxPassword.MaxLength = 32767;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '\0';
            this.tbxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.ShortcutsEnabled = true;
            this.tbxPassword.Size = new System.Drawing.Size(166, 23);
            this.tbxPassword.TabIndex = 13;
            this.tbxPassword.UseSelectable = true;
            this.tbxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 198);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbxDatabase);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Name = "DBConnection";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "DBConnection";
            this.Load += new System.EventHandler(this.DBConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSave;
        private MetroFramework.Controls.MetroTextBox tbxServer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxDatabase;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbxLogin;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbxPassword;
    }
}