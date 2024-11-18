using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>
        {
            new Student { Id = 01, Name = "Nguyen Tran Phu", Age = 16 },
            new Student { Id = 02, Name = "Nguyen Tran Dang", Age = 18 },
            new Student { Id = 03, Name = "Nguyen Tran Duong", Age = 20 },
            new Student { Id = 04, Name = "Nguyen Tran Long", Age = 15 },
            new Student { Id = 05, Name = "An Nguyen Tran", Age = 17 }
        };

            // a
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine("----------------------------------------------");

            // b
            var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nHoc sinh co tuoi tu 15-18:");
            foreach (var student in ageRangeStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine("----------------------------------------------");

            // c
            var studentsWithNameA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu A:");
            foreach (var student in studentsWithNameA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine("----------------------------------------------");

            // d
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi: {totalAge}");
            Console.WriteLine("----------------------------------------------");

            // e
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge).ToList();
            Console.WriteLine("\nHoc sinh co tuoi lon nhat: ");
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine("----------------------------------------------");
            // f
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.ReadLine();
        }
    }
}