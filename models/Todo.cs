using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    //dbcontext
    public class TodoItemContext : DbContext
    {
        public TodoItemContext(DbContextOptions<TodoItemContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }

    //ToDo item
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}