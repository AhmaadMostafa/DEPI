namespace Day04.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Course> Course { get; set; }
        public List<Student> Students { get; set; }
    }
}
