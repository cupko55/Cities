using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cities.Contracts.DTOs
{
    public class CityDto: IDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [DisplayName("Ime grada")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [DisplayName("Poštanski broj")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [DisplayName("Država")]
        [Range(1, int.MaxValue, ErrorMessage = "Odaberite jednu od ponuđenih opcija")]
        public int CountryId { get; set; }
    }
}
