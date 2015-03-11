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

namespace DbsBank
{
    public partial class DGMain : Form
    {
        int selectedRow;

        public DGMain()
        {
            InitializeComponent();
        }

        public void PrimeMainGrid()
        {
            BLLMngr bllManager = new BLLMngr();
            DataSet ds = bllManager.GetCustomerAccounts();
            //clearing then populating data source//
            dgvMain.DataSource = null;
            dgvMain.DataSource = ds.Tables[0];
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LogIn lg = new LogIn())
            {
                lg.ShowDialog();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Transactions tr = new Transactions())
            {
                this.Hide();
                tr.ShowDialog();
            }
            this.Show();
            PrimeMainGrid();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AddCustomer AddCust = new AddCustomer())
            {
                this.Hide();
                AddCust.ShowDialog();
            }
            //priming the same datagrid//
            this.Show();
            PrimeMainGrid();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditCustomer EditCust = new EditCustomer())
            {
                if (dgvMain.SelectedRows.Count == 1)
                {
                    // START HERE TOMORROW //
                    BLLMngr bll = new BLLMngr();
                    DataTable CustomerDetails = bll.GetFullAccountDetails((int)dgvMain.SelectedRows[selectedRow].Cells[0].Value);


                    //EditCustomer editCust = new EditCustomer();

                    foreach (DataRow row in CustomerDetails.Rows)
                    {
                        EditCust.FirstName = row["FirstName"].ToString();
                        EditCust.Surname = row["Surname"].ToString();
                        EditCust.Email = row["Email"].ToString();
                        EditCust.Phone = row["Phone"].ToString();
                        EditCust.Address1 = row["Address1"].ToString();
                        EditCust.Address2 = row["Address2"].ToString();
                        EditCust.City = row["City"].ToString();
                        EditCust.County = row["County"].ToString();
                        EditCust.AccountType = row["AccountType"].ToString();
                        EditCust.AccountNo = row["AccountNumber"].ToString();
                        EditCust.SortCode = row["SortCode"].ToString();
                        EditCust.InitialBalance = row["Balance"].ToString();
                        EditCust.OverdraftLimit = row["OverdraftLimit"].ToString();
                    }
                    

                    EditCust.ShowDialog();
                }
            }
        }

        private void DGMain_Load(object sender, EventArgs e)
        {
            PrimeMainGrid();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                using (ProcessTransaction procTrans = new ProcessTransaction())
               {
                    this.Hide();
                    //Textboxes Set To Public//
                    procTrans.SetType(2);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
                this.Show();
                PrimeMainGrid();
            }
            else if (dgvMain.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single account");
            }
            else if (dgvMain.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an account");
            }
            else
            {
                MessageBox.Show("Error, Please try again");
            }
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                using (ProcessTransaction procTrans = new ProcessTransaction())
                {
                    this.Hide();
                    procTrans.SetType(1);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
                this.Show();
                PrimeMainGrid();
            }
            else if (dgvMain.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single account");
            }
            else if (dgvMain.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an account");
            }
            else
            {
                MessageBox.Show("Error, Please try again");
            }
        }

        private void transferFunsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {

                using (ProcessTransaction procTrans = new ProcessTransaction())
                {
                    this.Hide();
                    procTrans.SetType(0);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
                this.Show();
                PrimeMainGrid();
            }
            else if (dgvMain.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select a single account");
            }
            else if (dgvMain.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an account");
            }
            else
            {
                MessageBox.Show("Error, Please try again");
            }
        }

        private int GetSelectedCustomerAccount()
        {
            int accountID;
            int columnIndex = 0;
            int rowIndex;

            rowIndex = (int)dgvMain.SelectedRows[0].Index;
            accountID = (int)dgvMain.Rows[rowIndex].Cells[columnIndex].Value;

            return accountID;
        }

        private void PassDetailsFromDgv(ProcessTransaction procTrans)
        {
            procTrans.txtName.Text = (dgvMain.SelectedRows[selectedRow].Cells[1].Value + " " + dgvMain.SelectedRows[selectedRow].Cells[2].Value);
            procTrans.txtAccountNumber.Text = dgvMain.SelectedRows[selectedRow].Cells[6].Value.ToString();
            procTrans.accountID = (int)dgvMain.SelectedRows[selectedRow].Cells[0].Value;
            procTrans.balance = (int)dgvMain.SelectedRows[selectedRow].Cells[8].Value;
            procTrans.overdraftLimit = (int)dgvMain.SelectedRows[selectedRow].Cells[9].Value;
        }
    }
}
