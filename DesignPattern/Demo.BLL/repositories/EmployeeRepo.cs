using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.repositories
{
    internal class EmployeeRepo : GenericRepo<Employee> ,IEmployeeRepo
    {
        public EmployeeRepo(DesignPatternAppContext context):base(context)
        {

        }

    }
}
