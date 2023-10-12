using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcButton.Models
{
    public class ButtonColorViewModel
    {
        public List<Button> Buttons { get; set; } 
        public SelectList Colors { get; set; } // This allows the user to select a color from the list.
        public string ButtonColor { get; set; }
        public string SearchString { get; set; }
    }
}