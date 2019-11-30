using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cities.Contracts.DTOs;
using Cities.Entities.Entities;

namespace Cities.Contracts.Services
{
    public interface ICityService
    {
        Task<CityListViewModel> GetList();
        Task<CityDto> Get(int id);
        Task Create(CityDto model);
        Task Update(CityDto model, City entity);
        Task Delete(City entity);
    }
}
