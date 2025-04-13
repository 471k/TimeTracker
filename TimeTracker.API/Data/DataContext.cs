using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TimeTracker.API.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeEntry>().Navigation(c => c.Project).AutoInclude();
            modelBuilder.Entity<Project>().Navigation(c => c.ProjectDetails).AutoInclude();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
    }
}
