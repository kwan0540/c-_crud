using crud.user.service;
using Microsoft.AspNetCore.Mvc;

namespace crud.user;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        this.userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        var user = await userService.getUsers();
        return Ok(user);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<User>>> GetUserById(int id)
    {
        var user = await userService.getUserById(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user)
    {
        var createdUser = await userService.createUser(user);
        return Ok(createdUser);
    }
}
