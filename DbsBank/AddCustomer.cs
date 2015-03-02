using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DataModels;
using System.IO;

namespace DbsBank
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // CUSTOMER INFO //
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text.ToString();
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            string city = txtCity.Text;
            string county = cboCounty.SelectedItem.ToString();

            // ACCOUNT INFO //
            int accountNo = 0;
            int.TryParse(txtAccountNo.Text, out accountNo);
            int sortCode = 0;
            int.TryParse(txtSortCode.Text, out sortCode);
            int initialBalance;
            int.TryParse(txtInitialBalance.Text, out initialBalance);
            int overDraftLimit;
            int.TryParse(txtOverdraftLimit.Text, out overDraftLimit);
            string accountType = "";
            if (rdoCurrent.Checked)
            {
                accountType = "Current";
            }
            else if (rdoSavings.Checked)
            {
                accountType = "Savings";
            }

            // Creating two Objects //
            CustomerModel customer = new CustomerModel(firstName, surname, email, phone, address1, address2, city, county);
            AccountModel account = new AccountModel(accountType, accountNo, sortCode, initialBalance, overDraftLimit);

            // Sending to BLL //
            BLLMngr bllMngr = new BLLMngr();
            bllMngr.CreateCustomerAccount(customer, account);

            MessageBox.Show("Customer Account Added");
        }

        private void rdoSavings_CheckedChanged(object sender, EventArgs e)
        {
            txtOverdraftLimit.Enabled = false;
            txtOverdraftLimit.Text = "0";
        }

        private void rdoCurrent_CheckedChanged(object sender, EventArgs e)
        {
            txtOverdraftLimit.Enabled = true;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // Dropdown Styling (Cannot be typed into) //
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}