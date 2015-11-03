using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class HotelsInfo : UserHotel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public ICollection<BankAccount> BankAccounts { get; set; }
        public String Description { get; set; }
        public int Stars { get; set; }

    }
}