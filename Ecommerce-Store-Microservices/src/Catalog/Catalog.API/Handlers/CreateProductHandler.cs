using AutoMapper;
using Catalog.API.Commands;
using Catalog.API.Models;
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
    public class CreateProductHandler: IRequestHandler<CreateProductCommand, ProductCommandResponse>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public CreateProductHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductCommandResponse> Handle(CreateProductCommand request, CancellationToken token)
        {
            var product = _mapper.Map<Product>(request);
            var id = await _repository.Create(product);

            return new ProductCommandResponse
            {
                Id = id,
                IsSuccess = true
            };
        }
    }
}
