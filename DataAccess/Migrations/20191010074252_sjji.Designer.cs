﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20191010074252_sjji")]
    partial class sjji
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp1.AnswerAlt", b =>
                {
                    b.Property<int>("AnswerAltID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlterText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionAnswerID")
                        .HasColumnType("int");

                    b.HasKey("AnswerAltID");

                    b.HasIndex("QuestionAnswerID");

                    b.ToTable("AnswerAlts");
                });

            modelBuilder.Entity("ConsoleApp1.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Room")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("TeacherID");

                    b.HasIndex("TestID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ConsoleApp1.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("GradeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("GradeID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("ConsoleApp1.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerAltID")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionAnswerQuestionAnwID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionAnwID")
                        .HasColumnType("int");

                    b.Property<string>("QuestionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.HasIndex("AnswerAltID");

                    b.HasIndex("QuestionAnswerQuestionAnwID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ConsoleApp1.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestAnswerID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("TestAnswerID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ConsoleApp1.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ConsoleApp1.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int?>("TestAnswerID")
                        .HasColumnType("int");

                    b.Property<string>("TestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("TestAnswerID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("ConsoleApp1.TestAnswer", b =>
                {
                    b.Property<int>("TestAnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerID")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionAnswerQuestionAnwID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionAnwID")
                        .HasColumnType("int");

                    b.HasKey("TestAnswerID");

                    b.HasIndex("QuestionAnswerQuestionAnwID");

                    b.ToTable("TestAnswers");
                });

            modelBuilder.Entity("DataInterface.QuestionAnswer", b =>
                {
                    b.Property<int>("QuestionAnwID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionAnsText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionAnwID");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("ConsoleApp1.AnswerAlt", b =>
                {
                    b.HasOne("DataInterface.QuestionAnswer", "QuestionAnswer")
                        .WithMany("AnswerAlts")
                        .HasForeignKey("QuestionAnswerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Course", b =>
                {
                    b.HasOne("ConsoleApp1.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Test", "Test")
                        .WithMany("Courses")
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Grade", b =>
                {
                    b.HasOne("ConsoleApp1.Course", "Course")
                        .WithMany("Grades")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Question", b =>
                {
                    b.HasOne("ConsoleApp1.AnswerAlt", "AnswerAlt")
                        .WithMany("Questions")
                        .HasForeignKey("AnswerAltID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataInterface.QuestionAnswer", "QuestionAnswer")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionAnswerQuestionAnwID");
                });

            modelBuilder.Entity("ConsoleApp1.Student", b =>
                {
                    b.HasOne("ConsoleApp1.TestAnswer", "TestAnswer")
                        .WithMany("Students")
                        .HasForeignKey("TestAnswerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Test", b =>
                {
                    b.HasOne("ConsoleApp1.Question", "Question")
                        .WithMany("Tests")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.TestAnswer", null)
                        .WithMany("Tests")
                        .HasForeignKey("TestAnswerID");
                });

            modelBuilder.Entity("ConsoleApp1.TestAnswer", b =>
                {
                    b.HasOne("DataInterface.QuestionAnswer", "QuestionAnswer")
                        .WithMany("TestAnswers")
                        .HasForeignKey("QuestionAnswerQuestionAnwID");
                });
#pragma warning restore 612, 618
        }
    }
}
