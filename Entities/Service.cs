using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Entities
{
    public class Service
    {
        public int? Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public byte[]? Icon { get; set; }
    }
}
