// /blazor-demo/TodoService.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;

public class TodoService
{
    private readonly ILocalStorageService _localStorage;
    private readonly ILogger<TodoService> _logger;
    private const string TodoListKey = "TodoList";

    public TodoService(ILocalStorageService localStorage, ILogger<TodoService> logger)
    {
        _localStorage = localStorage;
        _logger = logger;
    }

    public async Task<List<TodoItem>> GetTodosAsync()
    {
        var todos = await _localStorage.GetItemAsync<List<TodoItem>>(TodoListKey) ?? new List<TodoItem>();
        _logger.LogInformation($"Loaded {todos.Count} todos from local storage.");
        return todos;
    }

    public async Task AddTodoAsync(TodoItem newItem)
    {
        if (newItem == null || string.IsNullOrWhiteSpace(newItem.Title))
        {
            // Basic validation
            return;
        }

        var todos = await GetTodosAsync();
        todos.Add(newItem);
        await _localStorage.SetItemAsync(TodoListKey, todos);
        await Task.Delay(100);
        _logger.LogInformation($"Added todo: {newItem.Title}");
    }

    public async Task UpdateTodoAsync(TodoItem updatedItem)
    {
        var todos = await GetTodosAsync();
        var existingItem = todos.FirstOrDefault(t => t.Id == updatedItem.Id);
        if (existingItem != null)
        {
            existingItem.Title = updatedItem.Title;
            existingItem.IsDone = updatedItem.IsDone;
            await _localStorage.SetItemAsync(TodoListKey, todos);
            await Task.Delay(100);
            _logger.LogInformation($"Updated todo: {updatedItem.Title}");
        }
    }

    public async Task DeleteTodoAsync(Guid id)
    {
        var todos = await GetTodosAsync();
        var itemToRemove = todos.FirstOrDefault(t => t.Id == id);
        if (itemToRemove != null)
        {
            todos.Remove(itemToRemove);
            await _localStorage.SetItemAsync(TodoListKey, todos);
            await Task.Delay(100);
            _logger.LogInformation($"Deleted todo: {id}");
        }
    }
}
