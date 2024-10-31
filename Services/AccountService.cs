using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Bayad_Center_Project.Enums;
using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Services
{
    public class AccountService
    {
        private readonly AccountContext _dbContext;

        public AccountService(AccountContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ValidateLogin(string username, string password, AccountType accountType)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username && u.AccountType == accountType);
            if (user != null && user.Password == password)
                return true;

            throw new Exception("No matching account.");
        }

        public bool RegisterAccount(User user)
        {
            if (_dbContext.Users.Any(u => u.Username == user.Username))
                throw new Exception("This username already exist.");

            var invalidFields = user.GetType().GetProperties()
            .Where(p => p.PropertyType == typeof(string))
            .Where(p => p.GetValue(user) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
            .Cast<MaxLengthAttribute>()
            .FirstOrDefault()?.Length)
            .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }

        public bool EditAccountById(int userID, User user)
        {
            var u = _dbContext.Users.FirstOrDefault(u => u.Id == userID);
            if (u == null)
                throw new Exception($"Account with the id: {userID} does not exist.");

            var invalidFields = user.GetType().GetProperties()
            .Where(p => p.PropertyType == typeof(string))
            .Where(p => p.GetValue(user) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
            .Cast<MaxLengthAttribute>()
            .FirstOrDefault()?.Length)
            .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");

            u.Username = user.Username;
            u.Password = user.Password;
            u.AccountType = user.AccountType;
            u.FirstName = user.FirstName;
            u.MiddleName = user.MiddleName;
            u.LastName = user.LastName;
            u.Birthdate = user.Birthdate;
            u.EmailAddress = user.EmailAddress;
            u.PhoneNumber = user.PhoneNumber;
            u.Address = user.Address;

            _dbContext.SaveChanges();

            return true;
        }

        public User GetUserById(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new Exception("User with ID " + userId + " not found.");

            return user;
        }

        public bool DeleteAccountById(int userId)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new Exception($"Account with ID: {userId} does not exist.");

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();

            return true;
        }

        public void PopulateUserTable(DataGridView dataGridView)
        {
            List<User> users = _dbContext.Users.ToList();

            dataGridView.Rows.Clear();

            if (dataGridView.Columns.Count == 0)
            {
                foreach (var propertyInfo in typeof(User).GetProperties())
                    dataGridView.Columns.Add(propertyInfo.Name, propertyInfo.Name);
            }

            foreach (var user in users)
            {
                int rowIndex = dataGridView.Rows.Add();

                foreach (var propertyInfo in typeof(User).GetProperties())
                    dataGridView.Rows[rowIndex].Cells[propertyInfo.Name].Value = propertyInfo.GetValue(user);
            }
        }
    }
}