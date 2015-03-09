namespace DbsBank
{
    partial class ProcessTransfer
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
            this.lblDebitName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDebitAccNo = new System.Windows.Forms.Label();
            this.lblDebitSortCode = new System.Windows.Forms.Label();
            this.lblDebitAmount = new System.Windows.Forms.Label();
            this.grpDebit = new System.Windows.Forms.GroupBox();
            this.txtDebitAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDebitAccNo = new System.Windows.Forms.TextBox();
            this.txtDebitSortCode = new System.Windows.Forms.TextBox();
            this.txtDebitName = new System.Windows.Forms.TextBox();
            this.grpCredit = new System.Windows.Forms.GroupBox();
            this.txtCreditName = new System.Windows.Forms.TextBox();
            this.lblCreditName = new System.Windows.Forms.Label();
            this.txtCreditAccNo = new System.Windows.Forms.TextBox();
            this.txtCreditSortCode = new System.Windows.Forms.TextBox();
            this.lblCreditSortCode = new System.Windows.Forms.Label();
            this.lblCreditAccNo = new System.Windows.Forms.Label();
            this.btnProcessTransfer = new System.Windows.Forms.Button();
            this.grpDebit.SuspendLayout();
            this.grpCredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDebitName
            // 
            this.lblDebitName.AutoSize = true;
            this.lblDebitName.Location = new System.Drawing.Point(19, 27);
            this.lblDebitName.Name = "lblDebitName";
            this.lblDebitName.Size = new System.Drawing.Size(35, 13);
            this.lblDebitName.TabIndex = 0;
            this.lblDebitName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblDebitAccNo
            // 
            this.lblDebitAccNo.AutoSize = true;
            this.lblDebitAccNo.Location = new System.Drawing.Point(19, 53);
            this.lblDebitAccNo.Name = "lblDebitAccNo";
            this.lblDebitAccNo.Size = new System.Drawing.Size(67, 13);
            this.lblDebitAccNo.TabIndex = 2;
            this.lblDebitAccNo.Text = "Account No.";
            // 
            // lblDebitSortCode
            // 
            this.lblDebitSortCode.AutoSize = true;
            this.lblDebitSortCode.Location = new System.Drawing.Point(19, 79);
            this.lblDebitSortCode.Name = "lblDebitSortCode";
            this.lblDebitSortCode.Size = new System.Drawing.Size(54, 13);
            this.lblDebitSortCode.TabIndex = 3;
            this.lblDebitSortCode.Text = "Sort Code";
            // 
            // lblDebitAmount
            // 
            this.lblDebitAmount.AutoSize = true;
            this.lblDebitAmount.Location = new System.Drawing.Point(19, 131);
            this.lblDebitAmount.Name = "lblDebitAmount";
            this.lblDebitAmount.Size = new System.Drawing.Size(43, 13);
            this.lblDebitAmount.TabIndex = 4;
            this.lblDebitAmount.Text = "Amount";
            // 
            // grpDebit
            // 
            this.grpDebit.Controls.Add(this.txtDebitAmount);
            this.grpDebit.Controls.Add(this.txtDescription);
            this.grpDebit.Controls.Add(this.txtDebitAccNo);
            this.grpDebit.Controls.Add(this.txtDebitSortCode);
            this.grpDebit.Controls.Add(this.txtDebitName);
            this.grpDebit.Controls.Add(this.lblDebitName);
            this.grpDebit.Controls.Add(this.lblDescription);
            this.grpDebit.Controls.Add(this.lblDebitAmount);
            this.grpDebit.Controls.Add(this.lblDebitAccNo);
            this.grpDebit.Controls.Add(this.lblDebitSortCode);
            this.grpDebit.Location = new System.Drawing.Point(12, 12);
            this.grpDebit.Name = "grpDebit";
            this.grpDebit.Size = new System.Drawing.Size(273, 172);
            this.grpDebit.TabIndex = 6;
            this.grpDebit.TabStop = false;
            this.grpDebit.Text = "Debit";
            // 
            // txtDebitAmount
            // 
            this.txtDebitAmount.Location = new System.Drawing.Point(112, 128);
            this.txtDebitAmount.Name = "txtDebitAmount";
            this.txtDebitAmount.Size = new System.Drawing.Size(131, 20);
            this.txtDebitAmount.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 102);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(131, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtDebitAccNo
            // 
            this.txtDebitAccNo.Location = new System.Drawing.Point(112, 50);
            this.txtDebitAccNo.Name = "txtDebitAccNo";
            this.txtDebitAccNo.Size = new System.Drawing.Size(131, 20);
            this.txtDebitAccNo.TabIndex = 7;
            // 
            // txtDebitSortCode
            // 
            this.txtDebitSortCode.Location = new System.Drawing.Point(112, 76);
            this.txtDebitSortCode.Name = "txtDebitSortCode";
            this.txtDebitSortCode.Size = new System.Drawing.Size(131, 20);
            this.txtDebitSortCode.TabIndex = 6;
            // 
            // txtDebitName
            // 
            this.txtDebitName.Location = new System.Drawing.Point(112, 24);
            this.txtDebitName.Name = "txtDebitName";
            this.txtDebitName.Size = new System.Drawing.Size(131, 20);
            this.txtDebitName.TabIndex = 5;
            // 
            // grpCredit
            // 
            this.grpCredit.Controls.Add(this.txtCreditName);
            this.grpCredit.Controls.Add(this.lblCreditName);
            this.grpCredit.Controls.Add(this.txtCreditAccNo);
            this.grpCredit.Controls.Add(this.txtCreditSortCode);
            this.grpCredit.Controls.Add(this.lblCreditSortCode);
            this.grpCredit.Controls.Add(this.lblCreditAccNo);
            this.grpCredit.Location = new System.Drawing.Point(307, 12);
            this.grpCredit.Name = "grpCredit";
            this.grpCredit.Size = new System.Drawing.Size(266, 172);
            this.grpCredit.TabIndex = 7;
            this.grpCredit.TabStop = false;
            this.grpCredit.Text = "Credit";
            // 
            // txtCreditName
            // 
            this.txtCreditName.Enabled = false;
            this.txtCreditName.Location = new System.Drawing.Point(120, 24);
            this.txtCreditName.Name = "txtCreditName";
            this.txtCreditName.Size = new System.Drawing.Size(131, 20);
            this.txtCreditName.TabIndex = 12;
            // 
            // lblCreditName
            // 
            this.lblCreditName.AutoSize = true;
            this.lblCreditName.Location = new System.Drawing.Point(31, 27);
            this.lblCreditName.Name = "lblCreditName";
            this.lblCreditName.Size = new System.Drawing.Size(35, 13);
            this.lblCreditName.TabIndex = 11;
            this.lblCreditName.Text = "Name";
            // 
            // txtCreditAccNo
            // 
            this.txtCreditAccNo.Enabled = false;
            this.txtCreditAccNo.Location = new System.Drawing.Point(120, 76);
            this.txtCreditAccNo.Name = "txtCreditAccNo";
            this.txtCreditAccNo.Size = new System.Drawing.Size(131, 20);
            this.txtCreditAccNo.TabIndex = 10;
            // 
            // txtCreditSortCode
            // 
            this.txtCreditSortCode.Enabled = false;
            this.txtCreditSortCode.Location = new System.Drawing.Point(120, 128);
            this.txtCreditSortCode.Name = "txtCreditSortCode";
            this.txtCreditSortCode.Size = new System.Drawing.Size(131, 20);
            this.txtCreditSortCode.TabIndex = 9;
            // 
            // lblCreditSortCode
            // 
            this.lblCreditSortCode.AutoSize = true;
            this.lblCreditSortCode.Location = new System.Drawing.Point(31, 131);
            this.lblCreditSortCode.Name = "lblCreditSortCode";
            this.lblCreditSortCode.Size = new System.Drawing.Size(54, 13);
            this.lblCreditSortCode.TabIndex = 6;
            this.lblCreditSortCode.Text = "Sort Code";
            // 
            // lblCreditAccNo
            // 
            this.lblCreditAccNo.AutoSize = true;
            this.lblCreditAccNo.Location = new System.Drawing.Point(31, 79);
            this.lblCreditAccNo.Name = "lblCreditAccNo";
            this.lblCreditAccNo.Size = new System.Drawing.Size(67, 13);
            this.lblCreditAccNo.TabIndex = 7;
            this.lblCreditAccNo.Text = "Account No.";
            // 
            // btnProcessTransfer
            // 
            this.btnProcessTransfer.Location = new System.Drawing.Point(466, 190);
            this.btnProcessTransfer.Name = "btnProcessTransfer";
            this.btnProcessTransfer.Size = new System.Drawing.Size(107, 39);
            this.btnProcessTransfer.TabIndex = 8;
            this.btnProcessTransfer.Text = "Process Transfer";
            this.btnProcessTransfer.UseVisualStyleBackColor = true;
            this.btnProcessTransfer.Click += new System.EventHandler(this.btnProcessTransfer_Click);
            // 
            // ProcessTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 238);
            this.Controls.Add(this.btnProcessTransfer);
            this.Controls.Add(this.grpCredit);
            this.Controls.Add(this.grpDebit);
            this.Name = "ProcessTransfer";
            this.Text = "Transfer";
            this.grpDebit.ResumeLayout(false);
            this.grpDebit.PerformLayout();
            this.grpCredit.ResumeLayout(false);
            this.grpCredit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDebitName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDebitAccNo;
        private System.Windows.Forms.Label lblDebitSortCode;
        private System.Windows.Forms.Label lblDebitAmount;
        private System.Windows.Forms.GroupBox grpDebit;
        private System.Windows.Forms.GroupBox grpCredit;
        private System.Windows.Forms.Button btnProcessTransfer;
        private System.Windows.Forms.Label lblCreditSortCode;
        private System.Windows.Forms.Label lblCreditAccNo;
        private System.Windows.Forms.TextBox txtDebitAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDebitAccNo;
        private System.Windows.Forms.TextBox txtDebitSortCode;
        private System.Windows.Forms.TextBox txtDebitName;
        private System.Windows.Forms.TextBox txtCreditAccNo;
        private System.Windows.Forms.TextBox txtCreditSortCode;
        private System.Windows.Forms.Label lblCreditName;
        private System.Windows.Forms.TextBox txtCreditName;
    }
}