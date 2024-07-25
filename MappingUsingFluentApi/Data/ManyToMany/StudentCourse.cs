﻿using DefaultTechnique.Data.ManyToMany;

namespace MappingUsingFluentApi.Data.ManyToMany
{
    public class StudentCourse
    {
        public int StudentCourseId { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
