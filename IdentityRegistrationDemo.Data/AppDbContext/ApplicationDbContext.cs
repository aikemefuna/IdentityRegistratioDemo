using IdentityRegistrationDemo.Data.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace IdentityRegistrationDemo.Data.AppDbContext
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Citizen> Citizens { get; set; }
    }
}
