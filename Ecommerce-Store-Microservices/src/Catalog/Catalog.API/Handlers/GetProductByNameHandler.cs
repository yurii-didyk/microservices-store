using AutoMapper;
using Catalog.API.Queries;
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
    public class GetProductByNameHandler : IRequestHandler<GetProductByNameQuery, IEnumerable<ProductResponse>>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductByNameHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponse>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken) 
            =>_mapper.Map<IEnumerable<ProductResponse>>(await _repository.GetProductByCategory(request.Name));

    }
}
