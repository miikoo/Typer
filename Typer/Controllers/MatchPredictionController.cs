using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateMatchPrediction;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchPredictionController : BaseTyperController
    {
        public MatchPredictionController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatchPrediction([FromBody] CreateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));
    }
}
