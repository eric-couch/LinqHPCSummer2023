using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHPCSummer2023;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool CSMajor { get; set; }

    public override string? ToString()
    {
        return $"StudentId: {StudentId} Name: {Name} Age: {Age} CSMajor: {CSMajor}";
    }
}
