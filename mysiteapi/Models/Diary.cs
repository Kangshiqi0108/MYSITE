using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mysiteapi.Models;

public class Diary
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("title")]
    public string title { get; set; } = null!;

    [BsonElement("date")]
    public string? date { get; set; }
    [BsonElement("weather")]
    public string weather { get; set; } = null!;
    [BsonElement("content")]
    public string content { get; set; } = null!;
}