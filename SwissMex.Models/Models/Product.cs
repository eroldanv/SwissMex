using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissMex.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string PartNumber { get; set; }


        [Required]
        public required string Brand { get; set; }

        [Required]
        [Display(Name = "Precio de Lista")]
        [Range(1,10000000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Precio 1-25")]
        [Range(1, 10000000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Precio 25+")]
        [Range(1, 10000000)]
        public double Price25 { get; set; }

        [Required]
        [Display(Name = "Precio 50+")]
        [Range(1, 10000000)]
        public double Price50 { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; } = null!;

        public string ImageUrl { get; set; } = string.Empty;


    }
}
