﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Day02Task.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
