using Day02Task.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day02Task.ViewModel
{
    public class DepartmentViewModel
    {
        public string DepartmentName { get; set; }
        public List<SelectListItem> Students { get; set; }
        public string DepartmentState { get; set; }
    }
}
