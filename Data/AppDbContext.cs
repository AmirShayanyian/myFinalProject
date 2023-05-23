using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }
        
        DbSet<Entities.ToDo.ToDo> ToDoItems { get; set; }
        DbSet<Entities.ToDoDescription.ToDoDescription> ToDoItemDescription { get; set; }
        DbSet<Entities.Users.Users> Users { get; set; }
    }
}