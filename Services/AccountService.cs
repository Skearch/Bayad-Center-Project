using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Services
{
    public class AccountService
    {
        private readonly DatabaseContext _dbContext;

        public AccountService(DatabaseContext dbContext)
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

        public bool EditAccountById(int accountID, Account account)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.AccountID == accountID);
            if (existingUser == null)
                throw new Exception($"Account with ID: {accountID} does not exist.");

            ValidateUserFields(account);

            existingUser.Username = account.Username;
            existingUser.Password = account.Password;
            existingUser.AccountType = account.AccountType;
            existingUser.FirstName = account.FirstName;
            existingUser.MiddleName = account.MiddleName;
            existingUser.LastName = account.LastName;
            existingUser.Birthdate = account.Birthdate;
            existingUser.EmailAddress = account.EmailAddress;
            existingUser.PhoneNumber = account.PhoneNumber;
            existingUser.Address = account.Address;

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
            var account = _dbContext.Set<Account>().FirstOrDefault(s => s.AccountID == accountId);
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