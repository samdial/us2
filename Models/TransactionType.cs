﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceDatabase.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public ICollection<Transaction> Transactions { get; set; } = null!;
    }
}
