using Microsoft.EntityFrameworkCore;
using MonolithicArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.DataAccess.Concrete.Context
{
    public class MyDbContext : DbContext
    {
        private const string _connectionString = "Server=YUSUF; Database=AsminECommerce; Trusted_Connection=True";
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
