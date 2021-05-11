using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction
    {
        [Key]
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Amount { get; set; }
        public DateTime Date { get; }
        public string Note { get; set; }
        public DateTime DateOfTransaction { get; set; } = DateTime.Now;
        public string AccType { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }
}
