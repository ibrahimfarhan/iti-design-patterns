using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Store
{
    static class DbContextFactory
    {
        public static ApplicationDbContext CreateDbContext(string dbType)
        {
            ApplicationDbContext dbContext = null;

            switch (dbType)
            {
                case "SqlServer":
                    dbContext = new SqlServerDbContext();
                    break;

                case "MySql":
                    dbContext = new MySqlDbContext();
                    break;

                default:
                    break;
            }

            return dbContext;
        }
    }
}
