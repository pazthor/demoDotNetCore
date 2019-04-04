using System;
using demoDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace demoDotNetCore.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        // se renombram las tablas porque :
        // Property names for collections are typically plural(Students rather 
        // than Student), but developers disagree about whether table names 
        // should be pluralized or not.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
