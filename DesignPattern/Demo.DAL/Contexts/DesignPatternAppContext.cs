using Demo.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class DesignPatternAppContext : DbContext
    {
        public DesignPatternAppContext(DbContextOptions<DesignPatternAppContext> options):base(options)
        {
            
        }
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       //=> optionsBuilder.UseSqlServer("Server=.; Database=DesignPatternApp; Trusted_Connection=true; multipleactiveresultsets=true; ");
         public DbSet<Department> Departments { get; set; }
         public DbSet<Employee> Employees { get; set; }
    }
}
