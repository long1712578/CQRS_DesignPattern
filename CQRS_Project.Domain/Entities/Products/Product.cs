using System.ComponentModel.DataAnnotations;

namespace CQRS_Project.Domain.Entities.Products
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string? Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
