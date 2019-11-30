using System;
using System.Collections.Generic;
using System.Text;
using Cities.Contracts.Services;

namespace Cities.Contracts
{
    public interface IServiceWrapper
    {
        ICityService CityService { get; }
        ICountryService CountryService { get; }
    }
}
