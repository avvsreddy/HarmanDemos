using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogService.Model.Data
{
    public class AppIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        // configure db
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {

        }
    }
}
