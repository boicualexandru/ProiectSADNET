using Data.EntryData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

            var brandsEntryDataProvider = new BrandsEntryDataProvider();
            var modelsEntryDataProvider = new ModelsEntryDataProvider();

            var featuresEntryDataProvider = new FeaturesEntryDataProvider();
            var recordsEntryDataProvider = new RecordsEntryDataProvider();

            var recordsFeaturesEntryDataProvider = new RecordsFeaturesEntryDataProvider();
            var recordsFeaturesEntryDataProviderSecond = new RecordsFeaturesEntryDataProviderSecond();
            var recordsfeaturesData = new List<RecordFeature> { };
            recordsfeaturesData.AddRange(recordsFeaturesEntryDataProvider.Data);
            recordsfeaturesData.AddRange(recordsFeaturesEntryDataProviderSecond.Data);

            modelBuilder.Entity<Brand>().HasData(brandsEntryDataProvider.Data);
            modelBuilder.Entity<Model>().HasData(modelsEntryDataProvider.Data);

            modelBuilder.Entity<Feature>().HasData(featuresEntryDataProvider.Data);
            modelBuilder.Entity<Record>().HasData(recordsEntryDataProvider.Data);

            modelBuilder.Entity<RecordFeature>().HasData(recordsFeaturesEntryDataProvider.Data);
            modelBuilder.Entity<RecordFeature>().HasData(recordsFeaturesEntryDataProviderSecond.Data);
        }
    }
}
