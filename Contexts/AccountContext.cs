using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bayad_Center_Project.DbContexts
{
    public class AccountContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
        }
    }
}