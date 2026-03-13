using Microsoft.EntityFrameworkCore;
using UniversityMS.Models;

namespace UniversityMS.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ── Enrollment (junction table) ───────────────────────────────
            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.EnrollmentId);

                entity.HasOne(e => e.Student)
                      .WithMany(s => s.Enrollments)
                      .HasForeignKey(e => e.StudentId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Course)
                      .WithMany(c => c.Enrollments)
                      .HasForeignKey(e => e.CourseId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.Property(e => e.Grade).HasMaxLength(2);
            });

            // ── Course → Instructor (one Instructor teaches many Courses) ──
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.CourseId);
                entity.Property(c => c.Title).IsRequired().HasMaxLength(150);

                entity.HasOne(c => c.Instructor)
                      .WithMany(i => i.Courses)
                      .HasForeignKey(c => c.InstructorId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // ── Instructor → Department (one Department has many Instructors)
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(i => i.InstructorId);
                entity.Property(i => i.Name).IsRequired().HasMaxLength(100);

                entity.HasOne(i => i.Department)
                      .WithMany(d => d.Instructors)
                      .HasForeignKey(i => i.DepartmentId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // ── Student ───────────────────────────────────────────────────
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.StudentId);
                entity.Property(s => s.FullName).IsRequired().HasMaxLength(100);
                entity.Property(s => s.Email).IsRequired().HasMaxLength(150);
                entity.HasIndex(s => s.Email).IsUnique();
            });

            // ── Department ────────────────────────────────────────────────
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);
                entity.Property(d => d.Name).IsRequired().HasMaxLength(100);
                entity.Property(d => d.Budget).HasColumnType("decimal(18,2)");
            });
        }
    }
}