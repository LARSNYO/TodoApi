namespace TodoApi.Models;

public class Todo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}