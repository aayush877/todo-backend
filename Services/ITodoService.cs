using TodoApp.DTOs;
using TodoApp.Models;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetAllAsync();
        Task<TodoItem> CreateAsync(CreateTodoDto dto);
        Task<bool> UpdateStatusAsync(int id, UpdateTodoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
