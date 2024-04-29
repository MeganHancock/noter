namespace noter.Services;

public class NotebooksService
{
    private readonly NotebooksRepository _repository;

    public NotebooksService(NotebooksRepository repository)
    {
        _repository = repository;
    }

}