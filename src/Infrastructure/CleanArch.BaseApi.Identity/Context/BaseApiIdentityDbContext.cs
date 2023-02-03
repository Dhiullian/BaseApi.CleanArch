using CleanArch.BaseApi.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.BaseApi.Identity.Context
{
    public class BaseApiIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public BaseApiIdentityDbContext(DbContextOptions<BaseApiIdentityDbContext> options) : base(options)
        {
        }
    }
}
