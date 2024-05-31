using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_Academy_Backend.Models;

public partial class EAcademyContext : DbContext
{
    public EAcademyContext()
    {
    }

    public EAcademyContext(DbContextOptions<EAcademyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BlockList> BlockLists { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<QuizAnswer> QuizAnswers { get; set; }

    public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentLesson> StudentLessons { get; set; }

    public virtual DbSet<StudentQuizAttempt> StudentQuizAttempts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlockList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BlockList");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Courses_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseDescription).HasMaxLength(250);
            entity.Property(e => e.CoursePrice).HasMaxLength(50);
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany()
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollments_Courses");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollments_Student");
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FaqAnswer).HasMaxLength(500);
            entity.Property(e => e.FaqQuestion).HasMaxLength(150);
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseOrder).HasMaxLength(50);
            entity.Property(e => e.LessonNumber).HasMaxLength(50);
            entity.Property(e => e.LessonTitle).HasMaxLength(50);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.PdfUrl)
                .HasMaxLength(100)
                .HasColumnName("PdfURL");

            entity.HasOne(d => d.Module).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lessons_Modules");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.ModuleName).HasMaxLength(50);

            entity.HasOne(d => d.Course).WithMany(p => p.Modules)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Modules_Courses");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PaymentAmount).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Student).WithMany(p => p.Payments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payments_Student");
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.ToTable("Quiz");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseOrder).HasMaxLength(50);
            entity.Property(e => e.MinPassScore)
                .HasMaxLength(50)
                .HasColumnName("Min_Pass_Score");
            entity.Property(e => e.QuizName).HasMaxLength(50);
            entity.Property(e => e.QuizNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<QuizAnswer>(entity =>
        {
            entity.ToTable("Quiz_Answer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AnswerText).HasMaxLength(100);
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.QuizAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quiz_Answer_Quiz_Question");
        });

        modelBuilder.Entity<QuizQuestion>(entity =>
        {
            entity.ToTable("Quiz_Question");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.QuestionTitle).HasMaxLength(200);
            entity.Property(e => e.QuizId).HasColumnName("QuizID");

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizQuestions)
                .HasForeignKey(d => d.QuizId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quiz_Question_Quiz");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Rating).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Course).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Reviews_Courses");

            entity.HasOne(d => d.Student).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Reviews_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users");

            entity.ToTable("Student", tb => tb.HasTrigger("trgAfterStudentInserted"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<StudentLesson>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student_Lesson");

            entity.Property(e => e.LessonId).HasColumnName("LessonID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Lesson).WithMany()
                .HasForeignKey(d => d.LessonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Lesson_Lessons");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Lesson_Student");
        });

        modelBuilder.Entity<StudentQuizAttempt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student_Quiz_Attempt");

            entity.Property(e => e.AttemptDate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Attempt_Date");
            entity.Property(e => e.QuizId).HasColumnName("QuizID");
            entity.Property(e => e.Score).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Quiz).WithMany()
                .HasForeignKey(d => d.QuizId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Quiz_Attempt_Quiz");

            entity.HasOne(d => d.Student).WithMany()
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Quiz_Attempt_Student");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
