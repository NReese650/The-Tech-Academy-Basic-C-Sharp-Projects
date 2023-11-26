using System;
using System.Linq;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press 'F' to list all students, or any other key to exit.");

            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                ListStudents();
            }
        }
        static void ListStudents()
        {
            using (var context = new SchoolContext())
            {
                var students = context.Students.ToList();

                Console.WriteLine("\nList of Students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}");
                }
            }
        }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; } // Primary Key
        public string Name { get; set; }
    }
}