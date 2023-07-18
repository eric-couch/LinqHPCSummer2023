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

            // students
            //var CSMajorsQuery = (   from student in HPCClass
            //                       where student.CSMajor == true
            //                       select student).ToList();
            
            // just names
            var CSMajorsQuery = from student in HPCClass
                               where student.CSMajor == true
                               select student.Name;

            // this is student objects
            //var CSMajorsMethod = HPCClass.Where(student => student.CSMajor == true).ToList();
            // this is just names
            var CSMajorsMethod = HPCClass.Where(student => student.CSMajor == true)
                                            .Select(n => n.Name)
                                            .ToList();

            //foreach (String s in CSMajorsQuery)
            //{
            //    Console.WriteLine(s);
            //}


            IList mixedList = new ArrayList();

            mixedList.Add("zero");
            mixedList.Add(1);
            mixedList.Add("Two");
            mixedList.Add("Three");
            mixedList.Add(4);
            mixedList.Add(new Student() { StudentId = 6, Name = "Evan Randal", Age = 23, CSMajor = false });


            var intResults = from ml in mixedList.OfType<int>() select ml;

            var strResults = from ml in mixedList.OfType<string>() select ml;

            Console.WriteLine("Numbers First:");
            foreach (int i in intResults)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Now strings:");
            foreach (string s in strResults)
            {
                Console.WriteLine(s);
            }
        }
    }
}