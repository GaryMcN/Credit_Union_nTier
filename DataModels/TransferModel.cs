using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class TransferModel
    {
        public int TransferID { get; set; }
        public int TransactionDebitID { get; set; }
        public int TransactionCreditID { get; set; }
        public int DestinationSortCode { get; set; }
        public int DestinationAccountNumber { get; set; }

        public TransferModel(int transactionDebitID, int transactioinCreditID, int destinationSortCode, int destinationAccountNumber)
        {
            this.TransactionDebitID = transactionDebitID;
            this.TransactionCreditID = transactioinCreditID;
            this.DestinationSortCode = destinationSortCode;
            this.DestinationAccountNumber = destinationAccountNumber;
        }
    }
}
