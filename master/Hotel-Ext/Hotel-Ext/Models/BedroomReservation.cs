using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ext.Models
{
    public class BedroomReservation
    {
        public int BedroomReservationId { get; set; }
        public int? BedroomId { get; set; }
        public int? ReservationId { get; set; }

        public Bedroom Bedroom { get; set; }
        public Reservation Reservation { get; set; }
    }
}