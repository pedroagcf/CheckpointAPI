using System;
using CheckpointAPI.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    private readonly IMongoRepository<User> _userRepository;

    public UserController(IMongoRepository<User> userRepository) {
        _userRepository = userRepository;
    }

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<User>> Get(string id)
    {
        var user = await _userRepository.FindByIdAsync(id);
            //GetAsync(id);

        if (user is null)
        {
            return NotFound();
        }

        return user;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User newUser)
    {
        await _userRepository.InsertOneAsync(newUser);
        //CreateAsync(newUser);
        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }
    // CRUD methods 
}