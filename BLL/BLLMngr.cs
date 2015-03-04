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
    }
}
