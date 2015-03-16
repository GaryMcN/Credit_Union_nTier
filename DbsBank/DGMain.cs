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
    public partial class DGMain : Form
    {
        //Global Variables and Object
        ProcessTransaction procTrans = new ProcessTransaction();
        int selectedRow = 0;

        public DGMain()
        {
            InitializeComponent();
        }

        // Method for populating and refreshing the Data Grid
        public void PrimeMainGrid()
        {
            BLLMngr bllManager = new BLLMngr();

            // Getting Customer Accounts dataset from Database
            DataSet ds = bllManager.GetCustomerAccounts();
            dgvMain.DataSource = null;
            dgvMain.DataSource = ds.Tables[0]; // Dataset assigned to Datagrid
        }



        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LogIn lg = new LogIn())
            {
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (LogIn lg = new LogIn())
            {
                lg.Close();
            }
            this.Close();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Transactions tr = new Transactions())
            {
                // Make sure the user selects only one row
                if(dgvMain.SelectedRows.Count == 1)
                {
                    //get cell from dgvmain convert to int//
                    int id = Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells["AccountID"].Value);
                    //pass that int to transactions form so it may populate its datagrids
                    tr.GetAccountID(id);
                    this.Hide();
                    tr.ShowDialog();
                }
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
                    BLLMngr bll = new BLLMngr();

                    // Method to pull full customer details of one customer from database and return a DataTable
                    DataTable CustomerDetails = bll.GetFullAccountDetails((int)dgvMain.SelectedRows[selectedRow].Cells[0].Value);

                    // Assigning fields from the table to variables inside EditCustomer form
                    // These variables are then used to pre-populate the form
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
                        EditCust.AccountID = row["AccountID"].ToString();
                        EditCust.CustomerID = row["CustomerID"].ToString();
                    }

                    this.Hide();
                    EditCust.ShowDialog();
                }
            }
            this.Show();
            PrimeMainGrid();
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
                    // Using SetType() method inside of ProcessTransaction to set the combo box index
                    procTrans.SetType(2);
                    // Uses details from Datagrid to populate ProcessTransaction form
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
        
        private void transferFundsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                procTrans.SetType(0);
                PassDetailsFromDgv(procTrans);
                procTrans.ShowDialog();
                this.Show();
                PrimeMainGrid();
            }
            
        }

        private void PassDetailsFromDgv(ProcessTransaction procTrans)
        {
            //Populates public fields and variables in ProcessTransaction with details from the datagrid
            procTrans.txtName.Text = (dgvMain.SelectedRows[selectedRow].Cells[1].Value + " " + dgvMain.SelectedRows[selectedRow].Cells[2].Value);
            procTrans.txtAccountNumber.Text = dgvMain.SelectedRows[selectedRow].Cells[6].Value.ToString();
            procTrans.accountID = (int)dgvMain.SelectedRows[selectedRow].Cells[0].Value;
            procTrans.balance = (int)dgvMain.SelectedRows[selectedRow].Cells[8].Value;
            procTrans.overdraftLimit = (int)dgvMain.SelectedRows[selectedRow].Cells[9].Value;
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                // Setting relative location for XML file to be saved to
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/CustomerXML.xml";
                 
                int id = Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells["AccountID"].Value);
                
                BLLMngr bllMngr = new BLLMngr();
                DataTable dt = bllMngr.GetFullAccountDetails(id);
                dt.TableName = "CustomerXML";
                StreamWriter sW = new StreamWriter(path);
                dt.WriteXml(sW);
                MessageBox.Show("Customer Serialized");
            }
            else
            {
                MessageBox.Show("Please Select An Account");
            }
        }
    }
}
