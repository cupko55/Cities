using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cities.Contracts.DTOs;
using Cities.Entities.Entities;

namespace Cities.Services.Mapping.Profiles
{
    public class CityProfile: Profile
    {
        public CityProfile()
        {
            CreateMap<CityDto, City>()
                .ReverseMap();

            CreateMap<City, CityViewModel>()
                .ForMember(x => x.CountryName, y => y.MapFrom(z => z.Country.Name));

            CreateMap<List<City>, CityListViewModel>()
                .ForMember(x => x.Count, y => y.MapFrom(z => z.Count))
                .ForMember(x => x.Cities, y => y.MapFrom(z =>z));
        }
    }
}
