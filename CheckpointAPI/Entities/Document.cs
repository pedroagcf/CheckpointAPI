using System;
using MongoDB.Bson;
using CheckpointAPI.Interfaces;

namespace CheckpointAPI.Entities;

public abstract class Document : IDocument
{
    public ObjectId Id { get; set; }

    public DateTime CreatedAt => Id.CreationTime;

}

