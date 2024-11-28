using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bayad_Center_Project.Services
{
    public class ReceiptService
    {
        private readonly DatabaseContext _context;

        public ReceiptService(DatabaseContext context)
        {
            _context = context;
        }

        public bool CreateReceipt(Receipt receipt)
        {
            _context.Receipts.Add(receipt);
            return _context.SaveChanges() > 0;
        }

        public Receipt GetReceiptById(int receiptId)
        {
            return _context.Receipts.Find(receiptId);
        }

        public Receipt GetReceiptByTransactionId(int transactionId)
        {
            return _context.Receipts.FirstOrDefault(r => r.TransactionId == transactionId);
        }

        public List<Receipt> GetAllReceipts()
        {
            return _context.Receipts.ToList();
        }

        public bool UpdateReceipt(Receipt receipt)
        {
            var existingReceipt = _context.Receipts.Find(receipt.ReceiptId);
            if (existingReceipt != null)
            {
                existingReceipt.TransactionId = receipt.TransactionId;
                existingReceipt.AccountID = receipt.AccountID;
                existingReceipt.DateIssued = receipt.DateIssued;
                existingReceipt.AmountToPay = receipt.AmountToPay;
                existingReceipt.PaymentAmount = receipt.PaymentAmount;
                existingReceipt.Change = receipt.Change;

                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool DeleteReceipt(int receiptId)
        {
            var receipt = _context.Receipts.Find(receiptId);
            if (receipt != null)
            {
                _context.Receipts.Remove(receipt);
                return _context.SaveChanges() > 0;
            }
            return false;
        }
    }
}