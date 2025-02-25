using Assignment.Dbcontexts;
using System.Threading.Channels;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Dbcontext dbcontext = new();
            #region insert
            //var student = new Student()
            //{ //Id=1, can not insert Explict value to identity column 
            //    Address = "fayoum",
            //    FName = "mahmoud",
            //    LName = "Eid",
            //    Age = 23

            //};
            ////Add=> local
            //// change Entity state to Added 
            ////dbcontext.Add(student);
            //dbcontext .Entry(student).State.print();
            //dbcontext.Students.Add(student);
            //dbcontext.Entry(student).State.print();
            //dbcontext.SaveChanges();
            //dbcontext.Entry(student).State.print();
            #endregion
            #region update & Retrive 
            // update => change entity state to modified
            //var student2 = dbcontext.Students.FirstOrDefault(s=>s.Id==1);
            //    student2.Age = 24;
            //dbcontext.Entry(student2).State.print();
            //dbcontext.Students.Update(student2);
            //dbcontext.Entry(student2).State.print();
            //dbcontext.SaveChanges();
            //dbcontext.Entry(student2).State.print();
            #endregion
            #region Delete
            var student2 = dbcontext.Students.FirstOrDefault(s => s.Id == 1);
           
            dbcontext.Entry(student2).State.print();
            dbcontext.Students.Remove(student2);
            dbcontext.SaveChanges();



            #endregion
        }
    }
    static class Extention
    {
        public static void print(this object value) => Console.WriteLine(value);


    }
}
