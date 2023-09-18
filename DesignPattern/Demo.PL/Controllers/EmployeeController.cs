using Demo.BLL.Interfaces;
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

    }
}
