using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceDatabase.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<User> Users { get; set; } = null!;
        public ICollection<RolePermission> RolePermissions { get; set; } = null!;
    }
}
