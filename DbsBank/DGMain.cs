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
        public DGMain()
        {
            InitializeComponent();
        }

        private void PrimeMainGrid()
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
            using(ProcessTransaction procTrans = new ProcessTransaction())
            {
                procTrans.ShowDialog();
            }
        }
    }
}
