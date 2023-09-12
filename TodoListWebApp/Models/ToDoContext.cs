using Microsoft.EntityFrameworkCore;

namespace TodoListWebApp.Models
{
    public class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<ToDo> ToDoSet { get; set; }
    }
}
