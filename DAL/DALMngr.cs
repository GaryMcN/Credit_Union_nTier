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
        public int TransactionID { get; set; }

        public void CreateCustomerAccount(CustomerModel newCustomer, AccountModel newAccount, TransactionModel newTransaction)
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

                SqlParameter BalParam = new SqlParameter("@Balance", SqlDbType.Int);
                BalParam.Value = newAccount.Balance;

                SqlParameter OverDraftParam = new SqlParameter("@OverdraftLimit", SqlDbType.Int);
                OverDraftParam.Value = newAccount.OverdraftLimit;

                SqlParameter AccIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                AccIDParam.Direction = ParameterDirection.Output;

                cmdAccount.Parameters.Add(CustIDParam);
                cmdAccount.Parameters.Add(AccTypeParam);
                cmdAccount.Parameters.Add(AccNumberParam);
                cmdAccount.Parameters.Add(SortCodeParam);
                cmdAccount.Parameters.Add(BalParam);
                cmdAccount.Parameters.Add(OverDraftParam);
                cmdAccount.Parameters.Add(AccIDParam);

                cxn.Open();
                cmdAccount.ExecuteNonQuery();
                cxn.Close();

                

                SqlCommand cmdTransaction = new SqlCommand("spAddTransaction", cxn);
                cmdTransaction.CommandType = CommandType.StoredProcedure;

                newTransaction.AccountID = Convert.ToInt32(cmdAccount.Parameters["@AccountID"].Value);

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
        public void CreateTransfer(int credID, int debID, TransferModel transfer)
        {
            // trying to get the account details to get customer details
            // AccountModel creditorsAccount = new AccountModel(credit.AccountID);
            // How to get the name based on account //

            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                SqlCommand cmdTransfer = new SqlCommand("spAddTransfer", cxn);
                cmdTransfer.CommandType = CommandType.StoredProcedure;

                SqlParameter transactionCreditIDParam = new SqlParameter("@TransactionCreditID", SqlDbType.Int);
                transactionCreditIDParam.Value = credID;

                SqlParameter transactionDebitIDParam = new SqlParameter("@TransactionDebitID", SqlDbType.Int);
                transactionDebitIDParam.Value = debID;

                SqlParameter DestinationSortCodeParam = new SqlParameter("@DestinationSortCode", SqlDbType.NVarChar, 50);
                DestinationSortCodeParam.Value = transfer.DestinationSortCode;

                SqlParameter DestinationAccountNumberParam = new SqlParameter("@DestinationAccountNumber", SqlDbType.Int);
                DestinationAccountNumberParam.Value = transfer.DestinationAccountNumber;

                SqlParameter TransferIDParam = new SqlParameter("@TransferID", SqlDbType.Int);
                TransferIDParam.Direction = ParameterDirection.Output;

                //ADD PARAMETERS//
                cmdTransfer.Parameters.Add(transactionCreditIDParam);
                cmdTransfer.Parameters.Add(transactionDebitIDParam);
                cmdTransfer.Parameters.Add(DestinationSortCodeParam);
                cmdTransfer.Parameters.Add(DestinationAccountNumberParam);
                cmdTransfer.Parameters.Add(TransferIDParam);

                cxn.Open();
                cmdTransfer.ExecuteNonQuery();
                cxn.Close();
            }
        }
        public void CreateTransaction(TransactionModel newTransaction)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
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
                //capturing the transaction ID in a global variable.
                TransactionID = Convert.ToInt32(cmdTransaction.Parameters["@TransactionID"].Value);
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

        public int GetAccountID(int accountNumber)
        {
            int accountID = 0;

            using(SqlConnection cxn = new SqlConnection(cxnString))
            {
                SqlCommand cmdGetTrans = new SqlCommand("spGetAccountID", cxn);
                cmdGetTrans.CommandType = CommandType.StoredProcedure;

                SqlParameter AccountNumberParam = new SqlParameter("@AccountNumber", SqlDbType.Int);
                AccountNumberParam.Value = accountNumber;

                cmdGetTrans.Parameters.Add(AccountNumberParam);

                cxn.Open();
                cmdGetTrans.ExecuteNonQuery();
                SqlDataReader rd = cmdGetTrans.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    accountID = rd.GetInt32(0);
                }
                cxn.Close();
            }
            return accountID;
        }


        // THIS IS WHAT WE NEED TO GET THE ACCOPUNT NUMBER START HERE//
        //public int GetAccount(int accountNumber)
        //{
        //    int accountID;
        //    try
        //    {
        //        using (SqlConnection cxn = new SqlConnection(cxnString))
        //        {
        //            SqlCommand cmdGetAccount = new SqlCommand("spGetAccount", cxn);
        //            cmdGetAccount.CommandType = CommandType.StoredProcedure;

        //            SqlParameter accountIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
        //            //accountIDParam.Value = accountID;

        //            cmdGetAccount.Parameters.Add(accountIDParam);

        //            cxn.Open();
        //            cmdGetAccount.ExecuteNonQuery();
        //            cxn.Close();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    return accountID;
        //}

        public DataTable GetFullCustomerDetails(int accountID)
        {
            DataTable dt = null;
            try
            {
                using (SqlConnection cxn = new SqlConnection(cxnString))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    dt = new DataTable();

                    SqlCommand cmdGetFullCustomerDetails = new SqlCommand("spGetFullCustomerDetails", cxn);
                    cmdGetFullCustomerDetails.CommandType = CommandType.StoredProcedure;

                    SqlParameter accountIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                    accountIDParam.Value = accountID;

                    cmdGetFullCustomerDetails.Parameters.Add(accountIDParam);
                    
                    cxn.Open();
                    cmdGetFullCustomerDetails.ExecuteNonQuery();
                    da.SelectCommand = cmdGetFullCustomerDetails;
                    da.Fill(dt);
                    cxn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        public void UpdateAccountBalance(AccountModel accountToUpdate)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                SqlCommand cmdBalanceUpdate = new SqlCommand("spUpdateBalance", cxn);
                cmdBalanceUpdate.CommandType = CommandType.StoredProcedure;

                SqlParameter accountIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                accountIDParam.Value = accountToUpdate.AccountID;

                SqlParameter accountBalanceParam = new SqlParameter("@Balance", SqlDbType.Int);
                accountBalanceParam.Value = accountToUpdate.Balance;

                cmdBalanceUpdate.Parameters.Add(accountIDParam);
                cmdBalanceUpdate.Parameters.Add(accountBalanceParam);

                cxn.Open();
                cmdBalanceUpdate.ExecuteNonQuery();
                cxn.Close();
            }
        }


        public bool IsValidLogin(UserModel userDetails)
        {
            bool isValid;
            try
            {
                using (SqlConnection cxn = new SqlConnection(cxnString))
                {
                    SqlCommand cmd = new SqlCommand("spValidateUser", cxn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter userNameParam = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                    userNameParam.Value = userDetails.UserName;

                    SqlParameter passwordParam = new SqlParameter("@usrPassword", SqlDbType.NVarChar, 50);
                    passwordParam.Value = userDetails.Password;

                    cmd.Parameters.Add(userNameParam);
                    cmd.Parameters.Add(passwordParam);
                    cxn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    

                    if(dr.Read())
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                    dr.Close();
                    cxn.Close();
                }
                return isValid;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCustomersAccount(CustomerModel customer, AccountModel account)
        {
            UpdateCutomer(customer);
            UpdateAccount(account);
        }

        private void UpdateCutomer(CustomerModel existingCustomer)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                SqlCommand cmdCustomer = new SqlCommand("spUpdateCustomer", cxn);
                cmdCustomer.CommandType = CommandType.StoredProcedure;

                SqlParameter firstNameParam = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
                firstNameParam.Value = existingCustomer.FirstName;

                SqlParameter surnameParam = new SqlParameter("@Surname", SqlDbType.NVarChar, 50);
                surnameParam.Value = existingCustomer.Surname;

                SqlParameter emailParam = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                emailParam.Value = existingCustomer.Email;

                SqlParameter phoneParam = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                phoneParam.Value = existingCustomer.Phone;

                SqlParameter add1Param = new SqlParameter("@Address1", SqlDbType.NVarChar, 50);
                add1Param.Value = existingCustomer.Address1;

                SqlParameter add2Param = new SqlParameter("@Address2", SqlDbType.NVarChar, 50);
                add2Param.Value = existingCustomer.Address2;

                SqlParameter cityParam = new SqlParameter("@City", SqlDbType.NVarChar, 50);
                cityParam.Value = existingCustomer.City;

                SqlParameter countyParam = new SqlParameter("@County", SqlDbType.NVarChar, 50);
                countyParam.Value = existingCustomer.County;

                SqlParameter custIDParam = new SqlParameter("@CustomerID", SqlDbType.Int);
                custIDParam.Value = existingCustomer.CustomerID;

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
            }
        }

        private void UpdateAccount(AccountModel existingAccount)
        {
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {

                SqlCommand cmdAccount = new SqlCommand("spUpdateAccount", cxn);
                cmdAccount.CommandType = CommandType.StoredProcedure;

                SqlParameter CustIDParam = new SqlParameter("@CustomerID", SqlDbType.Int);
                CustIDParam.Value = existingAccount.CustomerID;

                SqlParameter AccTypeParam = new SqlParameter("@AccountType", SqlDbType.NVarChar, 50);
                AccTypeParam.Value = existingAccount.AccountType;

                SqlParameter AccNumberParam = new SqlParameter("@AccountNumber", SqlDbType.Int);
                AccNumberParam.Value = existingAccount.AccountNumber;

                SqlParameter SortCodeParam = new SqlParameter("@SortCode", SqlDbType.Int);
                SortCodeParam.Value = existingAccount.SortCode;

                SqlParameter BalParam = new SqlParameter("@Balance", SqlDbType.Int);
                BalParam.Value = existingAccount.Balance;

                SqlParameter OverDraftParam = new SqlParameter("@OverdraftLimit", SqlDbType.Int);
                OverDraftParam.Value = existingAccount.OverdraftLimit;

                SqlParameter AccIDParam = new SqlParameter("@AccountID", SqlDbType.Int);
                AccIDParam.Value = existingAccount.AccountID;

                cmdAccount.Parameters.Add(AccTypeParam);
                cmdAccount.Parameters.Add(AccNumberParam);
                cmdAccount.Parameters.Add(SortCodeParam);
                cmdAccount.Parameters.Add(BalParam);
                cmdAccount.Parameters.Add(OverDraftParam);
                cmdAccount.Parameters.Add(AccIDParam);

                cxn.Open();
                cmdAccount.ExecuteNonQuery();
                cxn.Close();
            }
        }
    }
}
