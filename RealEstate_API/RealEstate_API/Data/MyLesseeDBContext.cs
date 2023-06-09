﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using RealEstate_API.Models;
using RealEstate_API.Models.Identity;

namespace RealEstate_API.Data
{


    public class MyLesseeDBContext : IdentityDbContext
    {
        public MyLesseeDBContext(DbContextOptions options) : base(options)
        {

        }

        // Properties are used to access tables

        public DbSet<Account> Accounts { get; set; }
       
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<HouseType> HouseTypes { get; set; }



        //        // initial model data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Dummy data for Accounts
            modelBuilder.Entity<Account>().HasData(
                    new Account
                    {
                        AcctId = Guid.NewGuid(),
                        Email = "beltranalvaro08@gmail.com",
                        Password = "alvaro1234",
                        Gender = "Male",
                        Name = "Alvaro Beltran",
                        Phone = 123456789,
                        CreationTime = DateTime.Now,
                        LastLoginTime = DateTime.Now
                    },
                    new Account
                    {
                        AcctId = Guid.NewGuid(),
                        Email = "tuyichen90@gmail.com",
                        Password = "tuyi1234",
                        Gender = "Female",
                        Name = "Tuyi Chen",
                        Phone = 123456789,
                        CreationTime = DateTime.Now,
                        LastLoginTime = DateTime.Now
                    },
                    new Account { AcctId = Guid.NewGuid(), Email = "katya.menesesr@gmail.com", Password = "katya1234", Gender = "Female", Name = "Katya Meneses", Phone = 123456789, CreationTime = DateTime.Now, LastLoginTime = DateTime.Now },
                    new Account { AcctId = Guid.NewGuid(), Email = "antonvinokurov101@gmail.com", Password = "anton1234", Gender = "Male", Name = "Anton Vinokurov", Phone = 123456789, CreationTime = DateTime.Now, LastLoginTime = DateTime.Now }
                    );

            //            //Dummy Data for Messages
            //            modelBuilder.Entity<Message>().HasData(
            //            new Message
            //            {
            //                MessageID = 2001,
            //                ReceiverID = 1001,
            //                SenderID = 1002,
            //                CreationTime = DateTime.Now,
            //                MessageString = "Hi Alvaro! I was referred to you by Anton, told me you’re looking to rent your... "
            //            },
            //            new Message
            //            {
            //                MessageID = 2002,
            //                ReceiverID = 1001,
            //                SenderID = 1004,
            //                CreationTime = DateTime.Now,
            //                MessageString = "Hey man, i have someone interested in your apartment, she will contact you. "
            //            });
            //            //Dummy data for Notificactions
            //            modelBuilder.Entity<Notification>().HasData(
            //            new Notification
            //            {
            //                NoteId = 1001,
            //                ReceiverId = 1001,
            //                SenderId = 1002,
            //                CreationTime = DateTime.Now,
            //                NotificationString = "Tuyi sent you a friend request"
            //            },
            //             new Notification
            //             {
            //                 NoteId = 1002,
            //                 ReceiverId = 1001,
            //                 SenderId = 1003,
            //                 CreationTime = DateTime.Now,
            //                 NotificationString = "Katya published a new listing"
            //             }
            //            );

            // house type
            modelBuilder.Entity<HouseType>().HasData(
                new HouseType { HouseTypeId = 1, Type = "Detached House" },
                new HouseType { HouseTypeId = 2, Type = "Semi-Detached House" },
                new HouseType { HouseTypeId = 3, Type = "Townhouse" },
                new HouseType { HouseTypeId = 4, Type = "Bungalow" },
                new HouseType { HouseTypeId = 5, Type = "Split-level House" },
                new HouseType { HouseTypeId = 6, Type = "Cottage" },
                new HouseType { HouseTypeId = 7, Type = "Condominium" },
                new HouseType { HouseTypeId = 8, Type = "Apartment" },
                new HouseType { HouseTypeId = 9, Type = "Others" }
            );

            // listing
            modelBuilder.Entity<Listing>().HasData(
new Listing
{
    ListingId = 1,
    HouseTypeId = 1,
    Address = "1080 Mississauga Road, Mississauga, ON",
    TotalArea = 240,
    BedroomNo = 5,
    WashroomNo = 5,
    ParkingNo = 3,
    Description = "Beautiful detached house with simple furniture provided",
    RentalPrice = 2400
},
new Listing
{
    ListingId = 2,
    HouseTypeId = 2,
    Address = "2072 Dundas Road West, Mississauga, ON",
    TotalArea = 200,
    BedroomNo = 5,
    WashroomNo = 5,
    ParkingNo = 2,
    Description = "Beautiful semi-detached house with simple furniture provided",
    RentalPrice = 2300
},
new Listing
{
    ListingId = 3,
    HouseTypeId = 3,
    Address = "1688 Mississauga Vally, Mississauga, ON",
    TotalArea = 200,
    BedroomNo = 5,
    WashroomNo = 3,
    ParkingNo = 2,
    Description = "Beautiful townhouse with simple furniture provided",
    RentalPrice = 2300
},
new Listing
{
    ListingId = 4,
    HouseTypeId = 4,
    Address = "568 Burnhamthorpe Road West, Mississauga, ON",
    TotalArea = 180,
    BedroomNo = 3,
    WashroomNo = 3,
    ParkingNo = 1,
    Description = "Beautiful Bungalow",
    RentalPrice = 2200
},
new Listing
{
    ListingId = 5,
    HouseTypeId = 5,
    Address = "1266 Erindale Station Road, Mississauga, ON",
    TotalArea = 170,
    BedroomNo = 3,
    WashroomNo = 3,
    ParkingNo = 1,
    Description = "Beautiful split-level House",
    RentalPrice = 2200
},
new Listing
{
    ListingId = 6,
    HouseTypeId = 6,
    Address = "760 Dunlop Street East, Barrie, ON",
    TotalArea = 160,
    BedroomNo = 4,
    WashroomNo = 4,
    ParkingNo = 2,
    Description = "Beautiful cottage with a small yard",
    RentalPrice = 2800
},
new Listing
{
    ListingId = 7,
    HouseTypeId = 7,
    Address = "640 Grand Park Drive, Mississauga, ON",
    TotalArea = 80,
    BedroomNo = 2,
    WashroomNo = 2,
    ParkingNo = 1,
    Description = "Beautiful condominium with security",
    RentalPrice = 1800
},
new Listing
{
    ListingId = 8,
    HouseTypeId = 8,
    Address = "395 Wolfedale Road, Mississauga, ON",
    TotalArea = 80,
    BedroomNo = 2,
    WashroomNo = 2,
    ParkingNo = 1,
    Description = "Beautiful apartment",
    RentalPrice = 1600
},
new Listing
{
    ListingId = 9,
    HouseTypeId = 9,
    Address = "115 Eighth Line, Oakville, ON",
    TotalArea = 240,
    BedroomNo = 5,
    WashroomNo = 5,
    ParkingNo = 3,
    Description = "Nothing special",
    RentalPrice = 2400
}
);


        }


    }

}

