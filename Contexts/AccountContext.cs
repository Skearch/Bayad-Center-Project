using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project.DbContexts
{
    public class AccountContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired();

            modelBuilder.Entity<User>()
               .Property(u => u.LastName)
               .IsRequired();

            modelBuilder.Entity<User>()
               .Property(u => u.Address)
               .IsRequired();

            modelBuilder.Entity<User>()
               .Property(u => u.Birthdate)
               .IsRequired();

            modelBuilder.Entity<User>()
               .Property(u => u.AccountType)
               .IsRequired();

            modelBuilder.Entity<User>()
               .Property(u => u.MiddleName);

            modelBuilder.Entity<User>()
               .Property(u => u.EmailAddress);

            modelBuilder.Entity<User>()
               .Property(u => u.PhoneNumber);
        }
    }
}