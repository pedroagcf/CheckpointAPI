using System;
using CheckpointAPI.Interfaces;
namespace CheckpointAPI.Settings;

public class MongoDbSettings : IMongoDbSettings
{
    public string DatabaseName { get; set; } = null!;
    public string ConnectionString { get; set; } = null!;
}

