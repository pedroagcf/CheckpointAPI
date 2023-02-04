using System;

namespace CheckpointAPI.Entities;
[BsonCollection("users")]
public class User : Document
{
    public string Name { get; set; } = null!;
    public string role { get; set; } = null!;
}