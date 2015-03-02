namespace DbsBank
{
    partial class AddCustomer
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
            this.txtOverdraftLimit = new System.Windows.Forms.TextBox();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.rdoSavings = new System.Windows.Forms.RadioButton();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.lvlOverdraftLimit = new System.Windows.Forms.Label();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOverdraftLimit
            // 
            this.txtOverdraftLimit.Location = new System.Drawing.Point(396, 177);
            this.txtOverdraftLimit.Name = "txtOverdraftLimit";
            this.txtOverdraftLimit.Size = new System.Drawing.Size(150, 20);
            this.txtOverdraftLimit.TabIndex = 59;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(396, 139);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(150, 20);
            this.txtInitialBalance.TabIndex = 58;
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(397, 99);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(150, 20);
            this.txtSortCode.TabIndex = 57;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(396, 62);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(150, 20);
            this.txtAccountNo.TabIndex = 56;
            // 
            // rdoSavings
            // 
            this.rdoSavings.AutoSize = true;
            this.rdoSavings.Location = new System.Drawing.Point(484, 27);
            this.rdoSavings.Name = "rdoSavings";
            this.rdoSavings.Size = new System.Drawing.Size(63, 17);
            this.rdoSavings.TabIndex = 55;
            this.rdoSavings.TabStop = true;
            this.rdoSavings.Text = "Savings";
            this.rdoSavings.UseVisualStyleBackColor = true;
            this.rdoSavings.CheckedChanged += new System.EventHandler(this.rdoSavings_CheckedChanged);
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Location = new System.Drawing.Point(397, 27);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(59, 17);
            this.rdoCurrent.TabIndex = 54;
            this.rdoCurrent.TabStop = true;
            this.rdoCurrent.Text = "Current";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            this.rdoCurrent.CheckedChanged += new System.EventHandler(this.rdoCurrent_CheckedChanged);
            // 
            // lvlOverdraftLimit
            // 
            this.lvlOverdraftLimit.AutoSize = true;
            this.lvlOverdraftLimit.Location = new System.Drawing.Point(294, 180);
            this.lvlOverdraftLimit.Name = "lvlOverdraftLimit";
            this.lvlOverdraftLimit.Size = new System.Drawing.Size(75, 13);
            this.lvlOverdraftLimit.TabIndex = 53;
            this.lvlOverdraftLimit.Text = "Overdraft Limit";
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(293, 142);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(73, 13);
            this.lblInitialBalance.TabIndex = 52;
            this.lblInitialBalance.Text = "Initial Balance";
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Location = new System.Drawing.Point(294, 102);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(54, 13);
            this.lblSortCode.TabIndex = 51;
            this.lblSortCode.Text = "Sort Code";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(293, 65);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 50;
            this.lblAccountNo.Text = "Account No.";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(294, 29);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(74, 13);
            this.lblAccountType.TabIndex = 49;
            this.lblAccountType.Text = "Account Type";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cboCounty.Location = new System.Drawing.Point(94, 305);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(144, 21);
            this.cboCounty.TabIndex = 75;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(94, 263);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(144, 20);
            this.txtCity.TabIndex = 74;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(94, 223);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(144, 20);
            this.txtAddress2.TabIndex = 73;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(94, 177);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(144, 20);
            this.txtAddress1.TabIndex = 72;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 71;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 20);
            this.txtEmail.TabIndex = 70;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(94, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(144, 20);
            this.txtSurname.TabIndex = 69;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(94, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 68;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(12, 308);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 67;
            this.lblCounty.Text = "County";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 266);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 66;
            this.lblCity.Text = "City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(12, 226);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 65;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(12, 180);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1.TabIndex = 64;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 142);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "Email";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 65);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 61;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 60;
            this.lblFirstName.Text = "First Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 286);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 347);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtOverdraftLimit);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.rdoSavings);
            this.Controls.Add(this.rdoCurrent);
            this.Controls.Add(this.lvlOverdraftLimit);
            this.Controls.Add(this.lblInitialBalance);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.lblAccountType);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOverdraftLimit;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.RadioButton rdoSavings;
        private System.Windows.Forms.RadioButton rdoCurrent;
        private System.Windows.Forms.Label lvlOverdraftLimit;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;

    }
}