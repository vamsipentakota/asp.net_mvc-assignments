using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace codebase6.Model
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }

        public string Adress { get; set; }
    }
}
