// /blazor-demo/TodoItem.cs
public class TodoItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public bool IsDone { get; set; }
}
