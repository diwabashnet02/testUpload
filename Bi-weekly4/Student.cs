using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment
{
    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Subjects = new List<Subject>();
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public List<Subject> Subjects { get; }
    }
}
