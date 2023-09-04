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
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly DesignPatternAppContext context;

        public DepartmentRepo(DesignPatternAppContext context)
        {
            this.context = context;
        }
        public int Add(Department department)
        {

            context.Departments.Add(department);
            return context.SaveChanges();
        }

        public int Delete(Department department)
        {
            context.Remove(department);
            return context.SaveChanges();
        }

        public Department get(int? id)
        {
            return context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public int Update(Department department)
        {
            context.Departments.Update(department);
            return context.SaveChanges();
        }
    }
}
