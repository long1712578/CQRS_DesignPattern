using CQRS_Project.Application.Configurations.Commands.Common;
using CQRS_Project.Application.Dtos.Products;
using CQRS_Project.Domain.Interfaces;

namespace CQRS_Project.Application.Configurations.Commands.Products
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ProductDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
