using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration {  get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
       public Topic Topic { get; set; }
        public ICollection<Student> students { get; set; } = new HashSet<Student>();
        public ICollection<Instructor>instructors  { get; set; }= new HashSet<Instructor> ();    

    }
}
