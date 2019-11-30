using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Contracts.DTOs
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ItemViewModel()
        {
            
        }

        public ItemViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
