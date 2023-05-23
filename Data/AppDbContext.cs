using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Entities.ToDo.ToDo> ToDoItems { get; set; }
    }
}