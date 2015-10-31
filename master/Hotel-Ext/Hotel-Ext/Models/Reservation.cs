using Hotel_Ext.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Reservation Number ")]
        public string ReservationNo { get; set; }
        [Display(Name = "Reserve Date")]
        public DateTime ReservationStartDate { get; set; }
        [Display(Name = "Until")]
        public DateTime ReservationEndDate { get; set; }
        [Display(Name = "Check In")]
        public DateTime CheckInTime { get; set; }
        [Display(Name = "Check Out")]
        public DateTime CheckOutTime { get; set; }
        [Display(Name = "Check Out")]
        public int? UserHotelId { get; set; }

        public ICollection<BedroomReservation> BedroomReservations { get; set; }
        public UserHotel UserHotel { get; set; }
    }
}