using Hotel_Ext.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Bedroom
    {
        [Key]
        public int Id { get; set; }
        public string BedroomNumber { get; set; }
        public int AvailabilityStatus { get; set; }
        public int? BedroomTypeId { get; set; }

        public BedRoomType BedroomType { get; set; }

        //public ICollection<BedroomReservation> BedroomReservations { get; set; }
        
    }
}