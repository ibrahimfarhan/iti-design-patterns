using FactoryPattern.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Store
{
    class MySqlDbContext : ApplicationDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ItiUsers;user=root;password=root");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
