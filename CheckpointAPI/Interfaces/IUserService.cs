using System;
using CheckpointAPI.Entities;

namespace CheckpointAPI.Interfaces
{
    public interface IUserService
    {

        IQueryable<User> FindAll();
        Task<User> FindById(string id);
        Task Save(User newUser);
    }
}

