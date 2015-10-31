using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        public string FacilityNo { get; set; }
        public string FacilityName { get; set; }

    }
}