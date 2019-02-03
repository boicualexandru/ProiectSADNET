﻿using Data.EntryData;
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

            var brandsEntryDataProvider = new BrandsEntryDataProvider();
            var modelsEntryDataProvider = new ModelsEntryDataProvider();

            modelBuilder.Entity<Brand>().HasData(brandsEntryDataProvider.Data);
            modelBuilder.Entity<Model>().HasData(modelsEntryDataProvider.Data);
        }
    }
}
