using Docker.Dummy.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Docker.Dummy.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UsersContext _userContext;

    public UserController(UsersContext userContext)
    {
        _userContext = userContext;
    }

    [HttpGet]
    [ProducesResponseType(200)]
    public IActionResult GetUsers()
    {
        return Ok(_userContext.Users);
    }
}