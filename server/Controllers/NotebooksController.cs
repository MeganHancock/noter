namespace noter.Controllers;

public class NotebooksController
{
    private readonly NotebooksService _notebooksService;
    public NotebooksController(NotebooksService notebooksService)
    {
        _notebooksService = notebooksService;
    }

}