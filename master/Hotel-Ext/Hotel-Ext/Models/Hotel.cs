using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string hotelName { get; set; }
        public string hotelAddress { get; set; }
        public string hotelPhoneNumber { get; set; }
        public List<Facility> facilities { get; set; }
        public List<Room> rooms { get; set; }
        public List<Bedroom> bedrooms { get; set; }
        public List<BankAccount> bankAccounts { get; set; }
    }
}