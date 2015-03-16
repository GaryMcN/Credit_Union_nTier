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
using System.Configuration;
using System.Text.RegularExpressions;

namespace DbsBank
{
    public partial class AddCustomer : Form
    {
        string email;
        int accountNo;
        int overDraftLimit;
        string phone;

        string emailRegex = ConfigurationManager.AppSettings["EmailRegex"];
        string positiveNums = ConfigurationManager.AppSettings["PositiveRegex"];
        string account8Digits = ConfigurationManager.AppSettings["Account8Digits"];
        string centRegex = ConfigurationManager.AppSettings["Cent"];
        string euroRegex = ConfigurationManager.AppSettings["Euro"];
        string sort = ConfigurationManager.AppSettings["SortCode"];

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtSortCode.Text += sort;
            cboCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCounty.SelectedIndex = 1;
            txtFirstName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // CUSTOMER INFO //
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string address1 = txtAddress1.Text;
            string address2 = txtAddress2.Text;
            string city = txtCity.Text;
            string county = cboCounty.SelectedItem.ToString();

            // ACCOUNT INFO //
            accountNo = 0;
            int.TryParse(txtAccountNo.Text, out accountNo);
            int sortCode = 0;
            int.TryParse(txtSortCode.Text, out sortCode);
            string amountEuro = txtAmountEuro.Text.Trim();
            string amountCent = txtAmountCent.Text.Trim();
            string amountString = amountEuro + amountCent;
            int amount;
            int.TryParse(amountString, out amount);


            string accountType = "";
            if (rdoCurrent.Checked)
            {
                accountType = "Current";
            }
            else if (rdoSavings.Checked)
            {
                accountType = "Savings";
            }

            // TRANSACTION INFO //
            string description = "Initial Transaction";
            
            string type = "Deposit";

            // Creating three Objects //
            CustomerModel customer = new CustomerModel(firstName, surname, email, phone, address1, address2, city, county);
            AccountModel account = new AccountModel(accountType, accountNo, sortCode, amount, overDraftLimit);
            TransactionModel transaction = new TransactionModel(amount, type, description);

            // Sending to BLL //
            BLLMngr bllMngr = new BLLMngr();
            bllMngr.CreateCustomerAccount(customer, account, transaction);

            MessageBox.Show("Customer Account Added");

            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (DGMain dgMain = new DGMain())
            {
                this.Hide();
                dgMain.ShowDialog();
            }
        }

        #region Form Validation

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailRegex))
            {
                email = txtEmail.Text;
            }
            else if (string.IsNullOrWhiteSpace(txtAccountNo.Text))
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Focus();
            }
        }

        private void txtAccountNo_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtAccountNo.Text, account8Digits))
            {
                int.TryParse(txtAccountNo.Text, out accountNo);
            }
            else if (string.IsNullOrWhiteSpace(txtAccountNo.Text) || !Regex.IsMatch(txtAccountNo.Text, account8Digits))
            {
                MessageBox.Show("Account Number Must Be 8 Digits");
                txtAccountNo.Focus();
            }
            
        }

        private void txtOverdraftLimit_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtOverdraftLimit.Text, positiveNums))
            {
                int.TryParse(txtOverdraftLimit.Text, out overDraftLimit);
            }
            else
            {
                MessageBox.Show("Overdraft Cannot Be Negative");
                txtOverdraftLimit.Focus();
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name Required");
                txtFirstName.Focus();
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname Required");
                txtSurname.Focus();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text, positiveNums))
            {
                MessageBox.Show("Phone Number Is Required And Must Be Numeric");
                txtPhone.Focus();
            }
            else
            {
                phone = txtPhone.Text;
            }
        }

        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress1.Text))
            {
                MessageBox.Show("Address 1 Required");
                txtAddress1.Focus();
            }
        }

        private void txtAddress2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress2.Text))
            {
                MessageBox.Show("Address 2 Required");
                txtAddress2.Focus();
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("City Required");
                txtCity.Focus();
            }
        }

        private void txtAmountEuro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmountEuro.Text) || !Regex.IsMatch(txtAmountEuro.Text, euroRegex))
            {
                MessageBox.Show("Euro Amount Is Required And Must Be Numeric");
                txtAmountEuro.Focus();
            }
        }

        private void txtAmountCent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmountCent.Text) || !Regex.IsMatch(txtAmountCent.Text, centRegex))
            {
                MessageBox.Show("Cent Amount Is Required And Must Be Numeric");
                txtAmountEuro.Focus();
            }
        }

        #endregion
    }
}