using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="THis Feaild Is Requierd")]
        [MaxLength (50, ErrorMessage ="Max Length Is 50")]
        [MinLength (5, ErrorMessage ="Min Length Is 5")]
        public string Name { get; set; }
        [Range(20,60,ErrorMessage ="range 20:60")]
        public int? Age { get; set; }
        //[RegularExpression(@"^(\\d{1,}) [a-zA-Z0-9\\s]+(\\,)? [a-zA-Z]+(\\,)? [A-Z]{2} [0-9]{5,6}$",ErrorMessage = "Address Must be Like -3344 W Alameda Avenue, Lakewood, CO 80222-")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000,8000,ErrorMessage ="selary must be btween 4K : 8K")]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public DateTime HaireDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;





    }
}
