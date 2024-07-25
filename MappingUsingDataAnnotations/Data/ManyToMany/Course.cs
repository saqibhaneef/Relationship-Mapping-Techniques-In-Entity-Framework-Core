using System.ComponentModel.DataAnnotations;

namespace MappingUsingDataAnnotations.Data.ManyToMany
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        // Navigation property
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
