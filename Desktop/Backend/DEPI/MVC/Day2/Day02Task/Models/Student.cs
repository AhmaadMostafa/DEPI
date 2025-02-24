using System.ComponentModel.DataAnnotations.Schema;

namespace Day02Task.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<CourseResult> CourseResult { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
