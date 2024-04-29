namespace noter.Repositories;

public class NotebooksRepository
{
    private readonly IDbConnection _db;
    public NotebooksRepository(IDbConnection db)
    {
        _db = db;
    }


}