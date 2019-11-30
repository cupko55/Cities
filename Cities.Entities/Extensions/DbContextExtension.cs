using System;
using System.Collections.Generic;
using System.Text;
using Cities.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cities.Entities.Extensions
{
    public static class DbContextExtension
    {
        public static void ConfigureCountriesTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property (x => x.DateCreated)
                .HasDefaultValueSql ("GETDATE()");

            modelBuilder.Entity<Country>()
                .Property (x => x.DateUpdated)
                .HasDefaultValueSql ("GETDATE()");

            modelBuilder.Entity<Country>()
                .Property(x=>x.IsDeleted)
                .HasDefaultValue(false);
            modelBuilder.Entity<Country>().HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }

        public static void ConfigureCitiesTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property (x => x.DateCreated)
                .HasDefaultValueSql ("GETDATE()");

            modelBuilder.Entity<City>()
                .Property (x => x.DateUpdated)
                .HasDefaultValueSql ("GETDATE()");

            modelBuilder.Entity<City>()
                .Property(x=>x.IsDeleted)
                .HasDefaultValue(false);
            modelBuilder.Entity<City>().HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }
    }
}
