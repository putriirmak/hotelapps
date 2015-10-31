using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Ext.Models
{
    public class Hotel_ExtInitializer: DropCreateDatabaseIfModelChanges<Hotel_ExtContext>
    {
        protected override void Seed(Hotel_ExtContext context)
        {

            HotelsInfo h = new HotelsInfo
            {
                Id = 1,
                Fullname="ABC HOTEL",
                Address="JL. ABC No.123, Bandung , Jawa Barat",
                Description="A cozy hotel located in Bandung. Located near green area of Bandung, Lembang. Make this hotel air so refreshing. With affordable price, ABC Hotel offers a great view, a fresh air and first rate service.",
                Stars=4
            };

            context.HotelInfo.Add(h);

            UserHotel uh = new UserHotel
            {
                Id = 1,
                Username = "puterisarahn",
                Password = "password1234",
                Email = "puterisarah.jtk10@gmail.com",
                Address = "sarijadi",
                PhoneNumber = 0222001181
            };

            context.UserHotels.Add(uh);

            BankAccount hotel = new BankAccount
            {
                Id = 1,
                BankAccountName = "Jayakarta",
                BankAccountNo = "123456",
                BankName = "BCA"
            };
            BankAccount pelanggan = new BankAccount
            {
                Id = 2,
                BankAccountName = "Bambang",
                BankAccountNo = "78910",
                BankName = "BCA",
                UserHotelId = 1
            };
            context.BankAccounts.Add(hotel);
            context.BankAccounts.Add(pelanggan);

            Facility f = new Facility {
                  Id = 1,
                  FacilityNo = "a1",
                  FacilityName = "WIFI"
            };
            context.Facilities.Add(f);

            Room r = new Room
            {
                Id = 1,
                RoomNo = "ab123",
                RoomName = "ab123",
                Capacity = "2"
            };
            context.Rooms.Add(r);

            BedRoomType bt = new BedRoomType
            {
                  Id = 1,
                  BedRoomTypeCode ="d",
                  BedRoomName = "deluxe",
                  ImageBedroom = "xyz",
                  SizeRoom = 50
             };

            context.BedRoomTypes.Add(bt);


            Bedroom b = new Bedroom
            {
                Id = 1 ,
                BedroomNumber ="abcd123",
                AvailabilityStatus = 1,
                BedroomTypeId = 1
            };

            context.Bedrooms.Add(b);
            context.SaveChanges();



            base.Seed(context);
        }

    }
}