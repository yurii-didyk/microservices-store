using Catalog.API.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Queries
{
    public class GetProductsQuery: IRequest<IEnumerable<ProductResponse>>
    {
    }
}
