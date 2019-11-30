using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cities.Contracts.DTOs;
using Cities.Entities.Entities;

namespace Cities.Services.Mapping.Profiles
{
    public class ItemProfile: Profile
    {
        public ItemProfile()
        {
            CreateMap<Country, ItemViewModel>();
            CreateMap<Country, ItemListViewModel>();
        }
    }
}
