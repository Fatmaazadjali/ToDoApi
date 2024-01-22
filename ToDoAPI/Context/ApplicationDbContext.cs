using Microsoft.EntityFrameworkCore;
using ToDoAPI.Model;

namespace ToDoAPI.Context
{
    public class ApplicationDbContext : DbContext 
    {
        
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

           
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
