using CloudCustomers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    private readonly IUsersServices _usersService;

    //private readonly ILogger<UsersController> _logger;

    public UsersController(IUsersServices usersService)
    {
        _usersService = usersService;
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        return Ok("all good");
    }
}
