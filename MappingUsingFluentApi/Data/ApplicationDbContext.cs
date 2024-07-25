using DefaultTechnique.Data.ManyToMany;
using DefaultTechnique.Data.OneToMany;
using DefaultTechnique.Data.OneToOne;
using MappingUsingFluentApi.Data.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace DefaultTechnique.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                 modelBuilder.Entity<Person>()
            .HasOne(p => p.Passport)
            .WithOne(p => p.Person)
            .HasForeignKey<Passport>(p => p.PersonId); // Or use PrincipalKey/DependentKey

            modelBuilder.Entity<Blog>()
            .HasMany(b => b.Posts)
            .WithOne(a => a.Blog);

                modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<StudentCourse>(
                    js => js.HasOne(j => j.Course).WithMany(),
                    js => js.HasOne(j => j.Student).WithMany());

            base.OnModelCreating(modelBuilder);
        }
    }
}
