using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mysiteapi.Models;

public class Code
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("file")]
    public string file { get; set; } = null!;

    [BsonElement("type")]
    public string? type { get; set; }
    [BsonElement("date")]
    public string date { get; set; } = null!;
    [BsonElement("codes")]
    public string codes { get; set; } = null!;
}