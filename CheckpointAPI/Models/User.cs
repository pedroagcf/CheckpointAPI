using System;
namespace CheckpointAPI.Models;
public class User
{
    public User(){}

    public string? Id { get; set; }

  public string Name { get; set; } = null!;

  public decimal Password { get; set; }

  public string role { get; set; } = null!;

}

