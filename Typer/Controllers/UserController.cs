using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;
using Typer.Logic.Commands.User.CreateUserCommand;
using Typer.Logic.Queries.User.GetUser;

namespace Typer.Controllers
{
    public class userDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        private readonly TyperContext _context;
        public UserController(TyperContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult AddUser(userDto userdto)
        {
            var user = new User
            {
                Email = userdto.Email,
                Password = userdto.Password,
                Username = userdto.Username,
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(long id)
        {
            var user = _context.Users.First(x => x.UserId == id);
            return Ok(user);
        }
    }
}
