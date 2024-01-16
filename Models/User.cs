using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceDatabase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Login { get; set; } = null!;

        // Поле для внешнего ключа
        public int AccountId { get; set; }
        public string PasswordHash { get; set; } = null!;
        public bool IsDeactivated { get; set; } = false;
        public Role Role { get; set; } = null!;
        public Account Account { get; set; } = null!;
        public ICollection<Transaction> Transactions { get; set; } = null!;

        
    }

}
