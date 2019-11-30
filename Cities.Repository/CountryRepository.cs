using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cities.Contracts.Repositories;
using Cities.Entities;
using Cities.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cities.Repository
{
    public class CountryRepository: RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(CitiesDbContext context): base(context)
        {
            
        }

        public new async Task<IEnumerable<Country>> GetAll()
        {
            var list = await base.Context.Countries.OrderBy(x => x.Name).ToListAsync();
            return list;
        }
    }
}
