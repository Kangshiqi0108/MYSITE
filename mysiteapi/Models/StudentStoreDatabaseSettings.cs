namespace mysiteapi.Models;

public class StudentStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string StudentCollectionName { get; set; } = null!;
}