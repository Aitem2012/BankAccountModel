using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Today;
        public DateTime DateUpdated { get; set; } = DateTime.Today;

        public ICollection<Account> Accounts { get; set; }

        public Customer()
        {
            Accounts = new HashSet<Account>();
        }

    }
}
