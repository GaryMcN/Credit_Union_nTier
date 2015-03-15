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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidate();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginValidate();
        }

        private void LoginValidate()
        {
            string pass;
            string user;
            string passHash;
            bool isValid;

            pass = txtPassword.Text;
            user = txtUser.Text;

            BLLMngr bllMngr = new BLLMngr();
            passHash = bllMngr.PassEncrypt(pass);

            UserModel userDetails = new UserModel(user, passHash);

            isValid = bllMngr.IsValidLogin(userDetails);

            if (isValid)
            {
                MessageBox.Show("Welcome To DBS Credit Union");
                using (DGMain dgm = new DGMain())
                {
                    this.Hide();
                    dgm.ShowDialog();
                }
                this.Show();
                txtPassword.Clear();
                txtUser.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
