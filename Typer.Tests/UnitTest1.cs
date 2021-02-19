using System.Linq;
using Xunit;
using Shouldly;
using System;
using Moq;
using MediatR;
using Typer.Application.Commands.Gameweeks.CreateGameweek;
using Typer.Infrastructure.Repositories;
using Typer.Infrastructure;
using System.Threading.Tasks;

namespace Typer.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var mediator = new Mock<IMediator>();
            var context = new TyperContext();
            var id = new Guid();
            var command = new CreateGameweekCommand()
            {
                SeasonId = id,
                GameweekNumber = 4
            };
            var handler = new CreateGameweekCommandHandler(new GameweekRepository(context));
            var r = await handler.Handle(command, new System.Threading.CancellationToken());
            var result = context.Gameweeks.FirstOrDefault(x => x.GameweekId == id);
            result.SeasonId.ShouldBe(id);
            result.GameweekNumber.ShouldBe(4);
        }
    }
}
