using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment
{
    class Student
    {
        public Student(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
            Subjects = new List<Subject>();
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public List<Subject> Subjects { get; }
    }
}
