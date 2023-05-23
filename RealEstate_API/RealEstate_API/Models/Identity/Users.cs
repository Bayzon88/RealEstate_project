using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate_API.Models.Identity
{
    public class Users : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
