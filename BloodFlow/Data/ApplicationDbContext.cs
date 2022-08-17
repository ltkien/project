using BloodFlow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodFlow.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.Seed(modelBuilder);
        }
        
        public DbSet<Address> Addresses { get; set; } = null!;

        public DbSet<Hospital> Hospitals { get; set; } = null!;
        
        public DbSet<RequestBlood> RequestBloods { get; set; } = null!;
        public DbSet<BloodDonationRequest> BloodDonationRequests { get; set; } = null!;
    }
}