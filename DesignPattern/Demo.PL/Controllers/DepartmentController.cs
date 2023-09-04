using Demo.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepo departmentRepo;

        public DepartmentController(IDepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }
        public IActionResult Index()
        {
            return View(departmentRepo.GetAll());
        }
    }
}
