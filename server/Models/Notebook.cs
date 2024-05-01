namespace noter.Models;

public class Notebook
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }
    public string CoverImg { get; set; }
    public string CreatorId { get; set; }
    public Account Creator { get; set; }
}