﻿using System.ComponentModel.DataAnnotations;

namespace RealEstate_API.Models.RequestModels
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string Password { get; set; }


        public string ReturnUrl { get; set; } = "";

        public bool RememberMe { get; set; } = false;
    }
}
