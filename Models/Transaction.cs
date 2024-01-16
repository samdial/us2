using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceDatabase.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset TransactionDate { get; set; }

        public User User { get; set; } = null!;
        public TransactionType TransactionType { get; set; } = null!;
    }
}
