using mysiteapi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace mysiteapi.Services;

public class CodeService
{
    private readonly IMongoCollection<Code> _codeCollection;

    public CodeService(
        IOptions<CodeStoreDatabaseSettings> codeStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            codeStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            codeStoreDatabaseSettings.Value.DatabaseName);

        _codeCollection = mongoDatabase.GetCollection<Code>(
            codeStoreDatabaseSettings.Value.CodeCollectionName);
    }

    public async Task<List<Code>> GetAsync() =>
        await _codeCollection.Find(_ => true).ToListAsync();

    public async Task<Code?> GetAsync(string id) =>
        await _codeCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Code newCode) =>
        await _codeCollection.InsertOneAsync(newCode);

    public async Task UpdateAsync(string id, Code updatedCode) =>
        await _codeCollection.ReplaceOneAsync(x => x.Id == id, updatedCode);

    public async Task RemoveAsync(string id) =>
        await _codeCollection.DeleteOneAsync(x => x.Id == id);
}