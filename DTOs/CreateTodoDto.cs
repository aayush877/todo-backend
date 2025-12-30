using System.ComponentModel.DataAnnotations;

namespace TodoApp.DTOs
{

    public class CreateTodoDto
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;
    }
}