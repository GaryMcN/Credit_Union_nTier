using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DataModels;
using System.IO;
using System.Security.Cryptography;

namespace BLL
{
    public class BLLMngr
    {
        // Taking Objects from AddCustomer //
        public void CreateCustomerAccount(CustomerModel newCustomer, AccountModel newAccount, TransactionModel newTransaction)
        {
            // Sending to DAL //
            DALMngr dalMngr = new DALMngr();
            dalMngr.CreateCustomerAccount(newCustomer, newAccount, newTransaction);
        }

        public void CreateTransaction(TransactionModel newTransaction)
        {
            DALMngr dalMngr = new DALMngr();
            dalMngr.CreateTransaction(newTransaction);
        }

        public DataSet AuditAccount(int id)
        {
            DataSet ds = null;
            DALMngr dalMngr = new DALMngr();
            try
            {
                ds = dalMngr.AuditAccount(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public DataSet GetCustomerAccounts()
        {
            DataSet ds = null;
            DALMngr dalManager = new DALMngr();
            try
            {
                ds = dalManager.GetCustomerAccounts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public void UpdateAccountBalance(AccountModel accountToUpdate)
        {
            DALMngr dalMngr = new DALMngr();
            dalMngr.UpdateAccountBalance(accountToUpdate);
        }

        public bool ValidateWithdrawal(int balance, int overdraftLimit, int withdrawAmount)
        {
            bool isValid;
            int availableFunds = balance + overdraftLimit;

            if(availableFunds >= withdrawAmount)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        public DataTable GetFullAccountDetails(int accountID)
        {
            DataTable dt = null;
            DALMngr dalManager = new DALMngr();
            try
            {
                dt = dalManager.GetFullCustomerDetails(accountID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public bool IsValidLogin(UserModel userDetails)
        {
            bool isValid;
            bool valid;
            DALMngr dalMngr = new DALMngr();
            valid = dalMngr.IsValidLogin(userDetails);
            if(valid)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        public string PassEncrypt(string passWord)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(passWord));
            StringBuilder encryptedPassword = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                encryptedPassword.Append(hashdata[i].ToString());
            }
            return encryptedPassword.ToString();
        }

        public void UpdateCustomersAccount(CustomerModel customer, AccountModel account)
        {
            DALMngr dalMngr = new DALMngr();
            dalMngr.UpdateCustomersAccount(customer, account);

        }
    }
}
