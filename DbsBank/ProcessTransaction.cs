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
using System.Configuration;
using BLL;
using System.Text.RegularExpressions;

namespace DbsBank
{
    public partial class ProcessTransaction : Form
    {
        public int accountID;
        public int balance;
        public int overdraftLimit;
        string centRegEx = ConfigurationManager.AppSettings["Cent"];
        

        public ProcessTransaction()
        {
            InitializeComponent();
        }

        private void ProcessTransaction_Load(object sender, EventArgs e)
        {
            string sort = ConfigurationManager.AppSettings["SortCode"];
            txtSortCode.Text += sort;
            // THIS APPENDS INSTEAD OF VALIDATING //
            //string centRegEx = ConfigurationManager.AppSettings["Cent"];
            //txtAmountCent.Text += cent;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedItem.ToString() == "Transfer")
            {
                txtRecipientAccNo.Enabled = true;
                txtRecipientSortCode.Enabled = true;
            }
            else
            {
                txtRecipientAccNo.Enabled = false;
                txtRecipientSortCode.Enabled = false;
                txtRecipientAccNo.Clear();
                txtRecipientSortCode.Clear();
            }
        }

        private void btnProcessTransaction_Click(object sender, EventArgs e)
        {
            // TRANSACTION DETAILS //
            string type = cboType.Text;
            string description = txtDescription.Text;
            string amountEuro = txtAmountEuro.Text.Trim();
            string amountCent = "00";

            if(Regex.IsMatch(txtAmountCent.Text, centRegEx))
            {
                amountCent = txtAmountCent.Text;
            }
            else
            {
                MessageBox.Show("Invalid cent amount: Cents set to zero");
            }

            string amountString = amountEuro + amountCent;
            int amount;
            int.TryParse(amountString, out amount);
            //method used to update the balance in users account
            int currentBalance = CurrentBalance(balance, amount);

            // Account obj created to update the balance //
            AccountModel account = new AccountModel(accountID, currentBalance);

            // Transaction obj created //
            TransactionModel transaction = new TransactionModel(accountID, amount, type, description);

            // BLL instanciated //
            BLLMngr bllMngr = new BLLMngr();

            if(cboType.SelectedIndex == 2)
            {
                bllMngr.CreateTransaction(transaction);
                bllMngr.UpdateAccountBalance(account);
                MessageBox.Show("Deposit Complete");
            }
            else if(cboType.SelectedIndex == 1)
            {
                if (bllMngr.ValidateWithdrawal(balance, overdraftLimit, amount))
                {
                    bllMngr.CreateTransaction(transaction);
                    bllMngr.UpdateAccountBalance(account);
                    MessageBox.Show("Withdrawal Complete");
                }
                else
                {
                    MessageBox.Show("Insifficient Funds");
                }
            }
            else if(cboType.SelectedIndex == 0)
            {
                using(ProcessTransfer procTransfer = new ProcessTransfer())
                {
                    //put values from previous form in here//
                    procTransfer.ShowDialog();
                }
            }

            this.Close();
        }

        public void SetType(int val)
        {
            cboType.SelectedIndex = val;
        }

        // method only used in withdraw or deposite for updating the account balance of a customer
        public int CurrentBalance(int balance, int amount)
        {
            if (cboType.SelectedIndex == 2)
            {
                return (balance + amount);
            }
            else
            {
                return (balance - amount);
            }
        }
    }
}
