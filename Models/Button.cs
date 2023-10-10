using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcButton.Models
{
    public class Button
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Size { get; set; }
        public string Materials { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}

