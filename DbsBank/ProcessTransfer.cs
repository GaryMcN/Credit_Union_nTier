using BLL;
using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbsBank
{
    public partial class ProcessTransfer : Form
    {
        #region Global Variables

        public int CreditorID { get; set; }
        public int DebtorID { get; set; }
        public int CreditorAccountNumber { get; set; }
        public int CreditorSortCode { get; set; }
        public string DebtorName { get; set; }
        public int DebtorAccountNumber { get; set; }
        public int DebtorSortCode { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int DebtorBalance { get; set; }
        public int CreditorBalance { get; set; }
        
        #endregion

        public ProcessTransfer()
        {
            InitializeComponent();
        }

        private void btnProcessTransfer_Click(object sender, EventArgs e)
        {
            BLLMngr bllMngr = new BLLMngr();
            string type = "Transfer";

            // Creating debtor and creditor models and adding two transactions to DB
            TransactionModel debtor = new TransactionModel(DebtorID, Amount, type, Description);
            bllMngr.CreateTransaction(debtor);
            int debID = bllMngr.TransactionID; // Taking Id from debtor transaction

            TransactionModel creditor = new TransactionModel(CreditorID, Amount, type, Description);
            bllMngr.CreateTransaction(creditor);
            int credID = bllMngr.TransactionID; // Taking ID from creditor transaction

            TransferModel transfer = new TransferModel(debID, credID, CreditorSortCode, CreditorAccountNumber);

            CreditorBalance += Amount;
            DebtorBalance -= Amount;

            // Creating models so that balance may be updated in UpdateAccountBalance() below
            AccountModel credAcc = new AccountModel(CreditorID, CreditorBalance);
            AccountModel debAcc = new AccountModel(DebtorID, DebtorBalance);

            bllMngr.CreateTransfer(credID, debID, transfer);
            bllMngr.UpdateAccountBalance(debAcc);
            bllMngr.UpdateAccountBalance(credAcc);

            MessageBox.Show("Transfer Complete");

            this.Close();
        }

        private void ProcessTransfer_Load(object sender, EventArgs e)
        {
            // Assigning values from public properties to text boxes
            txtCreditAccNo.Text = CreditorAccountNumber.ToString();
            txtCreditSortCode.Text = CreditorSortCode.ToString();
            txtDebitAccNo.Text = DebtorAccountNumber.ToString();
            txtDebitName.Text = DebtorName;
            txtDebitSortCode.Text = DebtorSortCode.ToString();
            txtDescription.Text = Description;
            txtDebitAmount.Text = Amount.ToString();
        }
    }
}
