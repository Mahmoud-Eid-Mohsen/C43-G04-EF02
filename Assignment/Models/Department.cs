

using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    internal class Department
    {


        public int ID { get; set; }
        public int Ins_ID { get; set; }     
        public string Name { get; set; } = string.Empty;
        public DateTime HiringDate { get; set; }
        
   public ICollection<Student> Students { get; set; }
       public ICollection<Instructor> instructors  { get; set; }= new HashSet<Instructor>(); 






    }
}
