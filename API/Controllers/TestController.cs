using ECommerce_Example.Features.Commands.Login;
using ECommerce_Example.Features.Commands.Product;
using ECommerce_Example.Features.Queries.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductCommandRequest request)
        {
            AddProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProduct([FromRoute]GetByIdProductQueryRequest request)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
