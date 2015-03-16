using BLL;
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
    public partial class Transactions : Form
    {
        int ID;

        public Transactions()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DGMain dgm = new DGMain())
            {
                this.Close();
            }
        }

        //Get AccountID from DGMain
        public void GetAccountID(int id)
        {
            ID = id;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            BLLMngr bllManager = new BLLMngr();
            //Taking ID from global variables (populated by GetAccountID()) 
            //Which gets the account ID from dgvMain
            DataSet ds = bllManager.AuditAccount(ID);
            //clearing then populating data source//
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = ds.Tables[0];
        }
    }
}
