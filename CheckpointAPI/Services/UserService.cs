using System;
using System.Linq;
using CheckpointAPI.Entities;
using CheckpointAPI.Interfaces;
using CheckpointAPI.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CheckpointAPI.Services;

public class UserService : IUserService
{
    private readonly IMongoRepository<User> _userRepository;

    public UserService(IMongoRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    public IQueryable<User> FindAll() => _userRepository.AsQueryable();

    public async Task<User> FindById(string id) => await _userRepository.FindByIdAsync(id);

    public async Task Save(User newUser) {
        await _userRepository.InsertOneAsync(newUser);
    }
}

