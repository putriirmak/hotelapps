using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public long Amount { get; set; }
        public string TransactionNo { get; set; }
        public int? BankAccountId { get; set; }

        public BankAccount BankAccount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}