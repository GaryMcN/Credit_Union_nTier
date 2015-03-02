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
        public ProcessTransaction()
        {
            InitializeComponent();
        }

        private void ProcessTransaction_Load(object sender, EventArgs e)
        {
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
