using Microsoft.EntityFrameworkCore;

namespace dojo_activity_center.Models
{
    public class AshContext : DbContext
    {
        public AshContext(DbContextOptions<AshContext> options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<Activity> Activities {get; set;}
        public DbSet<Participate> Participate {get; set;}
    }
}