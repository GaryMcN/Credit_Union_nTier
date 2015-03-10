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
                tr.ShowDialog();
                this.Close();
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AddCustomer AddCust = new AddCustomer())
            {
                AddCust.ShowDialog();
            }
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditCustomer EditCust = new EditCustomer())
            {
                EditCust.ShowDialog();
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
                    //Textboxes Set To Public//
                    procTrans.SetType(2);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
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
                    procTrans.SetType(1);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
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
                    procTrans.SetType(0);
                    PassDetailsFromDgv(procTrans);
                    procTrans.ShowDialog();
                }
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
            procTrans.AccountID = (int)dgvMain.SelectedRows[selectedRow].Cells[0].Value;
            procTrans.Balance = (int)dgvMain.SelectedRows[selectedRow].Cells[8].Value;
        }
    }
}
