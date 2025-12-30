using System.ComponentModel.DataAnnotations;

namespace TodoApp.DTOs
{
    
    public class UpdateTodoDto
    {
        [Required]
        public bool IsCompleted { get; set;}
    }
}