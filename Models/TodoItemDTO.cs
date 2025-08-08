namespace TodoApi.Models;

public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Id, Title, IsComplete, CreatedAt) = (todoItem.Id, todoItem.Title, todoItem.IsComplete, todoItem.CreatedAt);
}
