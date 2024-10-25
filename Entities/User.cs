using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayad_Center_Project.Entities
{
    public class User
    {
        public int? Id { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public AccountType AccountType { get; set; }

        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
