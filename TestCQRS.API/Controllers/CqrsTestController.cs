using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestCQRS.Application.Test.Commands;
using TestCQRS.Application.Test.Queries;

namespace TestCQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CqrsTestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CqrsTestController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public Task<bool> Get() => _mediator.Send(new GetQuery());
        [HttpPost]
        public Task<string> Post(CreateCommand command) => _mediator.Send(command);

    }
}