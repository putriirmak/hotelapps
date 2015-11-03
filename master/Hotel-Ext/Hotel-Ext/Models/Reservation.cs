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
        public System.DateTime ReservationStartDate { get; set; }
        [Display(Name = "Until")]
        public System.DateTime ReservationEndDate { get; set; }
        [Display(Name = "Check In")]
        public System.DateTime CheckInTime { get; set; }
        [Display(Name = "Check Out")]
        public System.DateTime CheckOutTime { get; set; }
        [Display(Name = "Total Amount")]
        public Decimal totalAmount { get; set; }
        [Display(Name = "User")]
        public int? UserHotelId { get; set; }
        [Display(Name = "Bedroom Reserve")]
        public int? BedroomTypeId { get; set; }
        public int BedroomId { get; set; }

        //public ICollection<BedroomReservation> BedroomReservations { get; set; }
        public UserHotel UserHotel { get; set; }
        public BedRoomType BedroomType { get; set; }
        public Bedroom Bedroom { get; set; }
        }
}