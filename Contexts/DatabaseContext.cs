using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Account> Users { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
        }
    }
}