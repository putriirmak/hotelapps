using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class HotelsInfo: UserHotel
    {
        public String Description { get; set; }
        public int Stars { get; set; }

    }
}