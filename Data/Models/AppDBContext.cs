using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Data.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<RecordFeature> RecordsFeatures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.GetSection("ConnectionStrings:App").ToString();
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Seat" },
                new Brand { Id = 2, Name = "Renault" },
                new Brand { Id = 3, Name = "Peugeot" }
            );
            
            modelBuilder.Entity<Model>().HasData(
                new Model { Id = 1, BrandId = 1, Name = "Seat" },
                new Model { Id = 2, BrandId = 1, Name = "Altea" },
                new Model { Id = 3, BrandId = 1, Name = "Altea XL" },
                
                new Model { Id = 4, BrandId = 2, Name = "Captur" },
                new Model { Id = 4, BrandId = 2, Name = "Clio" }
            );
        }
    }
}
