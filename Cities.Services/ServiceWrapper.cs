using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cities.Contracts;
using Cities.Contracts.Services;

namespace Cities.Services
{
    public class ServiceWrapper: IServiceWrapper
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        private ICityService _cityService;
        private ICountryService _countryService;

        public ServiceWrapper(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public ICityService CityService =>
            _cityService ?? (_cityService = new CityService(_repositoryWrapper, _mapper));

        public ICountryService CountryService =>
            _countryService ?? (_countryService = new CountryService(_repositoryWrapper, _mapper));
    }
}
