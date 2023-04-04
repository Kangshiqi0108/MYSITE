using mysiteapi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace mysiteapi.Services;

public class DiaryService
{
    private readonly IMongoCollection<Diary> _diaryCollection;

    public DiaryService(
        IOptions<DiaryStoreDatabaseSettings> diaryStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            diaryStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            diaryStoreDatabaseSettings.Value.DatabaseName);

        _diaryCollection = mongoDatabase.GetCollection<Diary>(
            diaryStoreDatabaseSettings.Value.DiaryCollectionName);
    }

    public async Task<List<Diary>> GetAsync() =>
        await _diaryCollection.Find(_ => true).ToListAsync();

    public async Task<Diary?> GetAsync(string id) =>
        await _diaryCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Diary newDiary) =>
        await _diaryCollection.InsertOneAsync(newDiary);

    public async Task UpdateAsync(string id, Diary updatedDiary) =>
        await _diaryCollection.ReplaceOneAsync(x => x.Id == id, updatedDiary);

    public async Task RemoveAsync(string id) =>
        await _diaryCollection.DeleteOneAsync(x => x.Id == id);
}