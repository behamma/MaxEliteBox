using MaxEliteBoxApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxEliteBoxApplication
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MeetingPerson> MeetingsPersons { get; set; }
        public DbSet<MeetingResult> MeetingResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=MaxEliteBox;Username=postgres;Password=alieren");
            }
        }
    }
}
