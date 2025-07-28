using Microsoft.EntityFrameworkCore;

namespace WebExampleWithEr.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
