using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using BLL;

namespace DbsBank
{
    public partial class EditCustomer : Form
    {
        // Public variables for access in DGMain //
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
        public string InitialBalance { get; set; }
        public string OverdraftLimit { get; set; }
        public string AccountID { get; set; }
        public string CustomerID { get; set; }

        public bool EditOnly { get; set; }

        public EditCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLLMngr bllMngr = new BLLMngr();
            int acNum;
            int.TryParse(AccountNo, out acNum);
            int sortCode;
            int.TryParse(SortCode, out sortCode);
            int initBal;
            int.TryParse(InitialBalance, out initBal);
            int oDLim;
            int.TryParse(OverdraftLimit, out oDLim);
            int accountID;
            int.TryParse(AccountID, out accountID);
            int customerID;
            int.TryParse(CustomerID, out customerID);

            FirstName = txtFirstName.Text;
            Surname = txtSurname.Text;
            Email = txtEmail.Text;
            Phone = txtPhone.Text;
            Address1 = txtAddress1.Text;
            Address2 = txtAddress2.Text;
            City = txtCity.Text;
            County = cboCounty.Text;

            if (rdoCurrent.Checked)
            {
                AccountType = "Current";
            }
            else if (rdoSavings.Checked)
            {
                AccountType = "Savings";
            }
            AccountModel account = new AccountModel(accountID, AccountType, acNum, sortCode, initBal, oDLim);
            CustomerModel customer = new CustomerModel(customerID, FirstName, Surname, Email, Phone, Address1, Address2, City, County);

            bllMngr.UpdateCustomersAccount(customer, account);
            MessageBox.Show("Customer Updated");
            
            this.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtSurname.Enabled = false;
            txtInitialBalance.Enabled = false;
            rdoCurrent.Enabled = false;
            rdoSavings.Enabled = false;
            txtAccountNo.Enabled = false;
            txtSortCode.Enabled = false;

            txtFirstName.Text = FirstName;
            txtSurname.Text = Surname;
            txtEmail.Text = Email;
            txtPhone.Text = Phone;
            txtAddress1.Text = Address1;
            txtAddress2.Text = Address2;
            txtCity.Text = City;
            cboCounty.Text = County;
            txtAccountNo.Text = AccountNo;
            txtSortCode.Text = SortCode;
            txtInitialBalance.Text = InitialBalance;
            txtOverdraftLimit.Text = OverdraftLimit;

            if (AccountType == "Current")
            {
                rdoCurrent.Checked = true;
            }
            else
            {
                rdoSavings.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
