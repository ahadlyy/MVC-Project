
using Microsoft.EntityFrameworkCore;

namespace myProject.Models
{
    public class adlyDB : DbContext
    {
        public DbSet<Course> courses { get; set;}
        public DbSet<crsResult> crs { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Trainee> traines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=myWork;Integrated Security=True;TrustServerCertificate=true;");
            }
        }
    }
}
