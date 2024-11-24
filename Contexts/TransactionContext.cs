using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bayad_Center_Project.Contexts
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
        }
    }
}
