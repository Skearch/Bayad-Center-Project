using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;

public class ServiceContext : DbContext
{
    public DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
    }
}