using FactoryPattern.Entities;
using FactoryPattern.Store;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager sqlServerUserManager = new UserManager("SqlServer");
            UserManager mySqlUserManager = new UserManager("MySql");

            User user1 = new User { Name = "Ahmed" };
            User user2 = new User { Name = "Ahmed" };

            sqlServerUserManager.AddUser(user1);
            mySqlUserManager.AddUser(user2);

            var allSqlServerUsers = sqlServerUserManager.GetAllUsers();
            var allMySqlServerUsers = mySqlUserManager.GetAllUsers();

            Console.WriteLine($"From SqlServer: Name of first user: {allSqlServerUsers[0].Name}");
            Console.WriteLine($"From MySql: Name of first user: {allMySqlServerUsers[0].Name}");
        }
    }
}
