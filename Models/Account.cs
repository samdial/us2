using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceDatabase.Models
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public User User { get; set; } = null!;
    }
}
