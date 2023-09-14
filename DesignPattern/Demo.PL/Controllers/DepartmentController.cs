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
        [ValidateAntiForgeryToken]
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
        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var dep = departmentRepo.get(id);
            if (dep == null)
                return NotFound();
            return View(ViewName, dep);
        }
        public IActionResult Edit(int? Id)
        {
            return Details(Id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int Id, Department department)
        {
            if (Id != department.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    departmentRepo.Update(department);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
        public IActionResult Delete(int? Id)
        {
            return Details(Id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute]int? Id, Department department)
        {
            if(Id != department.Id)
            {
                return NotFound();
            }
            try
            {
                departmentRepo.Delete(department);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception)
            {

                return BadRequest();
            }

        }
    }
}
