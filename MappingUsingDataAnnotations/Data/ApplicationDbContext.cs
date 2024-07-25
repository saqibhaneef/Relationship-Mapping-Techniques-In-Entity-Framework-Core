using MappingUsingDataAnnotations.Data.ManyToMany;
using MappingUsingDataAnnotations.Data.OneToMany;
using MappingUsingDataAnnotations.Data.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace DefaultTechnique.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        //One-to-One relation
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        //ONe-to-Many relation
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Many-to-Many relation
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure other relationships if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
