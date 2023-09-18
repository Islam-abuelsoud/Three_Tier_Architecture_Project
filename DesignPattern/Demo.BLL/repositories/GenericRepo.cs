using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly DesignPatternAppContext context;
        public GenericRepo(DesignPatternAppContext context)
        {
            this.context = context;
        }

        public int Add(T T)
        {
            context.Set<T>().Add(T);
            return context.SaveChanges();
        }

        public int Delete(T T)
        {
            context.Set<T>().Remove(T);
            return context.SaveChanges();
        }

        public T get(int? id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public int Update(T T)
        {
            context.Set<T>().Update(T);
            return context.SaveChanges();
        }
    }
}
