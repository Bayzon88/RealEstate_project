using Microsoft.AspNetCore.Identity;

namespace RealEstate_API.Models.Identity
{
    public class DbInitialize
    {
        public static async Task Initialize(UserManager<Users> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@example.com") == null)
            {
                var user = new Users
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    NormalizedUserName = "Admin User",
                };
                var result = await userManager.CreateAsync(user, "Password1234!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
        }
    }
}
