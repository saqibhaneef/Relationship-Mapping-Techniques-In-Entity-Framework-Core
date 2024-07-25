using DefaultTechnique.Data.ManyToMany;
using DefaultTechnique.Data.OneToMany;
using DefaultTechnique.Data.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace DefaultTechnique.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options)
           : base(options)
        {
        }

        //One to one relation of Passport and Persons
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Person> Persons { get; set; }

        //One to many relation of Blog and Post
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        //Many to Many Relation of Student and Course
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            // Configure other relationships if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
