using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public double Salary { get; set; }
        public string Address { get; set; } = string.Empty;
        public double HourRate { get; set; }
        public double Bouns { get; set; }
      
        
        public ICollection<Course>courses  { get; set; }= new HashSet<Course>();
        public Department Departments { get; set; }
    }
}
       



