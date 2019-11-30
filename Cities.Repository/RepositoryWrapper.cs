using System;
using System.Collections.Generic;
using System.Text;
using Cities.Contracts;
using Cities.Contracts.Repositories;
using Cities.Entities;

namespace Cities.Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private CitiesDbContext _context;
        
        private ICityRepository _cityRepository;
        private ICountryRepository _countryRepository;

        public RepositoryWrapper(CitiesDbContext context)
        {
            _context = context;
        }

        public ICityRepository CityRepository => 
            _cityRepository ?? (_cityRepository = new CityRepository(_context));

        public ICountryRepository CountryRepository =>
            _countryRepository ?? (_countryRepository = new CountryRepository(_context));
    }
}
