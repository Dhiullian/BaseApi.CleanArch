using CleanArch.BaseApi.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Serilog;

namespace CleanArch.BaseApi.Api.Configurations
{
    public static class UserConfig
    {
        public static async void AddUserConfiguration(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var service = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();

                try
                {
                    var userManager = (UserManager<ApplicationUser>)service.GetService(typeof(UserManager<ApplicationUser>));
                    await Identity.Seeds.UserCreator.SeedAsync(userManager);
                    Log.Information("Application Starting");
                }
                catch (Exception ex)
                {
                    Log.Warning(ex, "An error occured while starting the application");
                }
            }
        }
    }
}
