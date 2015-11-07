using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Hotel_Ext.Models
{
    public class Hotel_ExtContext : DbContext
    {
        internal object HotelsInfoes;

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public Hotel_ExtContext() : base("name=Hotel_ExtContext")
        {
        }

        public System.Data.Entity.DbSet<Hotel.Models.Reservation> Reservations { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.HotelsInfo> HotelInfo { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.Bedroom> Bedrooms { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.BedRoomType> BedRoomTypes { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.BankAccount> BankAccounts { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.Facility> Facilities { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.Payment> Payments { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.Room> Rooms { get; set; }
        public System.Data.Entity.DbSet<Hotel.Models.UserHotel> UserHotels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}
