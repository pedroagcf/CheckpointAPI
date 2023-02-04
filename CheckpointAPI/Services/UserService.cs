using System;
using CheckpointAPI.Entities;
using MongoDB.Driver;

namespace CheckpointAPI.Services;

public class UserService
{
    private readonly IMongoCollection<User> _userCollection = null!;

}

