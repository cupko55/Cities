using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Entities.Entities
{
    public class Country: IEntity, IIsDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public Country()
        {
            
        }

        public Country(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
