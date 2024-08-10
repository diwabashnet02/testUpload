using System;

namespace Enrollment
{
    class Program
    {

        static void Main(string[] args)
        {
            Data.load();
            Console.WriteLine("Week 6 CHange");
            bool isFinished = false;

            while (true)
            {
                Console.WriteLine("\n\n~~~ Menu ~~~\n");
                Console.WriteLine("1. Subject list");
                Console.WriteLine("2. Student list week 6 change");
                Console.WriteLine("3. Enroll Student");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelection menu option:");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        SubjectList();
                        break;
                    case 2:
                        StudentList();
                        break;
                    case 3:
                        EnrollStudent();
                        break;
                    case 4:
                        isFinished = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection(1-4)");
                        break;
                }

                if (isFinished)
                {
                    Console.WriteLine(" Done!");
                    break;
                }
            }//end while

            Console.WriteLine("\n Press any key to continue ...");
            Console.ReadLine();
        }

        private static void EnrollStudent()
        {
            Console.WriteLine(" --- Enroll Student ---");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Register student
            Data.students.Add(new Student(name,age));


            Console.Write("Select subject (Java|Web): ");
            string subject = Console.ReadLine();

            Subject subj = Data.SelectSubject(subject);
            Student stud = Data.SelectStudent(name);
            subj.EnrollStudent(stud);

            Console.WriteLine("{0} enrolled in {1}", name, subject);
        }
        private static void SubjectList()
        {
            Console.WriteLine("\n--- Subject List ---");

            foreach (Subject subj in Data.subjects)
            {
                Console.WriteLine("\nSubject: {0}\n", subj.Name);
                Console.WriteLine("\t{0,-15}", "Students enrolled:");
                Console.WriteLine("\t--------------");

                foreach (Student stud in subj.Students)
                {
                    Console.WriteLine("\t{0,-15}", stud.Name);
                }
            }
        }
        private static void StudentList()
        {
            Console.WriteLine("\n--- Student List ---");

            foreach (Student stud in Data.students)
            {
                Console.WriteLine("\nStudent: {0}\n", stud.Name);
                Console.WriteLine("\t{0,-15}", "Subjects");
                Console.WriteLine("\t--------------");

                foreach (Subject subj in stud.Subjects)
                {
                    Console.WriteLine("\t{0,-15}", subj.Name);
                }
            }
        }

    }
}
