using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Model.DataModel;

namespace UniversityApiBackend.Dataaccess
{
    public class UniversityDbContext :DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)

        { 
        
        }
        //todo : dbsets tablas
        public DbSet<User>?users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }

    }
}
