using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Contracts.DTOs
{
    public class CityListViewModel
    {
        public List<CityViewModel> Cities { get; set; }
        public int Count { get; set; }
    }
}
