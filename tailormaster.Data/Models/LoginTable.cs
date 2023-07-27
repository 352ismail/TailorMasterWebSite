using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tailormaster.Domain.Models
{
    public class LoginTable
    {
        [Key]
        public long LoginID { get; set; }
        public string? UserID { get; set; }
        public string? Email { get; set; }
        public string Code { get; set; }
        public bool IsVerified { get; set; } = false;
        public DateTime TokenExpiry { get; set; } = DateTime.UtcNow.AddDays(7);
    }
}
