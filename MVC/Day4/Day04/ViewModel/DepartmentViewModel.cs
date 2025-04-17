using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day04.ViewModel
{
    public class DepartmentViewModel
    {
        public string DepartmentName { get; set; }
        public List<SelectListItem> Students { get; set; }
        public string DepartmentState { get; set; }
    }
}
