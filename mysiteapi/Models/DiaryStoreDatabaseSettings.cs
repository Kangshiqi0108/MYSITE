namespace mysiteapi.Models;

public class DiaryStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string DiaryCollectionName { get; set; } = null!;
}