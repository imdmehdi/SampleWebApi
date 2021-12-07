using Microsoft.EntityFrameworkCore;

namespace SampleWebApi
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects{get;set;}
        public DbSet<StudentKey> StudentKey { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Write Fluent API configurations here

        //}

    }
}
