using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Account
    {
        [Key]
        public string AccountId { get; set; } = Guid.NewGuid().ToString();
        private static readonly Random _random = new Random();
        [Required]
        [StringLength(12)]
        public string AccountNumber { get; set; } = AccountNumberGenerator();
        public string CustomerId { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Balance { get; set; }
        public virtual string AccType { get; set; }
        
        public Customer Customer { get; set; }
        public virtual decimal MinimumBalance { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public ICollection<Transaction> Transactions { get; set; }

        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }


        //Generate account number
        private static string AccountNumberGenerator()
        {
            var number = "96790" + _random.Next(12345, 78666);
            return number;
        }

    }
}
