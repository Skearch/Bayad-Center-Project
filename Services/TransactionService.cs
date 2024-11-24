using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.DbContexts;
using Bayad_Center_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bayad_Center_Project.Services
{
    public class TransactionService
    {
        private readonly TransactionContext _dbContext;

        public TransactionService(TransactionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddTransaction(Transaction transaction)
        {
            ValidateTransactionFields(transaction);

            _dbContext.Set<Transaction>().Add(transaction);
            _dbContext.SaveChanges();
            return true;
        }

        public Transaction GetTransactionById(int transactionId)
        {
            var transaction = _dbContext.Set<Transaction>().FirstOrDefault(t => t.Id == transactionId);
            if (transaction == null)
                throw new Exception($"Transaction with ID: {transactionId} not found.");

            return transaction;
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            var existingEntity = _dbContext.Transactions.Local.FirstOrDefault(t => t.Id == transaction.Id);
            if (existingEntity != null)
                _dbContext.Entry(existingEntity).State = EntityState.Detached;

            _dbContext.Transactions.Attach(transaction);
            _dbContext.Transactions.Remove(transaction);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Transaction> GetAllTransactions()
        {
            return _dbContext.Set<Transaction>().ToList();
        }

        private void ValidateTransactionFields(Transaction transaction)
        {
            var invalidFields = transaction.GetType().GetProperties()
                .Where(p => p.PropertyType == typeof(string))
                .Where(p => p.GetValue(transaction) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault()?.Length)
                .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");
        }
    }
}