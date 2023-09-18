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
    public class DepartmentRepo : GenericRepo<Department>,IDepartmentRepo
    {
        public DepartmentRepo(DesignPatternAppContext context):base(context)
        {

        }

    }
}
