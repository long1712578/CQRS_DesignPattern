using CQRS_Project.Application.Dtos.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            return null;
        }
    }
}
