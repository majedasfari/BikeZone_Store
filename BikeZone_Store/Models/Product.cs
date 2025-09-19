﻿using System.ComponentModel.DataAnnotations;

namespace BikeZone_Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
