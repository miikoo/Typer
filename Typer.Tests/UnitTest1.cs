using Flurl.Http;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Typer.API.Controllers;
using Typer.Application.Commands.Teams.CreateTeam;
using Typer.Domain.Models;
using Typer.Infrastructure;
using Xunit;

namespace Typer.Tests
{
    public class UnitTest1 : BaseTest
    {

        [Fact]
        public async Task Test1()
        {
            var command = new CreateTeamCommand { TeamName = "asd" };
            _context.Teams.Add(new Infrastructure.Entities.DbTeam { TeamId = new Guid().ToString(), TeamName = "dsa" });
            _context.SaveChanges();
            var y = _context.Teams.Select(x => x).ToList();
            var response = await FlurlClient
                .Request("api/team")
                .PostJsonAsync(command)
                .ReceiveJson<Unit>();
            var x = _context.Teams.Select(x => x).ToList();
        }
    }
}
