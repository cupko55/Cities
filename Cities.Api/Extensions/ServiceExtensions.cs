using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cities.Api.Filters;
using Cities.Contracts;
using Cities.Entities;
using Cities.Entities.Entities;
using Cities.Repository;
using Cities.Services;
using Cities.Services.Mapping.Profiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Cities.Api.Extensions
{
    public static class ServiceExtensions {
        
        
        public static void ConfigureAutoMapper (this IServiceCollection services) {
            var config = new AutoMapper.MapperConfiguration (c => {
                c.AddProfile(new CityProfile());
                c.AddProfile(new ItemProfile());
            });
            var mapper = config.CreateMapper ();
            services.AddSingleton (mapper);
        }
        

        public static void ConfigureSqlServerConnection (this IServiceCollection services, IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString ("DefaultConnection");
            services.AddDbContext<CitiesDbContext> (o => o.UseSqlServer (connectionString));
        }

        public static void ConfigureRepositoryWrapper (this IServiceCollection services) {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper> ();
        }

        public static void ConfigureServiceWrapper (this IServiceCollection services) {
            services.AddScoped<IServiceWrapper, ServiceWrapper> ();
        }

        public static void ConfigureValidation (this IServiceCollection services) {
            services.AddScoped<ValidationFilterAttribute> ();
            services.AddScoped<ValidateEntityExistsAttribute<City>> ();
        }
    }
}
