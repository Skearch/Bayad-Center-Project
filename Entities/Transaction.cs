using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bayad_Center_Project.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        [ForeignKey("Account")]
        public int AccountId { get; set; }

        [Required]
        [ForeignKey("Service")]
        public int ServiceId { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(300)]
        public string FullName { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [StringLength(500)]
        public string? Message { get; set; }
    }
}