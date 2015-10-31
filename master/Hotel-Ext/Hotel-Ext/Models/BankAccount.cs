using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }

        public int? UserHotelId { get; set; }
        public UserHotel UserHotel { get; set; }
    }
}