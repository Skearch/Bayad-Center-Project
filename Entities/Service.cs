using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Entities
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public byte[] Icon { get; set; }
    }
}
