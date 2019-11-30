using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cities.Contracts;
using Cities.Contracts.DTOs;
using Cities.Contracts.Services;

namespace Cities.Services
{
    public class CountryService: ICountryService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public CountryService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public async Task<ItemListViewModel> GetList()
        {
            var list = await _repositoryWrapper.CountryRepository.GetAll();
            return _mapper.Map<ItemListViewModel>(list);
        }
    }
}
