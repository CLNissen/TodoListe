using System.ComponentModel.DataAnnotations;

namespace TodoListDBContext
{ 
    public class Todo
    {
        [Key] 
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

    }
}
    
