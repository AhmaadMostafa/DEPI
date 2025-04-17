namespace Day04.ViewModel
{
    public class DepartmentDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public List<string> Teachers { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Students { get; set; }
    }
}
