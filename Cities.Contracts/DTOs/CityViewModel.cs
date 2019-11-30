using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Contracts.DTOs
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zip { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get;set; }
    }
}
