using FactoryPattern.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Store
{
    abstract class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
