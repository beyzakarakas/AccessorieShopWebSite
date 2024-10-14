using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurKarakas_ErenMeral.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required] // name alanını gerekli kılar.
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Ürün adını 5-60 karakter arasında girmeniz gerekmektedir.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Fiyat girmelisiniz.")]
        [Range(1, 100000)]
        public double? Price { get; set; }
        public string? Description { get; set; }

        [Required]
        public string? ImageUrl { get; set; }
        public bool IsApproved { get; set; }

        [Required]
        public int? CategoryId { get; set; }
    }
}