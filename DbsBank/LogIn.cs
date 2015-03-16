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
            // Local Variables // 
            string pass;
            string user;
            string passHash;
            bool isValid;

            pass = txtPassword.Text;
            user = txtUser.Text;

            // Calling Encryption method from the BLL, this takes a password and returns the encrypted string
            BLLMngr bllMngr = new BLLMngr();
            passHash = bllMngr.PassEncrypt(pass);

            //Instanciating a user 
            UserModel userDetails = new UserModel(user, passHash);

            //Sending details (UserName and password) through BLL and DAL for validation at the database
            isValid = bllMngr.IsValidLogin(userDetails);

            //If it comes back as a valid user allow access and go to main DataGrid
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
