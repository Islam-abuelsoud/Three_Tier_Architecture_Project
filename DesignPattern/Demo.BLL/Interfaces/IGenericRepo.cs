using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IGenericRepo<T>
    {
        T get(int? id);
        IEnumerable<T> GetAll();
        int Update(T T);
        int Delete(T T);
        int Add(T T);
    }
}
