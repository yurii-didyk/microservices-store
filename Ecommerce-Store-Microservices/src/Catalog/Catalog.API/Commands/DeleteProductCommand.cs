using Catalog.API.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Commands
{
    public class DeleteProductCommand: IRequest<ProductCommandResponse>
    {
        public string Id { get; set; }

        public DeleteProductCommand(string id)
        {
            Id = id;
        }
    }
}
