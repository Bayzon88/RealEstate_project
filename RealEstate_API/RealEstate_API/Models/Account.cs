using System.ComponentModel.DataAnnotations;

namespace RealEstate_API.Models
{
    public class Account
    {

        // properties
        [Key]
        public Guid AcctId { get; set; }

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
        public DateTime CreationTime { get; set; }
        public DateTime LastLoginTime { get; set; }

        // constructor
        public Account()
        {
        }
    }
}
