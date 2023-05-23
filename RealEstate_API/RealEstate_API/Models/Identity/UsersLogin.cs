using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate_API.Models.Identity
{
    public class UsersLogin : IdentityUserLogin<string>
    {
        [NotMapped]
        public IList<string> UserLoginProperties { get; set; }

    }
}
