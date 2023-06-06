using mysiteapi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace mysiteapi.Services;

public class StudentService
{
    private readonly IMongoCollection<Student> _studentCollection;

    public StudentService(
        IOptions<StudentStoreDatabaseSettings> studentStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            studentStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            studentStoreDatabaseSettings.Value.DatabaseName);

        _studentCollection = mongoDatabase.GetCollection<Student>(
            studentStoreDatabaseSettings.Value.StudentCollectionName);
    }

    public async Task<List<Student>> GetAsync() =>
        await _studentCollection.Find(_ => true).ToListAsync();

    public async Task<Student?> GetAsync(string id) =>
        await _studentCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Student newStudent) =>
        await _studentCollection.InsertOneAsync(newStudent);

    public async Task UpdateAsync(string id, Student updatedStudent) =>
        await _studentCollection.ReplaceOneAsync(x => x.Id == id, updatedStudent);

    public async Task RemoveAsync(string id) =>
        await _studentCollection.DeleteOneAsync(x => x.Id == id);
}