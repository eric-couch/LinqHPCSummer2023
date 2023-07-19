using System.Collections;
using System.Net.Http.Headers;

namespace LinqHPCSummer2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> HPCClass = new List<Student>()
            {
                new Student() { StudentId = 1, Name = "Varad Mahajan", Age = 23, CSMajor = true, Major = "CS" },
                new Student() { StudentId = 2, Name = "Elyahu Jacobi", Age = 28, CSMajor = true, Major = "CS" },
                new Student() { StudentId = 3, Name = "Jon Cathcart", Age = 22, CSMajor = true, Major = "CS" },
                new Student() { StudentId = 4, Name = "Colin Shea", Age = 22, CSMajor = false, Major = "Math" },
                new Student() { StudentId = 5, Name = "Ananya Pattnaik", Age = 23, CSMajor = false, Major = "Math" },
                new Student() { StudentId = 6, Name = "Evan Randal", Age = 23, CSMajor = false, Major = "CyberSec" }
            };

            List<Major> majors = new List<Major>()
            {
                new Major() { Id = 1, Name = "CS", FullName = "Computer Science"},
                new Major() { Id = 2, Name = "Math", FullName = "Mathematics"},
                new Major() { Id = 3, Name = "CyberSec", FullName = "Cyber Security"}
            };

            // joins
            // query syntax
            //var studentMajors = from s in HPCClass
            //                    join m in majors
            //                    on s.Major equals m.Name
            //                    select new
            //                    {
            //                        StudentName = s.Name,
            //                        StudentMajor = m.FullName
            //                    };

            //method syntax
            //var studentMajors = HPCClass.Join(
            //                    majors,
            //                    s => s.Major,
            //                    m => m.Name,
            //                    (s, m) => new
            //                    {
            //                        StudentName = s.Name,
            //                        StudentMajor = m.FullName
            //                    });



            //foreach (var sm in studentMajors)
            //{
            //    Console.WriteLine($"student name: {sm.StudentName} major: {sm.StudentMajor}");
            //}


            // group by
            // query syntax
            //var groupedStudents = from s in HPCClass
            //                      group s by s.Age;

            //method syntax
            //var groupedStudents = HPCClass.GroupBy(s => s.Age);


            //foreach (var gs in groupedStudents)
            //{
            //    Console.WriteLine($"This Group is Age: {gs.Key}");

            //    foreach (Student s in gs)
            //    {
            //        Console.WriteLine($"Student Name: {s.Name} Age: {s.Age}");
            //    }
            //}




            // sort examples
            //var sortedStudents = from s in HPCClass
            //                     orderby s.Age, s.Name
            //                     select s;

            //var sortedStudents = HPCClass.OrderBy(s => s.Age).ThenBy(s => s.Name);

            //foreach (Student s in sortedStudents)
            //{
            //    Console.WriteLine($"{s.ToString()}");
            //}
        }
    }
}