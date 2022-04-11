using MediatR;
using MediatRExample.Med.Commands;
using MediatRExample.Med.Queries.GetAllProductQuery;
using MediatRExample.Med.Queries.GetProductByIdQuery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;    
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }   

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpPost()]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
