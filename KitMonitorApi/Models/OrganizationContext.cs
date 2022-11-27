using Microsoft.EntityFrameworkCore;

namespace KitMonitorApi.Models
{
    public class OrganizationContext: DbContext
    {
        public OrganizationContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}
