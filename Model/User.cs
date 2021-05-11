using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordSalt { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
