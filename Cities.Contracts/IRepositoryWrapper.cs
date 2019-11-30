using System;
using System.Collections.Generic;
using System.Text;
using Cities.Contracts.Repositories;

namespace Cities.Contracts
{
    public interface IRepositoryWrapper
    {
        ICityRepository CityRepository { get; }
        ICountryRepository CountryRepository { get; }
    }
}
