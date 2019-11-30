using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cities.Contracts.DTOs;

namespace Cities.Contracts.Services
{
    public interface ICountryService
    {
        Task<ItemListViewModel> GetList();
    }
}
