using ILearningApp.Application.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ILearningApp.Application.Dto;
using System.Linq;
using MediatR;
using ILearningApp.Application.Features.Queries.GetAllProducts;
using ILearningApp.Application.Features.Commands.CreateProduct;
using ILearningApp.Application.Features.Queries.GetProductById;
using System;

namespace ILearningApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator Mediator)
        {
            mediator = Mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Query = new GetAllProductsQuery();
            return Ok(await mediator.Send(Query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id};
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
