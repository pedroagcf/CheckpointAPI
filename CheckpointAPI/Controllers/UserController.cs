using System;
using CheckpointAPI.Entities;
using CheckpointAPI.Interfaces;
using CheckpointAPI.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService) {
        _userService = userService;
    }

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<User>> Get(string id)
    {
        var user = await _userService.FindById(id);

        if (user is null)
        {
            return NotFound();
        }

        return user;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User newUser)
    {
        await _userService.Save(newUser);
        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }
    // CRUD methods 
}