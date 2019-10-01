using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Typer.Controllers
{
    [AllowAnonymous] // todo
    public class BaseTyperController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public BaseTyperController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
