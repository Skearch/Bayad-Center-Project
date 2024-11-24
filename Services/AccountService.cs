using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bayad_Center_Project.Services
{
    public class AccountService
    {
        private readonly AccountContext _dbContext;

        public AccountService(AccountContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Account ValidateLogin(string username, string password)
        {
            Account user = _dbContext.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                throw new Exception("No matching account.");

            if (user.Password != password)
                throw new Exception("Invalid password.");

            return user;
        }

        public bool RegisterAccount(Account user)
        {
            if (_dbContext.Users.Any(u => u.Username == user.Username))
                throw new Exception("This username already exists.");

            ValidateUserFields(user);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }

        public bool EditAccountById(int userId, Account user)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            if (existingUser == null)
                throw new Exception($"Account with ID: {userId} does not exist.");

            ValidateUserFields(user);

            existingUser.Username = user.Username;
            existingUser.Password = user.Password;
            existingUser.AccountType = user.AccountType;
            existingUser.FirstName = user.FirstName;
            existingUser.MiddleName = user.MiddleName;
            existingUser.LastName = user.LastName;
            existingUser.Birthdate = user.Birthdate;
            existingUser.EmailAddress = user.EmailAddress;
            existingUser.PhoneNumber = user.PhoneNumber;
            existingUser.Address = user.Address;

            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteAccountById(int accountId)
        {
            using var context = new DatabaseContext();
            var account = context.Set<Account>().Find(accountId);
            if (account == null)
                throw new Exception($"Given account does not exist.");

            if (context.Set<Transaction>().Any(t => t.AccountId == accountId))
                throw new Exception($"This Account is included in one or more record in Transactions.");

            context.Set<Account>().Remove(account);
            return context.SaveChanges() > 0;
        }

        public Account GetAccountById(int accountId)
        {
            var account = _dbContext.Set<Account>().FirstOrDefault(s => s.Id == accountId);
            if (account == null)
                throw new Exception($"Account with ID: {accountId} not found.");

            return account;
        }


        public List<Account> GetAllAccounts()
        {
            return _dbContext.Set<Account>().ToList();
        }

        private void ValidateUserFields(Account user)
        {
            var invalidFields = user.GetType().GetProperties()
                .Where(p => p.PropertyType == typeof(string))
                .Where(p => p.GetValue(user) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault()?.Length)
                .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");
        }
    }
}