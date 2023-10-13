using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcButton.Models
{
    public class Button
    {
        
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)] //Add validation rules like Required, StringLength
        [Required]
        public string Title { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]
        public decimal Size { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Materials { get; set; }

        [StringLength(70, MinimumLength = 4)]
        [Required]
        public string Color { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}

