using Bayad_Center_Project.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bayad_Center_Project.Entities
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [ForeignKey("Transaction")]
        public int TransactionID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        [Required]
        public AccountType AccountType { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string? MiddleName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [StringLength(250)]
        public string? EmailAddress { get; set; }

        [StringLength(50)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }
    }
}