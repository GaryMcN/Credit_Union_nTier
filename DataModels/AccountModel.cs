using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class AccountModel
    {
        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public int SortCode { get; set; }
        public int Balance { get; set; }
        public int OverdraftLimit { get; set; }

        public AccountModel(string accountType,
                            int accountNumber,
                            int sortCode,
                            int balance,
                            int overdraftLimit)
        {
            AccountType = accountType;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
        }
        public AccountModel(int accountID,
                            string accountType,
                            int accountNumber,
                            int sortCode,
                            int balance,
                            int overdraftLimit)
        {
            AccountID = accountID;
            AccountType = accountType;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
        }

        public AccountModel(int accountID, int balance)
        {
            AccountID = accountID;
            Balance = balance;
        }
        public AccountModel(int accountID)
        {
            AccountID = accountID;
        }   
    }
}
