using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Models.Core;

namespace Vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Feature> Features { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
                new { vf.VehicleId, vf.FeatureId });
        }
    }
}