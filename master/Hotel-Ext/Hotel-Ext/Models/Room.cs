using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public string Capacity { get; set; }

    }
}