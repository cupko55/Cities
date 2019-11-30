using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cities.Entities.Entities;

namespace Cities.Contracts.Repositories
{
    public interface ICityRepository: IRepositoryBase<City>
    {
        Task<City> Get(int id);
    }
}
