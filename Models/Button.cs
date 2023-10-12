using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcButton.Models
{
    public class Button
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Size { get; set; }
        public string Materials { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}

