using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mysiteapi.Models;

public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("xuehao")]
    public string xuehao { get; set; } = null!;
    [BsonElement("first_name")]
    public string first_name { get; set; } = null!;

    [BsonElement("second_name")]
    public string? secong_name { get; set; }
    [BsonElement("gender")]
    public string gender { get; set; } = null!;
    [BsonElement("major")]
    public string major { get; set; } = null!;
}