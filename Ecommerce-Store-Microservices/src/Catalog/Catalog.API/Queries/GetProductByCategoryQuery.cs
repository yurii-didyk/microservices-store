using Catalog.API.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Queries
{
    public class GetProductByCategoryQuery: IRequest<IEnumerable<ProductResponse>>
    {
        public string Category { get; set; }

        public GetProductByCategoryQuery(string category)
        {
            Category = category;
        }
    }
}
