using CQRS_Project.Application.Configurations.Commands.Common;
using CQRS_Project.Application.Dtos.Products;

namespace CQRS_Project.Application.Configurations.Commands.Products
{
    public class CreateProductCommand : CommandBase<ProductDto>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public CreateProductCommand(string? name, string? description, decimal? price) 
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
