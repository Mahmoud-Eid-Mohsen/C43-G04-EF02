global using Assignment.Models;
global using Microsoft.EntityFrameworkCore;

namespace Assignment.Dbcontexts
{
    internal class Dbcontext:DbContext
    {
       public  DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet <Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= Company ; Trusted_connection= True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(Builder =>
            {
                
                //Builder.Property(e => e.salry).HasColumnType("decimal(18,3)");


            });
            
        }

    }

}
