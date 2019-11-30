using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cities.Entities
{
    public class CitiesDbContextFactory : IDesignTimeDbContextFactory<CitiesDbContext> 
    {
        public CitiesDbContext CreateDbContext (string[] args)
        {
            var connectionString =
                "Server=localhost;Database=CitiesDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<CitiesDbContext> ();
            optionsBuilder.UseSqlServer (connectionString);

            return new CitiesDbContext (optionsBuilder.Options);
        }
    }
}
