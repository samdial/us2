namespace UserServiceDatabase.Models
{
    public class RolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Role Role { get; set; } = null!;
        Permission Permission { get; set; } = null!;
    }
}