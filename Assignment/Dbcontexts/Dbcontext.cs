global using Assignment.Models;
global using Microsoft.EntityFrameworkCore;

namespace Assignment.Dbcontexts
{
    internal class Dbcontext:DbContext
    {
       public  DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet <Course> Courses { get; set; }

        public DbSet <Instructor> instructors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= Company ; Trusted_connection= True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(Builder =>
            {

                //Builder.Property(e => e.salry).HasColumnType("decimal(18,3)");
                //Builder.HasOne(s => s.Departmentmanged)
                //       .WithOne(d => d.Manger)
                //       .HasForeignKey<Department>(d=>d.MgID);
            });
            modelBuilder.Entity<Student>()
                .HasMany(c => c.course)
                .WithMany(s => s.students)
                .UsingEntity<Studunt_Course>();
            modelBuilder.Entity<Instructor>()
                .HasMany(c => c.courses)
                .WithMany(c => c.instructors)
                .UsingEntity<Course_Instructor>();
            modelBuilder.Entity<Student>()
                .HasOne(c => c.Department)
                .WithMany(c => c.Students)
                .HasForeignKey(c => c.DepartmentId)
               
            ;


        }

    }

}
