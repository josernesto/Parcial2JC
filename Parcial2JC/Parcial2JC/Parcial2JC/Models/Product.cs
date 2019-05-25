
namespace Parcial2JC.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public double Price { get; set; }
    }

    internal class DisplayAttribute : Attribute
    {
        public string Name;
    }

    internal class RequiredAttribute : Attribute
    {
    }

    internal class KeyAttribute : Attribute
    {
    }
}
