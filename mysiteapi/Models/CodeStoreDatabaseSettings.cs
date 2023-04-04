namespace mysiteapi.Models;

public class CodeStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string CodeCollectionName { get; set; } = null!;
}