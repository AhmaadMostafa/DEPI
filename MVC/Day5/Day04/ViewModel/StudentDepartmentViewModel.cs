using Day04.Models;

namespace Day04.ViewModel
{
    public class StudentDepartmentViewModel
    {
        public Student Student { get; set; }
        public int Age { get; set; }
        public List<Department> Departments { get; set; }
    }
}
