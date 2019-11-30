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
    public class CityRepository: RepositoryBase<City>, ICityRepository
    {
        public CityRepository(CitiesDbContext context): base(context)
        {
            
        }

        public new async Task<IEnumerable<City>> GetAll()
        {
            var list = await base.Context.Cities
                .Include(x => x.Country)
                .OrderBy(x => x.Name)
                .ToListAsync();

            return list;
        }

        public async Task<City> Get(int id)
        {
            var entity = await Context.Cities
                .Where(x => x.Id == id)
                .Include(x => x.Country)
                .FirstOrDefaultAsync();

            return entity;
        }
    }
}
