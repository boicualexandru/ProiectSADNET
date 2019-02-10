using Data.EntryData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

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

            // RecordsFeatures slices
            modelBuilder.Entity<RecordFeature>().HasData(Slice(recordsfeaturesData, 0).ToArray());
            modelBuilder.Entity<RecordFeature>().HasData(Slice(recordsfeaturesData, 10000, 30000).ToArray());
            modelBuilder.Entity<RecordFeature>().HasData(Slice(recordsfeaturesData, 40000, 20000).ToArray());
            modelBuilder.Entity<RecordFeature>().HasData(Slice(recordsfeaturesData, 60000, 10000).ToArray());
        }

        private IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> source, int chunksize)
        {
            if (chunksize <= 0) throw new ArgumentException("Chunk size must be greater than zero.", "chunksize");

            while (source.Any())
            {
                yield return source.Take(chunksize);
                source = source.Skip(chunksize);
            }
        }

        private IEnumerable<T> Slice<T>(IEnumerable<T> source, int fromIndex, int chunksize = 10000)
        {
            if (chunksize <= 0) throw new ArgumentException("Chunk size must be greater than zero.", "chunksize");
            
            return source.Skip(fromIndex).Take(chunksize);
        }
    }
}
