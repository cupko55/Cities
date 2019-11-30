using System;
using System.Collections.Generic;
using System.Text;
using Cities.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cities.Entities.Extensions
{
    public static class DbContextStaticSeed
    {
        public static void SeedCountriesTable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasData(new Country(1, "Austrija"));

            modelBuilder.Entity<Country>()
                .HasData(new Country(2, "Bosna i Hercegovina"));

            modelBuilder.Entity<Country>()
                .HasData(new Country(3, "Hrvatska"));

            modelBuilder.Entity<Country>()
                .HasData(new Country(4, "Slovenija"));

            modelBuilder.Entity<Country>()
                .HasData(new Country(5, "Srbija"));

            modelBuilder.Entity<Country>()
                .HasData(new Country(6, "Mađarska"));
        }
    }
}
