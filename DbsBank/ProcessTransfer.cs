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

        public ProcessTransfer()
        {
            InitializeComponent();
        }

        private void btnProcessTransfer_Click(object sender, EventArgs e)
        {
            BLLMngr bllMngr = new BLLMngr();
            string type = "Transfer";

            TransactionModel debtor = new TransactionModel(DebtorID, Amount, type, Description);
            bllMngr.CreateTransaction(debtor);
            int debID = bllMngr.TransactionID;
            TransactionModel creditor = new TransactionModel(CreditorID, Amount, type, Description);
            bllMngr.CreateTransaction(creditor);
            int credID = bllMngr.TransactionID;

            TransferModel transfer = new TransferModel(debID, credID, CreditorSortCode, CreditorAccountNumber);

            bllMngr.CreateTransfer(credID, debID, transfer);

            MessageBox.Show("Transfer Complete");
            
        }

        private void ProcessTransfer_Load(object sender, EventArgs e)
        {
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
