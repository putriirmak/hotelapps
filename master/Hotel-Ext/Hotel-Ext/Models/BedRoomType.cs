using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class BedRoomType
    {
        [Key]
        public int Id { get; set; }
        public string BedRoomTypeCode { get; set; }
        public string BedRoomName { get; set; }
        public string ImageBedroom { get; set; }
        public long SizeRoom { get; set; }
        public Decimal BedRoomPrice { get; set; }
    }
}