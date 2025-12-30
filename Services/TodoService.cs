using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.DTOs;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _context;

        public TodoService(TodoContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems
                .OrderBy(t => t.IsCompleted)
                .ToListAsync();
        }

        public async Task<TodoItem> CreateAsync(CreateTodoDto dto)
        {
            var todo = new TodoItem
            {
                Title = dto.Title,
                IsCompleted = false
            };

            _context.TodoItems.Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<bool> UpdateStatusAsync(int id, UpdateTodoDto dto)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null) return false;

            todo.IsCompleted = dto.IsCompleted;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null) return false;

            _context.TodoItems.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
