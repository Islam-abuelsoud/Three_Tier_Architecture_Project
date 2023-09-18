using Demo.BLL.Interfaces;
using Demo.BLL.repositories;
using Demo.DAL.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeRepo EmployeeRepo { get; }
        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            EmployeeRepo = employeeRepo;
        }
        public IActionResult Index()
        {
            return View(EmployeeRepo.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee Employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeRepo.Add(Employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View(Employee);
            }
        }
        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var dep = EmployeeRepo.get(id);
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
        public IActionResult Edit([FromRoute] int Id, Employee Employee)
        {
            if (Id != Employee.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeRepo.Update(Employee);
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
        public IActionResult Delete([FromRoute] int? Id, Employee Employee)
        {
            if (Id != Employee.Id)
            {
                return NotFound();
            }
            try
            {
                EmployeeRepo.Delete(Employee);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception)
            {

                return BadRequest();
            }

        }
    }
}
