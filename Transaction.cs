using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrace_v0._2
{
    internal class Transaction
    {
        // Properties, Class Özellikleri
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public TransactionType Type { get; set; }


        // Constructor (Yapıcı Method) - Nesne oluşurken çalışır

        public Transaction(decimal amount, string description, string category, TransactionType type)
        {
            Amount = amount;
            Description = description;
            Category = category;
            Type = type;
            Date = DateTime.Now;
        }


    }
}
