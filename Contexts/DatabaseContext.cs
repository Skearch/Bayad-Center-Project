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
                .Property(u => u.Description);

            modelBuilder.Entity<Service>()
                .Property(u => u.Icon)
                .IsRequired();


            //USER
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
