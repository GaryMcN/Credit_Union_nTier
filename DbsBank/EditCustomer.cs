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
    public partial class EditCustomer : Form
    {
        public bool EditOnly { get; set; }

        public EditCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
