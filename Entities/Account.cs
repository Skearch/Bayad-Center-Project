using Bayad_Center_Project.Enums;

using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Entities
{
    public class Account
    {
        public int? Id { get; set; }

        [MaxLength(50)]
        public string? Username { get; set; }

        [MaxLength(150)]
        public string? Password { get; set; }

        public AccountType AccountType { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        public DateTime Birthdate { get; set; }

        [MaxLength(250)]
        public string? EmailAddress { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(500)]
        public string? Address { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}