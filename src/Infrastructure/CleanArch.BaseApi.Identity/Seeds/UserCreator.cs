using CleanArch.BaseApi.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace CleanArch.BaseApi.Identity.Seeds
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Dhiullian",
                LastName = "Santos",
                UserName = "admin",
                Email = "admin@test.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Projetin@123");
            }
        }
    }
}
