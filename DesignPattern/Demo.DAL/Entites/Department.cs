using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entites
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Feaild Is required")]
        public string Name { get; set; }
        [Required (ErrorMessage = "This Feaild Is required")]
        [StringLength (100 ,MinimumLength =5 ,ErrorMessage ="invalid char lenght")]
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
