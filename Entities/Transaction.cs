using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bayad_Center_Project.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        [MaxLength(50)]
        public string AccountNumber { get; set; }

        [MaxLength(300)]
        public string FullName { get; set; }

        [MaxLength(300)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string? Message { get; set; }

        public int? AccountId { get; set; }
        public Account Account { get; set; }

        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}