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

namespace DbsBank
{
    public partial class ProcessTransaction : Form
    {
        public int accountID;
        public int balance;

        public ProcessTransaction()
        {
            InitializeComponent();
        }

        private void ProcessTransaction_Load(object sender, EventArgs e)
        {
            string sort = ConfigurationManager.AppSettings["SortCode"];
            txtSortCode.Text += sort;
            // THIS APPENDS INSTEAD OF VALIDATING //
            string cent = ConfigurationManager.AppSettings["Cent"];
            txtAmountCent.Text += cent;
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
            if(cboType.SelectedIndex == 2 || cboType.SelectedIndex == 1)
            {
                // Do the withdrawal/deposit
                // TRANSACTION DETAILS //
                string type = cboType.Text;
                string description = txtDescription.Text;
                string amountEuro = txtAmountEuro.Text.Trim();
                string amountCent = txtAmountCent.Text.Trim();
                string amountString = amountEuro + amountCent;
                int amount;
                int.TryParse(amountString, out amount);

                // Transaction obj created //
                TransactionModel transaction = new TransactionModel(accountID, amount, type, description);

                // BLL instanciated //
                BLLMngr bllMngr = new BLLMngr();
                bllMngr.CreateTransaction(transaction);

                MessageBox.Show("Transfer Complete");
            }
            else if(cboType.SelectedIndex == 0)
            {
                using(ProcessTransfer procTransfer = new ProcessTransfer())
                {
                    //put values from previous form in here//
                    procTransfer.ShowDialog();
                }
            }
        }

        public void SetType(int val)
        {
            cboType.SelectedIndex = val;
        }
    }
}
