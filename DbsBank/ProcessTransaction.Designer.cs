namespace DbsBank
{
    partial class ProcessTransaction
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
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnProcessTransaction = new System.Windows.Forms.Button();
            this.lblRecipientSortCode = new System.Windows.Forms.Label();
            this.lblRecipientAccNo = new System.Windows.Forms.Label();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtRecipientSortCode = new System.Windows.Forms.TextBox();
            this.txtRecipientAccNo = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtAmountCent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 15);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.Enabled = false;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Transfer",
            "Withdrawal",
            "Deposit"});
            this.cboType.Location = new System.Drawing.Point(163, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(138, 21);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 178);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(163, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 70);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "Account No.";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(163, 67);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(138, 20);
            this.txtAccountNumber.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 201);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 201);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(138, 64);
            this.txtDescription.TabIndex = 12;
            // 
            // btnProcessTransaction
            // 
            this.btnProcessTransaction.Location = new System.Drawing.Point(163, 271);
            this.btnProcessTransaction.Name = "btnProcessTransaction";
            this.btnProcessTransaction.Size = new System.Drawing.Size(138, 37);
            this.btnProcessTransaction.TabIndex = 13;
            this.btnProcessTransaction.Text = "Process Transaction";
            this.btnProcessTransaction.UseVisualStyleBackColor = true;
            this.btnProcessTransaction.Click += new System.EventHandler(this.btnProcessTransaction_Click);
            // 
            // lblRecipientSortCode
            // 
            this.lblRecipientSortCode.AutoSize = true;
            this.lblRecipientSortCode.Location = new System.Drawing.Point(12, 124);
            this.lblRecipientSortCode.Name = "lblRecipientSortCode";
            this.lblRecipientSortCode.Size = new System.Drawing.Size(102, 13);
            this.lblRecipientSortCode.TabIndex = 14;
            this.lblRecipientSortCode.Text = "Recipient Sort Code";
            // 
            // lblRecipientAccNo
            // 
            this.lblRecipientAccNo.AutoSize = true;
            this.lblRecipientAccNo.Location = new System.Drawing.Point(12, 152);
            this.lblRecipientAccNo.Name = "lblRecipientAccNo";
            this.lblRecipientAccNo.Size = new System.Drawing.Size(115, 13);
            this.lblRecipientAccNo.TabIndex = 15;
            this.lblRecipientAccNo.Text = "Recipient Account No.";
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Location = new System.Drawing.Point(12, 96);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(54, 13);
            this.lblSortCode.TabIndex = 16;
            this.lblSortCode.Text = "Sort Code";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Enabled = false;
            this.txtSortCode.Location = new System.Drawing.Point(163, 93);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(138, 20);
            this.txtSortCode.TabIndex = 17;
            // 
            // txtRecipientSortCode
            // 
            this.txtRecipientSortCode.Enabled = false;
            this.txtRecipientSortCode.Location = new System.Drawing.Point(163, 121);
            this.txtRecipientSortCode.Name = "txtRecipientSortCode";
            this.txtRecipientSortCode.Size = new System.Drawing.Size(138, 20);
            this.txtRecipientSortCode.TabIndex = 18;
            // 
            // txtRecipientAccNo
            // 
            this.txtRecipientAccNo.Enabled = false;
            this.txtRecipientAccNo.Location = new System.Drawing.Point(163, 149);
            this.txtRecipientAccNo.Name = "txtRecipientAccNo";
            this.txtRecipientAccNo.Size = new System.Drawing.Size(138, 20);
            this.txtRecipientAccNo.TabIndex = 19;
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(163, 175);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(84, 20);
            this.txtAmountEuro.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(145, 176);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 17);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "€";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(249, 171);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 26);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = ".";
            // 
            // txtAmountCent
            // 
            this.txtAmountCent.Location = new System.Drawing.Point(269, 175);
            this.txtAmountCent.Name = "txtAmountCent";
            this.txtAmountCent.Size = new System.Drawing.Size(32, 20);
            this.txtAmountCent.TabIndex = 6;
            this.txtAmountCent.Text = "00";
            // 
            // ProcessTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 318);
            this.Controls.Add(this.txtRecipientAccNo);
            this.Controls.Add(this.txtRecipientSortCode);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblRecipientAccNo);
            this.Controls.Add(this.lblRecipientSortCode);
            this.Controls.Add(this.btnProcessTransaction);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAmountCent);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Name = "ProcessTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.ProcessTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnProcessTransaction;
        private System.Windows.Forms.Label lblRecipientSortCode;
        private System.Windows.Forms.Label lblRecipientAccNo;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtRecipientSortCode;
        private System.Windows.Forms.TextBox txtRecipientAccNo;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.TextBox txtAccountNumber;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtAmountCent;
    }
}