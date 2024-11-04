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
        public int? Id { get; set; }

        public int? ServiceID { get; set; }

        public int? UserID { get; set; }
    }
}