using Demo.BLL.Interfaces;
using Demo.DAL.Entites;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                departmentRepo.Add(department);
                return RedirectToAction("Index");
            }
            else
            {
                return View(department);
            }
        }
    }
}
