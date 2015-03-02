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
        public int InitialBalance { get; set; }
        public int OverdraftLimit { get; set; }

        public AccountModel(string accountType,
                            int accountNumber,
                            int sortCode,
                            int initialBalance,
                            int overdraftLimit)
        {
            AccountType = accountType;
            AccountNumber = accountNumber;
            SortCode = sortCode;
            InitialBalance = initialBalance;
            OverdraftLimit = overdraftLimit;
        }
                            
    }
}
