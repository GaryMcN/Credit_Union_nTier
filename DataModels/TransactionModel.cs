using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class TransactionModel
    {
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string TransactionTimeStamp { get; set; }

        public TransactionModel(int amount, string type, string description)
        {
            Amount = amount;
            Type = type;
            Description = description;
        }
    }
}
