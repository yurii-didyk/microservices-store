using Catalog.API.Commands;
using Catalog.API.Repositories.Interfaces;
using Catalog.API.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.API.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, ProductCommandResponse>
    {
        private readonly IProductRepository _repository;
        public DeleteProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductCommandResponse> Handle(DeleteProductCommand request, CancellationToken token)
        {
            var response = await _repository.Delete(request.Id);

            return new ProductCommandResponse
            {
                Id = request.Id,
                IsSuccess = response
            };
        }
    }
}
