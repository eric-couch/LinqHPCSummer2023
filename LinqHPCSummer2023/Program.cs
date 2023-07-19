using System.Collections;
using System.Net.Http.Headers;

namespace LinqHPCSummer2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Ely = new Student() { StudentId = 2, Name = "Elyahu Jacobi", Age = 28, CSMajor = true, Major = "CS" };

            List<Student> HPCClass = new List<Student>()
            {
                new Student() { StudentId = 1, Name = "Varad Mahajan", Age = 23, CSMajor = true, Major = "CS" },
                Ely,
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


            // aggregation operators
            var avgAge = HPCClass.Average(s => s.Age);

            Console.WriteLine($"Average age of students: {avgAge}");

            var countStudents = HPCClass.Count(s => s.Age == 23);
            Console.WriteLine($"Students age 23: {countStudents}");

            // FirstOrDefault
            Student? firstCSMajor = HPCClass.Where(s => s.Major == "CS").FirstOrDefault();

            // get computerscience element
            Major? cs = majors.Where(m => m.Name == "CS").FirstOrDefault();

            // FirstOrDefault does the same thing as the First method except it returns the default value of the 
            // datatype even if it doesn't find a matching element

        }
    }
}