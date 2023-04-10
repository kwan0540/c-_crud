using AutoMapper;
using crud.user.Dtos;
using crud.user.service;
using Microsoft.AspNetCore.Mvc;

namespace crud.user;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService userService;
    private readonly IMapper mapper;

    public UserController(ILogger<UserController> logger, IUserService userService, IMapper mapper)
    {
        _logger = logger;
        this.userService = userService;
        this.mapper = mapper;
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
    public async Task<ActionResult<User>> CreateUser(CreateUserDto createUserDto)
    {
        Console.WriteLine(ModelState.IsValid);
        if (!ModelState.IsValid)
        {
            Console.Write("false");
            return BadRequest("model is invalid");
        }
        Console.Write("test");
        var user = mapper.Map<User>(createUserDto);
        var createdUser = await userService.createUser(user);
        return Ok(createdUser);
    }

    [HttpPut]
    public async Task<ActionResult<User>> updateUser(User user)
    {
        var updatedUser = await userService.updateUser(user);
        return Ok(updatedUser);
    }
}
