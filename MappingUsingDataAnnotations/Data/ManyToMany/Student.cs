using System.ComponentModel.DataAnnotations;

namespace MappingUsingDataAnnotations.Data.ManyToMany
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
