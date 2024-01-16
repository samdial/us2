using Microsoft.EntityFrameworkCore;
using UserServiceDatabase.Models;

namespace UserServiceDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<UserContext>()
                .UseNpgsql("Our Connection String")
                .Options;

            using var db = new UserContext(options);
            db.Database.EnsureCreated();

            //List<User> users = GenerateFakeData();
            //db.Users.AddRange(users);
            //db.SaveChanges();
        }

        static List<User> GenerateFakeData()
        {
            List<User> users =
            [
                new User 
                { 
                    FirstName = "Peter",
                    LastName = "Moulineux",
                    PhoneNumber = "+1234567890",
                    Email = "person1@mail.ru",
                    Login = "peter",
                    PasswordHash = 123.GetHashCode().ToString(),
                    IsDeactivated = false,
                    Role = new Role()
                    {
                        Name = "Customer",
                        RolePermissions = new List<RolePermission>()
                        {

                        }
                    },
                    Account = new Account()
                    {

                    },
                    Transactions = new List<Transaction>()
                    {

                    }
                },
                new User 
                { 

                },
                new User 
                { 

                },
            ];

            users[0].Role.Users = new List<User>()
            {
                users[0]
            };


            return users;
        }
    }
}
