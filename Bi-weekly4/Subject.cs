using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment
{
    class Subject
    {
        public Subject(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public List<Student> Students { get;}    
  
        public void EnrollStudent(Student student)
        {   //Setting Bi-directional associations:
            //    Subject <--->Student

            Students.Add(student);   
            student.Subjects.Add(this); //Add this subject to the student's subject list 
        }
    }
}
