﻿using System.ComponentModel.DataAnnotations;

namespace RealEstate_API.Models
{
    public class Listing
    {
        // properties
    
        public int ListingId { get; set; }

        public int LandlordId { get; set; } = 1;

        [Required(ErrorMessage = "Please enter house type.")]
        public int HouseTypeId { get; set; }
        public HouseType? HouseType { get; set; }

        [Required(ErrorMessage = "Please enter the address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter total area.")]
        public double TotalArea { get; set; }

        [Required(ErrorMessage = "Please enter the number of bedroom.")]
        public int BedroomNo { get; set; }

        [Required(ErrorMessage = "Please enter the number of washroom.")]
        public int WashroomNo { get; set; }

        public int ParkingNo { get; set; } = 0;

        [Required(ErrorMessage = "Please describe your house.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the rental price.")]
        public double RentalPrice { get; set; }

        public DateTime ListingTime { get; set; } = DateTime.Now;

        public int ValidDays { get; set; } = 30;

        public bool Status { get; set; } = true;
    }
}
