namespace TodoApp.Models
{
    public class TodoItem
    {
        public int Id {get; set;} //Primary Key
        public string Title {get; set;} = string.Empty;
        public bool IsCompleted {get;set;}
    }
}