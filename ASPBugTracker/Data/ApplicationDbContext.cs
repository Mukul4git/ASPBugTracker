using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPBugTracker.Models;

namespace ASPBugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPBugTracker.Models.Status> Status { get; set; }
        public DbSet<ASPBugTracker.Models.Priority> Priority { get; set; }
        public DbSet<ASPBugTracker.Models.bug> bug { get; set; }
    }
}