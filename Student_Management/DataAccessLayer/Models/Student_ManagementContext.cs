using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Models
{
    public partial class Student_ManagementContext : DbContext
    {
        public Student_ManagementContext()
        {
        }

        public Student_ManagementContext(DbContextOptions<Student_ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student_Management;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("class_id");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("class_code");

                entity.HasMany(d => d.Instructors)
                    .WithMany(p => p.Classes)
                    .UsingEntity<Dictionary<string, object>>(
                        "InstructorClass",
                        l => l.HasOne<Instructor>().WithMany().HasForeignKey("InstructorId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Instructo__instr__33D4B598"),
                        r => r.HasOne<Class>().WithMany().HasForeignKey("ClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Instructo__class__32E0915F"),
                        j =>
                        {
                            j.HasKey("ClassId", "InstructorId").HasName("PK__Instruct__67EA8CE89FAC3D8D");

                            j.ToTable("Instructor_Class");

                            j.IndexerProperty<int>("ClassId").HasColumnName("class_id");

                            j.IndexerProperty<int>("InstructorId").HasColumnName("instructor_id");
                        });

                entity.HasMany(d => d.Subjects)
                    .WithMany(p => p.Classes)
                    .UsingEntity<Dictionary<string, object>>(
                        "SubjectClass",
                        l => l.HasOne<Subject>().WithMany().HasForeignKey("SubjectId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Subject_C__subje__2E1BDC42"),
                        r => r.HasOne<Class>().WithMany().HasForeignKey("ClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Subject_C__class__2D27B809"),
                        j =>
                        {
                            j.HasKey("ClassId", "SubjectId").HasName("PK__Subject___E8F436E0070DBD66");

                            j.ToTable("Subject_Class");

                            j.IndexerProperty<int>("ClassId").HasColumnName("class_id");

                            j.IndexerProperty<int>("SubjectId").HasColumnName("subject_id");
                        });
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => new { e.StudentId, e.SubjectId })
                    .HasName("PK__Grade__3F3349FCB11653BA");

                entity.ToTable("Grade");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.GradeNumber)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("grade_number");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Grade__student_i__29572725");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Grade__subject_i__2A4B4B5E");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");

                entity.Property(e => e.InstructorId)
                    .ValueGeneratedNever()
                    .HasColumnName("instructor_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.InstructorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("instructor_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("student_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("student_name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("subject_id");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("subject_code");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("subject_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
