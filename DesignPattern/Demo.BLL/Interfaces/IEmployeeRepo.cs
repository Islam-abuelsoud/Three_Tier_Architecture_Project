using Demo.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepo:IGenericRepo<Employee>
    {

        //Employee get(int? id);
        //IEnumerable<Employee> GetAll();
        //int Update(Employee Employee);
        //int Delete(Employee Employee);
        //int Add(Employee Employee);
    }
}
