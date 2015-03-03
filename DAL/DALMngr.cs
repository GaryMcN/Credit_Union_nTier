using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataModels;
using System.Configuration;
using System.IO;

namespace DAL
{
    public class DALMngr
    {
        string cxnString = ConfigurationManager.ConnectionStrings["DbsDB"].ConnectionString;

        public void CreateCustomerAccount(CustomerModel newCustomer, AccountModel newAccount)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                SqlCommand cmdCustomer = new SqlCommand("spAddCustomer", cxn);
                cmdCustomer.CommandType = CommandType.StoredProcedure;

                SqlParameter firstNameParam = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
                firstNameParam.Value = newCustomer.FirstName;

                SqlParameter surnameParam = new SqlParameter("@Surname", SqlDbType.NVarChar, 50);
                surnameParam.Value = newCustomer.Surname;

                SqlParameter emailParam = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                emailParam.Value = newCustomer.Email;

                SqlParameter phoneParam = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                phoneParam.Value = newCustomer.Phone;

                SqlParameter add1Param = new SqlParameter("@Address1", SqlDbType.NVarChar, 50); // will change to address 1 in db
                add1Param.Value = newCustomer.Address1;

                SqlParameter add2Param = new SqlParameter("@Address2", SqlDbType.NVarChar, 50); // will change to address 1 in db
                add2Param.Value = newCustomer.Address2;

                SqlParameter cityParam = new SqlParameter("@City", SqlDbType.NVarChar, 50); 
                cityParam.Value = newCustomer.City;

                SqlParameter countyParam = new SqlParameter("@County", SqlDbType.NVarChar, 50);
                countyParam.Value = newCustomer.County;

                SqlParameter custIDParam = new SqlParameter("@CustomerID", SqlDbType.Int);
                custIDParam.Direction = ParameterDirection.Output;

                cmdCustomer.Parameters.Add(firstNameParam);
                cmdCustomer.Parameters.Add(surnameParam);
                cmdCustomer.Parameters.Add(emailParam);
                cmdCustomer.Parameters.Add(phoneParam);
                cmdCustomer.Parameters.Add(add1Param);
                cmdCustomer.Parameters.Add(add2Param);
                cmdCustomer.Parameters.Add(cityParam);
                cmdCustomer.Parameters.Add(countyParam);
                cmdCustomer.Parameters.Add(custIDParam);

                cxn.Open();
                cmdCustomer.ExecuteNonQuery();
                cxn.Close();

                // Taking CustomerID from customer table and assigning it to the account CustomerID
                newAccount.CustomerID = Convert.ToInt32(cmdCustomer.Parameters["@CustomerID"].Value);

                SqlCommand cmdAccount = new SqlCommand("spAddAccount", cxn);
                cmdAccount.CommandType = CommandType.StoredProcedure;

                SqlParameter CustIDParam = new SqlParameter("@CustomerID", SqlDbType.Int);
                CustIDParam.Value = newAccount.CustomerID;

                SqlParameter AccTypeParam = new SqlParameter("@AccountType", SqlDbType.NVarChar, 50);
                AccTypeParam.Value = newAccount.AccountType;

                SqlParameter AccNumberParam = new SqlParameter("@AccountNumber", SqlDbType.Int);
                AccNumberParam.Value = newAccount.AccountNumber;

                SqlParameter SortCodeParam = new SqlParameter("@SortCode", SqlDbType.Int);
                SortCodeParam.Value = newAccount.SortCode;

                SqlParameter InitialBalParam = new SqlParameter("@InitialBalance", SqlDbType.Int);
                InitialBalParam.Value = newAccount.InitialBalance;

                SqlParameter OverDraftParam = new SqlParameter("@OverdraftLimit", SqlDbType.Int);
                OverDraftParam.Value = newAccount.OverdraftLimit;

                SqlParameter AccIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                AccIDParam.Direction = ParameterDirection.Output;

                cmdAccount.Parameters.Add(CustIDParam);
                cmdAccount.Parameters.Add(AccTypeParam);
                cmdAccount.Parameters.Add(AccNumberParam);
                cmdAccount.Parameters.Add(SortCodeParam);
                cmdAccount.Parameters.Add(InitialBalParam);
                cmdAccount.Parameters.Add(OverDraftParam);
                cmdAccount.Parameters.Add(AccIDParam);

                cxn.Open();
                cmdAccount.ExecuteNonQuery();
                cxn.Close();
            }
        }
        public void CreateTransaction(TransactionModel newTransaction, AccountModel account)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                newTransaction.AccountID = account.AccountID;

                SqlCommand cmdTransaction = new SqlCommand("spAddTransaction", cxn);
                cmdTransaction.CommandType = CommandType.StoredProcedure;

                SqlParameter accountIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                accountIDParam.Value = newTransaction.AccountID;

                SqlParameter amountParam = new SqlParameter("@Amount", SqlDbType.Int);
                amountParam.Value = newTransaction.Amount;

                SqlParameter typeParam = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
                typeParam.Value = newTransaction.Type;

                SqlParameter descriptionParam = new SqlParameter("@Description", SqlDbType.NVarChar, 250);
                descriptionParam.Value = newTransaction.Description;

                SqlParameter transactionIDParam = new SqlParameter("@TransactionID", SqlDbType.Int);
                transactionIDParam.Direction = ParameterDirection.Output;

                cmdTransaction.Parameters.Add(accountIDParam);
                cmdTransaction.Parameters.Add(amountParam);
                cmdTransaction.Parameters.Add(typeParam);
                cmdTransaction.Parameters.Add(descriptionParam);
                cmdTransaction.Parameters.Add(transactionIDParam);

                cxn.Open();
                cmdTransaction.ExecuteNonQuery();
                cxn.Close();
            }
        }

        public DataSet GetCustomerAccounts()
        {
            DataSet ds = null;
            try
            {
                using (SqlConnection cxn = new SqlConnection(cxnString))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    ds = new DataSet();
                    da.SelectCommand = new SqlCommand("spGetCustomerAccounts", cxn);
                    da.Fill(ds);
                    cxn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
