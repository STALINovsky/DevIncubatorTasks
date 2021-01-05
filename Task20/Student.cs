using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task20
{

    class Student
    {
        public const int SCHOOL_NUMBER = 1;
        // Static field for counting the number of students
        private static int CountOfStudents { get; set; }

        /// <summary>
        /// Factory method to read list of students by user input
        /// </summary>
        /// <returns></returns>
        public static List<Student> ReadStudents()
        {
            //showing type of generation students
            Console.WriteLine($"static constructor executing");
            PrintCountOfStudents();

            Console.WriteLine("Enter count of students to add");
            var countOfStudentsToAdd = int.Parse(Console.ReadLine());

            var students = new List<Student>();
            //fill students list
            for (int i = 0; i < countOfStudentsToAdd; i++)
            {
                var lastNameOfStudent = Console.ReadLine();
                var firstNameOfStudent = Console.ReadLine();
                var averageGradeOfStudent = double.Parse(Console.ReadLine());

                students.Add(new Student(firstNameOfStudent, lastNameOfStudent, averageGradeOfStudent));
            }

            return students;
        }


        public string FirstName { get; }
        public string LastName { get; }
        public double AverageGrade { get; }

        public Student(string firstName, string lastName, double averageGrade)
        {
            Console.WriteLine($"Default constructor executing {CountOfStudents + 1}");
            FirstName = firstName;
            LastName = lastName;
            AverageGrade = averageGrade;

            // increase the counter by 11
            CountOfStudents++;
        }

        private static void PrintCountOfStudents()
        {
            Console.WriteLine($"Count of students = {CountOfStudents}");
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {AverageGrade}";
        }
    }
}
