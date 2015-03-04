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
    public partial class ProcessTransaction : Form
    {
        bool transfer = false;

        public ProcessTransaction()
        {
            InitializeComponent();
        }

        private void ProcessTransaction_Load(object sender, EventArgs e)
        {
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedItem.ToString() == "Transfer")
            {
                transfer = true;
                txtRecipientAccNo.Enabled = true;
                txtRecipientSortCode.Enabled = true;
            }
            else
            {
                transfer = false;
                txtRecipientAccNo.Enabled = false;
                txtRecipientSortCode.Enabled = false;
                txtRecipientAccNo.Clear();
                txtRecipientSortCode.Clear();
            }
        }

        private void btnProcessTransaction_Click(object sender, EventArgs e)
        {
            if(transfer)
            {
                using(ProcessTransfer procTrans = new ProcessTransfer())
                {
                    procTrans.ShowDialog();
                }
            }
            else
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
     

                // Transaction created //
                TransactionModel tm = new TransactionModel(amount, type, description);
            }
        }

        public void SetType(int val)
        {
            cboType.SelectedIndex = val;
        }
    }
}
