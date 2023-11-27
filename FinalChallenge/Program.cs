using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1: Add a new student");
                Console.WriteLine("2: List all students");
                Console.WriteLine("3: Exit");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ListStudents();
                        break;
                    case "3":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            var student = new Student
            {
                StudentId = studentId,
                FirstName = firstName,
                LastName = lastName,
                Courses = new List<Course>
                {
                    new Course { Name = courseName }
                }
            };

            using (var context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully.");
        }

        static void ListStudents()
        {
            using (var context = new SchoolContext())
            {
                var students = context.Students.Include(s => s.Courses).ToList();

                Console.WriteLine("\nList of Students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}");
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine($"   Course: {course.Name}");
                    }
                }
            }
        }
    }


    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; } // Primary Key
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}