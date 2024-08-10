using System;
using System.Collections.Generic;

namespace Enrollment
{
    internal class Data
    {
        public static List<Subject> subjects = new List<Subject>();
        public static List<Student> students = new List<Student>();

        internal static void load()
        {

            //create student objects
            students.Add(new Student("John", 25));
            students.Add(new Student("David", 30));
            students.Add(new Student("Roshan", 27));
            students.Add(new Student("Denis", 23));

            subjects.Add(new Subject("Java"));
            subjects.Add(new Subject("Web"));


            SelectSubject("Java").EnrollStudent(SelectStudent("John"));
            SelectSubject("Java").EnrollStudent(SelectStudent("David"));
            SelectSubject("Java").EnrollStudent(SelectStudent("Roshan"));

            SelectSubject("Web").EnrollStudent(SelectStudent("Roshan"));
            SelectSubject("Web").EnrollStudent(SelectStudent("Denis"));
        }

        public static Student SelectStudent(String name)
        {
            foreach (Student s in students)
            {
                if (s.Name == name)
                {
                    return s;
                }
            }
            return null;
        }

        public static Subject SelectSubject(String name)
        {
            foreach (Subject s in subjects)
            {
                if (s.Name == name)
                {
                    return s;
                }
            }
            return null;
        }
    }
}