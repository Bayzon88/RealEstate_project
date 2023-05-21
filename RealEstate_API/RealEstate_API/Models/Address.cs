﻿using System.ComponentModel.DataAnnotations;

namespace RealEstate_API.Models
{
    public class Address
    { // properties
        [Key]
        public int AddressId { get; set; }
        public int ListingId { get; set; }
        public int UnitNo { get; set; }
        public int StreetNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // constructor
        public Address()
        {

        }

    }
}
