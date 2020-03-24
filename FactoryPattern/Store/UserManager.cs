using FactoryPattern.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Store
{
    class UserManager
    {
        public ApplicationDbContext DbContext { get; set; }

        public UserManager(string dbType)
        {
            DbContext = DbContextFactory.CreateDbContext(dbType);
        }

        public List<User> GetAllUsers()
        {
            return DbContext.Users.ToList();
        }

        public User AddUser(User user)
        {
            DbContext.Users.Add(user);

            return DbContext.SaveChanges() > 0 ? user : null;
        }
    }
}
