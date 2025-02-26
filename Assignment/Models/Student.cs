using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; }=string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
       
        public int? DepartmentId { get; set; }
        
     

        public Department Department {  get; set; }
        
        public ICollection<Course> course { get; set; }=new HashSet<Course>();





    }
}
