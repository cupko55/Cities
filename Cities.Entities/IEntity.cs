using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateUpdated { get; set; }
    }
}
