// add some  attributes and characteristics of the product
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcButton.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Size { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string Material{ get; set; }
        public decimal Price { get; set; }
    }
}