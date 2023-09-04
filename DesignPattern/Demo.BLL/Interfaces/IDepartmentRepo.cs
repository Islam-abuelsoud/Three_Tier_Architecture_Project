using Demo.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IDepartmentRepo
    {
        Department get(int? id);
        IEnumerable<Department> GetAll();
        int Update(Department department);
        int Delete(Department department);
        int Add(Department department);
    }
}
