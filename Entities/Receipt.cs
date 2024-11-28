using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bayad_Center_Project.Entities
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }

        [Required]
        [ForeignKey("Transaction")]
        public int TransactionId { get; set; }

        [Required]
        [ForeignKey("Account")]
        public int AccountID { get; set; }

        [Required]
        public DateTime DateIssued { get; set; }

        [Required]
        public decimal AmountToPay { get; set; }

        [Required]
        public decimal PaymentAmount { get; set; }

        [Required]
        public decimal Change { get; set; }
    }
}