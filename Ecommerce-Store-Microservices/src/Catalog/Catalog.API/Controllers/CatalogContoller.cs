using Catalog.API.Queries;
using Catalog.API.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogContoller: ControllerBase
    {
        private readonly IMediator _mediator;

        public CatalogContoller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
        {
            var query = new GetProductsQuery();
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProduct(string id)
        {
            var query = new GetProductByIdQuery(id);
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }

        [HttpGet]
        [Route("[action]/{category}")]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProductByCategory(string category)
        {
            var query = new GetProductByCategoryQuery(category);
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProductByName(string name)
        {
            var query = new GetProductByNameQuery(name);
            var orders = await _mediator.Send(query);
            return Ok(orders);
        }
    }
}
