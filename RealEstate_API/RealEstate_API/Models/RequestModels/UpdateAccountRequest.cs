﻿using System.ComponentModel.DataAnnotations;

namespace RealEstate_API.Models.RequestModels
{
    public class UpdateAccountRequest
    {
        // properties

        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }
        [Required]
        public long Phone { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
