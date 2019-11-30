using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Entities.Entities
{
    public class City: IEntity, IIsDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zip { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
