using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cities.Contracts;
using Cities.Contracts.DTOs;
using Cities.Contracts.Services;
using Cities.Entities.Entities;

namespace Cities.Services
{
    public class CityService: ICityService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public CityService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public async Task<CityListViewModel> GetList()
        {
            var list = await _repositoryWrapper.CityRepository.GetAll();
            return _mapper.Map<CityListViewModel>(list);
        }

        public async Task<CityDto> Get(int id)
        {
            var entity = await _repositoryWrapper.CityRepository.Get(id);
            return _mapper.Map<CityDto>(entity);
        }

        public async Task Create(CityDto model)
        {
            var entity = _mapper.Map<City>(model);
            _repositoryWrapper.CityRepository.Create(entity);
            await _repositoryWrapper.CityRepository.SaveChanges();
        }

        public async Task Update(CityDto model, City entity)
        {
            entity.CountryId = model.CountryId;
            entity.Name = model.Name;
            entity.Zip = model.Zip;
            entity.DateUpdated = DateTime.Now;
            _repositoryWrapper.CityRepository.Update(entity);
            await _repositoryWrapper.CityRepository.SaveChanges();
        }

        public async Task Delete(City entity)
        {
            _repositoryWrapper.CityRepository.Delete(entity);
            await _repositoryWrapper.CityRepository.SaveChanges();
        }
    }
}
