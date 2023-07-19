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
                new Student() { StudentId = 1, Name = "Varad Mahajan", Age = 23, CSMajor = true },
                new Student() { StudentId = 2, Name = "Elyahu Jacobi", Age = 28, CSMajor = true },
                new Student() { StudentId = 3, Name = "Jon Cathcart", Age = 22, CSMajor = true },
                new Student() { StudentId = 4, Name = "Colin Shea", Age = 22, CSMajor = false },
                new Student() { StudentId = 5, Name = "Ananya Pattnaik", Age = 23, CSMajor = false },
                new Student() { StudentId = 6, Name = "Evan Randal", Age = 23, CSMajor = false }
            };







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