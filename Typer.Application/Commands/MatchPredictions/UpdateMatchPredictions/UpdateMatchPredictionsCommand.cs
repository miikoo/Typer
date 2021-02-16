using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPredictions.UpdateMatchPredictions
{ 
    public class UpdateMatchPredictionsCommand : IRequest<Unit>
    {
        public List<MatchPredictionDto> Predictions { get; set; }
    }
}
