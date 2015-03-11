using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DataModels;
using System.IO;

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
    }
}
