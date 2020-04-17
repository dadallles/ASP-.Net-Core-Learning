using GigHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GigHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected readonly string DB = "Server=(localdb)\\mssqllocaldb;Database=aspnet-GigHub-8723E7E2-7481-4234-B864-29F2778A7FF1;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(DB);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
