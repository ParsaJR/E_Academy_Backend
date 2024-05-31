﻿// <auto-generated />
using System;
using E_Academy_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Academy_Backend.Migrations
{
    [DbContext(typeof(EAcademyContext))]
    [Migration("20240528160429_EAcademy_Migration")]
    partial class EAcademy_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Academy_Backend.Models.BlockList", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable((string)null);

                    b.ToView("BlockList", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CoursePrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Courses_1");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Enrollment", b =>
                {
                    b.Property<DateOnly?>("CompletedDate")
                        .HasColumnType("date");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<DateOnly>("EnrollmentDate")
                        .HasColumnType("date");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FaqAnswer")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FaqQuestion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseOrder")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LessonDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LessonTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int")
                        .HasColumnName("ModuleID");

                    b.Property<string>("PdfUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PdfURL");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModuleNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PaymentAmount")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<string>("CourseOrder")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MinPassScore")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Min_Pass_Score");

                    b.Property<string>("QuizName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QuizNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.QuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionID");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Quiz_Answer", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.QuizQuestion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("QuestionTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int")
                        .HasColumnName("QuizID");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Quiz_Question", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<string>("Rating")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("CreationDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.ToTable("Student", null, t =>
                        {
                            t.HasTrigger("trgAfterStudentInserted");
                        });

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.StudentLesson", b =>
                {
                    b.Property<DateOnly?>("CompletedDate")
                        .HasColumnType("date");

                    b.Property<int>("LessonId")
                        .HasColumnType("int")
                        .HasColumnName("LessonID");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Lesson", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.StudentQuizAttempt", b =>
                {
                    b.Property<string>("AttemptDate")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Attempt_Date")
                        .IsFixedLength();

                    b.Property<int>("QuizId")
                        .HasColumnType("int")
                        .HasColumnName("QuizID");

                    b.Property<string>("Score")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasIndex("QuizId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Quiz_Attempt", (string)null);
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Enrollment", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .IsRequired()
                        .HasConstraintName("FK_Enrollments_Courses");

                    b.HasOne("E_Academy_Backend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Enrollments_Student");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Lesson", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Module", "Module")
                        .WithMany("Lessons")
                        .HasForeignKey("ModuleId")
                        .IsRequired()
                        .HasConstraintName("FK_Lessons_Modules");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Module", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .IsRequired()
                        .HasConstraintName("FK_Modules_Courses");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Payment", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Student", "Student")
                        .WithMany("Payments")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Payments_Student");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.QuizAnswer", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.QuizQuestion", "Question")
                        .WithMany("QuizAnswers")
                        .HasForeignKey("QuestionId")
                        .IsRequired()
                        .HasConstraintName("FK_Quiz_Answer_Quiz_Question");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.QuizQuestion", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .IsRequired()
                        .HasConstraintName("FK_Quiz_Question_Quiz");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Review", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Course", "Course")
                        .WithMany("Reviews")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Reviews_Courses");

                    b.HasOne("E_Academy_Backend.Models.Student", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Reviews_Student");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.StudentLesson", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Lesson_Lessons");

                    b.HasOne("E_Academy_Backend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Lesson_Student");

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.StudentQuizAttempt", b =>
                {
                    b.HasOne("E_Academy_Backend.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Quiz_Attempt_Quiz");

                    b.HasOne("E_Academy_Backend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK_Student_Quiz_Attempt_Student");

                    b.Navigation("Quiz");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Course", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Module", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Quiz", b =>
                {
                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.QuizQuestion", b =>
                {
                    b.Navigation("QuizAnswers");
                });

            modelBuilder.Entity("E_Academy_Backend.Models.Student", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}