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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bayadcenter.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SERVICE
            modelBuilder.Entity<Service>()
                .ToTable("Services")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Service>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<Service>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<Service>()
                .Property(u => u.Description);

            modelBuilder.Entity<Service>()
                .Property(u => u.Icon)
                .IsRequired();

            //USER
            modelBuilder.Entity<Account>()
                .ToTable("Users")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Account>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Account>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .Property(u => u.FirstName)
                .IsRequired();

            modelBuilder.Entity<Account>()
               .Property(u => u.LastName)
               .IsRequired();

            modelBuilder.Entity<Account>()
               .Property(u => u.Address)
               .IsRequired();

            modelBuilder.Entity<Account>()
               .Property(u => u.Birthdate)
               .IsRequired();

            modelBuilder.Entity<Account>()
               .Property(u => u.AccountType)
               .IsRequired();

            modelBuilder.Entity<Account>()
               .Property(u => u.MiddleName);

            modelBuilder.Entity<Account>()
               .Property(u => u.EmailAddress);

            modelBuilder.Entity<Account>()
               .Property(u => u.PhoneNumber);

            //TRANSACTION
            modelBuilder.Entity<Transaction>()
                .ToTable("Transactions")
                .HasKey(t => t.Id);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.AccountId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Service)
                .WithMany(s => s.Transactions)
                .HasForeignKey(t => t.ServiceId);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.AccountNumber)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.FullName)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Email)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Message);
        }
    }
}